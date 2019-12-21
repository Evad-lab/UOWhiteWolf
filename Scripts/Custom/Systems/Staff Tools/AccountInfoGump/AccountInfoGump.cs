using System;
using Server;
using Server.Accounting;
using Server.Mobiles;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Server.Commands;
using Server.Targeting;
using System.Globalization;

namespace Server.Gumps
{
    public class AccountSearch : BaseGump
    {
        public enum SearchCriteria
        {
            None,
            AccountName,
            CharacterName,
            Banned,
            IP,
        }

        public static void Initialize()
        {
            CommandSystem.Register("AccountInfo", CheckLevel, e =>
                {
                    BaseGump.SendGump(new AccountSearch(e.Mobile as PlayerMobile));
                });

            CommandSystem.Register("ViewAccountInfo", CheckLevel, e =>
            {
                Mobile m = e.Mobile;

                m.BeginTarget(-1, false, TargetFlags.None, (from, targeted) =>
                    {
                        if (targeted is Mobile && ((Mobile)targeted).Account is Account)
                        {
                            var gump = new AccountSearch(e.Mobile as PlayerMobile);
                            gump.Accounts = new List<Account>();
                            gump.Accounts.Add((Account)from.Account);
                            gump.Selected = (Account)from.Account;

                            BaseGump.SendGump(gump);
                        }
                        else
                        {
                            from.SendMessage("You cannot use this command on that.");
                        }
                    });
            });
        }

        public static AccessLevel CheckLevel = AccessLevel.Administrator;
        public readonly int PerPage = 12;

        public SearchCriteria SearchBy { get; set; }
        public List<Account> Accounts { get; set; }
        public bool ExactName { get; set; }
        public bool ActiveOnly { get; set; }
        public string TextInput { get; set; }

        public int Index { get; set; }
        public Account Selected { get; set; }
        public Mobile Player { get; set; }

        public AccountSearch(PlayerMobile pm)
            : base(pm, 30, 30)
        {
            SearchBy = SearchCriteria.None;
            Index = 0;
        }

        public override void AddGumpLayout()
        {
            AddBackground(0, 0, 600, 460, 9270);
            AddAlphaRegion(10, 10, 580, 440);

            AddBackground(15, 15, 230, 125, 9270);
            AddBackground(15, 145, 230, 278, 9270);
            AddBackground(255, 75, 329, 370, 9270);

            AddImageTiled(265, 85, 309, 350, 2624);
            AddImageTiled(25, 25, 210, 105, 2624);
            AddImageTiled(25, 155, 210, 258, 2624);

            AddImage(568, 5, 10410);
            AddImage(570, 160, 10411);
            AddImage(570, 319, 10412);

            //Search Functions
            AddImageTiled(66, 30, 168, 20, 9254);
            AddButton(30, 29, 4005, 4007, 1, GumpButtonType.Reply, 0);
            AddTextEntry(68, 30, 166, 20, 0, 1, TextInput);

            AddHtml(30, 58, 80, 16, Color("#FFFFFF", "Search By"), false, false);
            AddButton(200, 57, 4005, 4006, 2, GumpButtonType.Reply, 0);
            AddImageTiled(100, 57, 100, 21, 9254);
            AddHtml(100, 57, 100, 21, ColorAndCenter("#FFFFFF", GetCriteria()), false, false);

            AddHtml(55, 85, 100, 16, Color("#FFFFFF", "Search Exact Name"), false, false);
            AddCheck(30, 85, 210, 211, ExactName, 1);

            AddHtml(55, 105, 150, 16, Color("#FFFFFF", "Active Accounts Only"), false, false);
            AddCheck(30, 105, 210, 211, ActiveOnly, 2);

            AddHtml(255, 35, 335, 16, ColorAndCenter("#FFFFFF", "Account Search"), false, false);

            if (Index < 0 || (Accounts != null && Index >= Accounts.Count))
                Index = 0;

            if (Accounts != null && Accounts.Count > 0)
            {
                int actualIndex = 0;
                int y = 158;

                for (int i = Index; i < Accounts.Count; i++)
                {
                    if (actualIndex >= PerPage)
                        break;

                    var a = Accounts[i];

                    string hue = a == Selected ? "#FFD700" : "#FFFFFF";

                    AddButton(29, y + (actualIndex * 20), 4005, 4006, 10000 + i, GumpButtonType.Reply, 0);
                    AddHtml(65, y + (actualIndex * 20), 170, 20, Color(hue, a.Username), false, false); 

                    actualIndex++;
                }

                if (Index > 0)
                {
                    AddButton(15, 423, 4014, 4015, 4, GumpButtonType.Reply, 0);
                }
                
                if (Index + PerPage < Accounts.Count)
                {
                    AddButton(215, 423, 4005, 4006, 3, GumpButtonType.Reply, 0);
                }

                AddLabel(120, 425, 2032, ((Index / PerPage) + 1).ToString());
            }

            if (Selected != null)
            {
                BuildDetailsLayout();
            }
        }

