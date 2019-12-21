
using System;
using Server;
using Server.Items;
using Server.Commands;
using Solaris.ItemStore;


namespace Server.Scripts.Commands
{
    public class FillFromStock
    {
        public static void Initialize()
        {
            CommandSystem.Register("FillFromStock", AccessLevel.Player, new CommandEventHandler(FillFromStock_OnCommand));
            CommandSystem.Register("FFS", AccessLevel.Player, new CommandEventHandler(FillFromStock_OnCommand));
        }
        [Usage("FillFromStock")]
        [Aliases("FFS")]
        [Description("This will add supplys to storage keys from players backpack.")]
        public static void FillFromStock_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;
            MasterItemStoreKey key = (MasterItemStoreKey)BaseStoreKey.FindItemByType(from.Backpack, typeof(MasterItemStoreKey));

            if (key == null)
            {
                from.SendMessage("You do not have a Master key in your pack.");
                return;
            }
            

               key.FillEntriesFromBackpack( from );

               from.SendMessage("You have added all eligible to the Master Key.");



        }
    }
}
 