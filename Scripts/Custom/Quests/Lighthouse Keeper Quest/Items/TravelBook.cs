using System;
using System.Collections;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Regions;

namespace Server.Items
{
    public class TravelBook : Item
    {

        private int m_Charges;

        [CommandProperty(AccessLevel.GameMaster)]
        public int Charges
        {
            get { return m_Charges; }
            set { m_Charges = value; InvalidateProperties(); }
        }

        [Constructable]
        public TravelBook()
            : this(25)
        {
        }

        [Constructable]
        public TravelBook(int charges)
            : base(0x238C)
        {
            m_Charges = charges;
            Movable = true;
            Name = "Travel Book";
            Hue = 60;
        }

        public TravelBook(Serial serial)
            : base(serial)
        {
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);

            list.Add(1060741, m_Charges.ToString()); // charges: ~1_val~
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!from.Player)
            {
                return;
            }
            if (@from.Region != null && @from.Region.Name == "Jail")
            {
                from.SendMessage("Don't try to be a smartass."); 
                return;
            }
            if (from.InRange(GetWorldLocation(), 1))
                BeginUsing(from, true);
            else
                from.SendLocalizedMessage(500446); // That is too far away.
        }

        public void BeginUsing(Mobile from, bool useCharges)
        {
            Map map = from.Map;

            if (map == null || map == Map.Internal)
                return;

            if (useCharges)
            {
                if (Charges > 0)
                {
                    --Charges;
                    UseGate(from);
                }
                else
                {
                    from.SendLocalizedMessage(502412); // There are no charges left on that item.
                    from.SendMessage("The Travel Book has now exploded!");
                    from.PlaySound(777);
                    this.Delete();
                    return;
                }
            }
        }

        public bool UseGate(Mobile m)
        {
            if (m.Criminal)
            {
                m.SendLocalizedMessage(1005561, "", 0x22); // Thou'rt a criminal and cannot escape so easily.
                return false;
            }
            else if (Server.Spells.SpellHelper.CheckCombat(m))
            {
                m.SendLocalizedMessage(1005564, "", 0x22); // Wouldst thou flee during the heat of battle??
                return false;
            }
            else if (m.Spell != null)
            {
                m.SendLocalizedMessage(1049616); // You are too busy to do that at the moment.
                return false;
            }
            else
            {
                m.CloseGump(typeof(MoongateGump));
                m.SendGump(new MoongateGump(m, this));

                if (!m.Hidden || m.AccessLevel == AccessLevel.Player)
                    Effects.PlaySound(m.Location, m.Map, 0x20E);

                return true;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version

            writer.Write((int)m_Charges);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_Charges = reader.ReadInt();
                        break;
                    }
            }
        }



    }
}