        public override void OnResponse(RelayInfo info)
        {
            if (User.AccessLevel < CheckLevel)
                return;

            int id = info.ButtonID;

            if (id != 0)
            {
                ExactName = info.IsSwitched(1);
                ActiveOnly = info.IsSwitched(2);

                TextRelay relay = info.GetTextEntry(1);
                TextInput = relay.Text;
            }

            switch (id)
            {
                case 0: break;
                case 1: // text input
                    SearchAccounts(TextInput);
                    Refresh();
                    break;
                case 2: // criteria ++
                    if (SearchBy == SearchCriteria.IP)
                        SearchBy = SearchCriteria.None;
                    else
                        SearchBy++;
                    Refresh();
                    break;
                case 3: // next page
                    Index += PerPage;
                    Refresh();
                    break;
                case 4: // prev page
                    Index -= PerPage;
                    Refresh();
                    break;
                case 5: // admin page
                    Refresh();
                    if(Selected != null)
                        User.SendGump(new AdminGump(User, AdminGumpPage.AccountDetails, 0, null, null, Selected));
                    break;
                case 6:
                    if (Selected != null)
                    {
                        TextRelay r = info.GetTextEntry(2);
                        int newGold = -1;

                        if (int.TryParse(r.Text, out newGold))
                        {
                            BaseGump.SendGump(new ConfirmCallbackGump(User, "Set Account Gold", String.Format("By Selecting yes, you will change selected account gold from <color=#008080>{0:#,0} to <color=#00FFFF>{1:#,0}.", Selected.TotalGold.ToString(), newGold.ToString()), new object[] { Selected, newGold, this },
                                confirm: (m, state) =>
                                {
                                    object[] objs = (object[])state;
                                    Account acct = objs[0] as Account;
                                    int gold = (int)objs[1];
                                    BaseGump g = objs[2] as BaseGump;

                                    if (gold > acct.TotalGold)
                                    {
                                        acct.DepositGold(gold - acct.TotalGold);
                                        User.SendMessage("You increase their account gold to {0}.", gold);
                                    }
                                    else if (gold < acct.TotalGold)
                                    {
                                        acct.WithdrawGold(acct.TotalGold - gold);
                                        User.SendMessage("You decrease their account gold to {0}.", gold);
                                    }

                                    g.Refresh();
                                },
                                close: (m, state) =>
                                {
                                    object[] objs = (object[])state;
                                    BaseGump g = objs[2] as BaseGump;

                                    g.Refresh();
                                }
                                ));
                        }
                        else
                        {
                            Refresh();
                            User.SendMessage(32, "Invalid gold amount.");
                        }

                    }
                    break;
                case 7:
                    {
                         if (Selected != null)
                         {
                             TextRelay tr = info.GetTextEntry(3);
                             int newPlat = -1;

                             if(int.TryParse(tr.Text, out newPlat))
                             {
                                 BaseGump.SendGump(new ConfirmCallbackGump(User, "Set Account Platinum", String.Format("By Selecting yes, you will change selected account platinum from <color=#008080>{0:#,0} to <color=#00FFFF>{1:#,0}.", Selected.TotalPlat.ToString(), newPlat.ToString()), new object[] { Selected, newPlat,this },
                                     confirm: (m, state) =>
                                     {
                                         object[] objs = (object[])state;
                                         Account acct = objs[0] as Account;
                                         int plat = (int)objs[1];
                                         BaseGump g = objs[2] as BaseGump;

                                         if (plat > acct.TotalPlat)
                                         {
                                             acct.DepositPlat(plat - acct.TotalPlat);
                                             User.SendMessage("You increase their account platinum to {0}.", plat);
                                         }
                                         else if (plat < acct.TotalPlat)
                                         {
                                             acct.WithdrawPlat(acct.TotalPlat - plat);
                                             User.SendMessage("You decrease their account platinum to {0}.", plat);
                                         }

                                         g.Refresh();
                                     },
                                     close: (from, state) =>
                                     {
                                         object[] objs = (object[])state;
                                         BaseGump g = objs[2] as BaseGump;

                                         g.Refresh();
                                     }
                                     ));
                             }
                             else
                             {
                                 Refresh();
                                 User.SendMessage(32, "Invalid platinum amount.");
                             }
                         }
                    }
                    break;
                case 8:
                     {
                         if (Selected != null && Player != null)
                         {
                             TextRelay tre = info.GetTextEntry(4);
                             int sec = -1;

                             if (int.TryParse(tre.Text, out sec))
                             {
                                 BaseGump.SendGump(new ConfirmCallbackGump(User, String.Format("Set Secure Gold for {0}", Player.Name), String.Format("By Selecting yes, you will change selected account platinum from <color=#008080>{0:#,0} to <color=#00FFFF>{1:#,0}.", Selected.GetSecureAccountAmount(Player).ToString(), sec.ToString()), new object[] { Selected, Player, sec, this },
                                     confirm: (m, state) =>
                                     {
                                         object[] objs = (object[])state;
                                         Account acct = objs[0] as Account;
                                         Mobile player = objs[1] as Mobile;
                                         int plat = (int)objs[2];
                                         BaseGump g = objs[3] as BaseGump;

                                         int current = acct.GetSecureAccountAmount(player);

                                         if (sec > current)
                                         {
                                             acct.DepositToSecure(player, sec - current);
                                             User.SendMessage("You increase {0}'s account platinum to {1}.", player.Name, sec);
                                         }
                                         else if (sec < current)
                                         {
                                             acct.WithdrawFromSecure(player, current - plat);
                                             User.SendMessage("You decrease {0}'s account platinum to {1}.", player.Name, sec);
                                         }

                                         g.Refresh();
                                     },
                                     close: (from, state) =>
                                     {
                                         object[] objs = (object[])state;
                                         BaseGump g = objs[3] as BaseGump;

                                         g.Refresh();
                                     }
                                     ));
                             }
                             else
                             {
                                 Refresh();
                                 User.SendMessage(32, "Invalid secure gold amount for {0}.", Player.Name);
                             }
                         }
                    }
                    break;
                default:
                    if (id >= 10000)
                    {
                        id = id - 10000;

                        if (id >= 0 && id < Accounts.Count)
                        {
                            Account a = Accounts[id];

                            if (Selected != null && Selected == a)
                            {
                                Selected = null;
                            }
                            else
                            {
                                Selected = a;
                            }
                        }

                        Refresh();
                    }
                    else if (id >= 100 && Selected != null)
                    {
                        id = id - 100;

                        if (id >= 0 && id < Selected.Length)
                        {
                            Mobile m = Selected[id];

                            Player = m;
                        }

                        Refresh();
                    }
                    break;
            }
        }

        private void BuildDetailsLayout()
        {
            Account a = Selected;

            int y = 100;

            AddHtml(270, y, 200, 16, Color("#FFD700", "Account:"), false, false);
            AddHtml(420, y, 200, 16, Color("#FFFFFF", a.Username + String.Format("{0}", a.Banned ? "<basefont color=red> [Banned]" : a.Inactive ? "<basefond color=red> [Inactive]" : "<basefont color=green> [Active]")), false, false);
            y += 20;
            AddHtml(270, y, 200, 16, Color("#FFD700", "Created:"), false, false);
            AddHtml(420, y, 200, 16, Color("#FFFFFF", a.Created.ToShortDateString()), false, false);
            y += 20;
            AddHtml(270, y, 200, 16, Color("#FFD700", "Total Game Time:"), false, false);
            AddHtml(420, y, 200, 16, Color("#FFFFFF", AdminGump.FormatTimeSpan(a.TotalGameTime)), false, false);
            y += 20;
            AddHtml(270, y, 200, 16, Color("#FFD700", "Characters:"), false, false);

            y += 20;
            bool accountGold = AccountGold.Enabled;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null)
                    continue;

                string hue = SearchBy == SearchCriteria.CharacterName && CompareStrings(TextInput, a[i].Name) ? "#FFD700" : "#FFFFFF";

                if (accountGold)
                {
                    AddButton(i % 2 == 0 ? 272 : 427, y + 2, 2086, 2086, 100 + i, GumpButtonType.Reply, 0);
                }

                if (i % 2 == 0)
                {
                    AddLabelCropped(290, y, 150, 20, 986, a[i].Name);
                }
                else
                {
                    AddLabelCropped(445, y, 150, 20, 986, a[i].Name);
                    y += 20;
                }
            }

            y += 30;

            if (accountGold)
            {
                AddHtml(270, y, 200, 16, Color("#FFD700", "Account Gold:"), false, false);
                AddHtml(450, y, 200, 16, Color("#FFFFFF", String.Format("{0:#,0}", a.TotalGold.ToString("N0", CultureInfo.GetCultureInfo("en-US")))), false, false);
                y += 22;
                AddButton(270, y, 4014, 4015, 6, GumpButtonType.Reply, 0);
                AddImageTiled(305, y, 100, 20, 9254);
                AddTextEntry(307, y, 98, 20, 0, 2, "Set Gold");
                y += 22;
                AddHtml(270, y, 200, 16, Color("#FFD700", "Account Platinum:"), false, false);
                AddHtml(450, y, 200, 16, Color("#FFFFFF", String.Format("{0:#,0}", a.TotalPlat.ToString("N0", CultureInfo.GetCultureInfo("en-US")))), false, false);
                y += 22;
                AddButton(270, y, 4014, 4015, 7, GumpButtonType.Reply, 0);
                AddImageTiled(305, y, 100, 20, 9254);
                AddTextEntry(307, y, 98, 20, 0, 3, "Set Plat");

                if (Player != null && Player.Account == Selected)
                {
                    y += 22;
                    AddHtml(270, y, 180, 16, Color("#FFD700", String.Format("{0}'s Secure Account:", Player.Name)), false, false);
                    AddHtml(450, y, 200, 16, Color("#FFFFFF", String.Format("{0:#,0}", a.GetSecureAccountAmount(Player).ToString("N0", CultureInfo.GetCultureInfo("en-US")))), false, false);
                    y += 22;
                    AddButton(270, y, 4014, 4015, 8, GumpButtonType.Reply, 0);
                    AddImageTiled(305, y, 100, 20, 9254);
                    AddTextEntry(307, y, 98, 20, 0, 4, "Set Secure");
                }
            }

            if (User.AccessLevel >= AccessLevel.Administrator)
            {
                AddHtml(303, 411, 150, 16, Color("#FFD700", "Admin Page"), false, false);
                AddButton(270, 411, 4005, 4006, 5, GumpButtonType.Reply, 0);
            }
        }

        public void SearchAccounts(string str)
        {
            if ((str == null || String.IsNullOrEmpty(str)) && SearchBy != SearchCriteria.Banned && SearchBy != SearchCriteria.None)
                return;

            if (Accounts != null)
                ColUtility.Free(Accounts);

            string match = str.ToLower().Trim();
            List<Account> list = null;

            switch (SearchBy)
            {
                default:
                    {
                        list = Server.Accounting.Accounts.GetAccounts().OfType<Account>().Where(a => a != null
                                                                                        && (!ActiveOnly || !a.Inactive)).ToList();

                        break;
                    }
                case SearchCriteria.AccountName:
                    {
                        list = Server.Accounting.Accounts.GetAccounts().OfType<Account>().Where(a => a != null
                                                                                        && CompareStrings(match, a.Username)
                                                                                        && (!ActiveOnly || !a.Inactive)).ToList();
                        break;
                    }
                case SearchCriteria.CharacterName:
                    {
                        list = Server.Accounting.Accounts.GetAccounts().OfType<Account>().Where(a => a != null
                                                                                        && a.Count > 0
                                                                                        && (!ActiveOnly || !a.Inactive)
                                                                                        && GetMobiles(a).Any(mob => mob != null
                                                                                                                && !mob.Deleted
                                                                                                                && CompareStrings(match, mob.Name))).ToList();
                        break;
                    }
                case SearchCriteria.Banned:
                    {
                        list = Server.Accounting.Accounts.GetAccounts().OfType<Account>().Where(a => a != null
                                                                                    && a.Banned
                                                                                    && (match == null || CompareStrings(match, a.Username))
                                                                                    && (!ActiveOnly || !a.Inactive)).ToList();

                        break;
                    }
                case SearchCriteria.IP:
                    {
                        list = Server.Accounting.Accounts.GetAccounts().OfType<Account>().Where(a => a.LoginIPs != null
                                                                                    && a.LoginIPs.Length > 0
                                                                                    && (!ActiveOnly || !a.Inactive)
                                                                                    && a.LoginIPs.Any(ip => CheckIP(match, ip))).ToList(); //(info => (Utility.IPMatchCIDR(match, info.Address) 
                        //           || Utility.IPMatch(match, info.Address))).Count() > 0);
                    }
                    break;
            }

            if (list != null)
                Accounts = list;

            if (SearchBy != SearchCriteria.None && Accounts.Count > 0)
                Accounts.Sort(AccountComparer.Instance);

            User.SendMessage(1289, "Your search results in {0} matches.", Accounts.Count);
        }

        public static Mobile[] GetMobiles(Account acc)
        {
            if (acc is IAccount)
                return EnumerateMobiles(acc).ToArray();

            return null;
        }

        public static IEnumerable<Mobile> EnumerateMobiles(Account acct)
        {
            if (acct == null)
                yield break;

            for (int i = 0; i < acct.Length; i++)
            {
                if (acct[i] != null)
                    yield return acct[i];
            }
        }

        private string DisplayAccount(Account a)
        {
            if (a == null)
                return "Unknown";

            switch (SearchBy)
            {
                default:
                case SearchCriteria.AccountName:
                case SearchCriteria.Banned: return a.Username;
                case SearchCriteria.CharacterName:
                    foreach (Mobile m in GetMobiles(a).Where(m => m != null))
                    {
                        if (m.Name.ToLower().IndexOf(TextInput.ToLower()) >= 0)
                            return m.Name;
                    }
                    break;
                case SearchCriteria.IP:
                    foreach (var ip in a.LoginIPs)
                    {
                        if (Utility.IPMatchCIDR(TextInput.ToLower(), ip) || Utility.IPMatch(TextInput.ToLower(), ip))
                            return TextInput;
                    }
                    break;
            }

            return "Unknown";
        }

        private bool CompareStrings(string input, string check)
        {
            if (input == null || check == null)
                return false;

            check = check.ToLower();

            if (ExactName)
            {
                if (input == check)
                    return true;
            }
            else
                return check.IndexOf(input) >= 0;

            return false;
        }

        private bool CheckIP(string input, IPAddress check)
        {
            if (input == null || check == null)
                return false;

            if (Utility.IPMatch(input, check))
                return true;

            try
            {
                if (Utility.IPMatchCIDR(input, check))
                    return true;
            }
            catch
            {
            }

            return false;
        }

        private class AccountComparer : IComparer<Account>
        {
            public static readonly IComparer<Account> Instance = new AccountComparer();

            public AccountComparer()
            {
            }

            public int Compare(Account a, Account b)
            {
                if (a == null && b == null)
                    return 0;
                else if (a == null)
                    return -1;
                else if (b == null)
                    return 1;

                AccessLevel aLevel, bLevel;
                bool aOnline, bOnline;

                AdminGump.GetAccountInfo(a, out aLevel, out aOnline);
                AdminGump.GetAccountInfo(b, out bLevel, out bOnline);

                if (aOnline && !bOnline)
                    return -1;
                else if (bOnline && !aOnline)
                    return 1;
                else if (aLevel > bLevel)
                    return -1;
                else if (aLevel < bLevel)
                    return 1;
                else
                    return Insensitive.Compare(a.Username, b.Username);
            }
        }

        private string GetCriteria()
        {
            switch (SearchBy)
            {
                default:
                case SearchCriteria.None: return "None";
                case SearchCriteria.AccountName: return "Account Name";
                case SearchCriteria.CharacterName: return "Player Name";
                case SearchCriteria.Banned: return "Banned";
                case SearchCriteria.IP: return "IP";
            }
        }
    }
}