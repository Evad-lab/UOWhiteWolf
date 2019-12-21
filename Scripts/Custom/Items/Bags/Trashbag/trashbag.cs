using System;
using Server;
using Server.Items;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;

namespace Server.Items
{
    public class TrashBag : Bag
    {

        private int m_Points;

        [CommandProperty(AccessLevel.GameMaster)]
        public int Points { get { return m_Points; } set { m_Points = value; InvalidateProperties(); } }

        [Constructable]
        public TrashBag()
        {
            LootType = LootType.Blessed;
            Movable = true;
            m_Points = 0;
            Name = "a trash bag";
            Hue = 54;
        }


        public TrashBag(Serial serial)
            : base(serial)
        {
        }



        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            if (!base.OnDragDrop(from, dropped))
                return false;
            if (dropped is Gold)
                return false;
            if (dropped is BaseContainer)
                seachbag(dropped, from);

            m_Points += dropped.Amount;
            dropped.Delete();

            dropped.InvalidateProperties();
            return true;
        }

        public override bool OnDragDropInto(Mobile from, Item item, Point3D p)
        {
            if (!base.OnDragDropInto(from, item, p))
                return false;
            if (item is Gold)
                return false;
            if(item.CheckNewbied() || item.Insured || item.PayedInsurance)
                return false;
            if (item is BaseContainer)
                seachbag(item, from);
            m_Points += item.Amount;
            item.Delete();

            item.InvalidateProperties();
            return true;
        }

        private void seachbag(Item b, Mobile from)
        {
            BaseContainer bag = (BaseContainer)b;
            List<Item> items = bag.Items;
            List<Item> delme = new List<Item>();
            List<Item> movme = new List<Item>();
            foreach (Item i in items)
            {
                if (i is Gold || i.CheckNewbied() || i.Insured || i.PayedInsurance)
                {
                    movme.Add(i);
                    continue;
                }
                if (i is BaseContainer)
                    seachbag(i, from);
                delme.Add(i);
            }

            foreach (Item i in movme)
            {
                if (!i.Deleted)
                    from.PlaceInBackpack(i);
            }

            foreach (Item i in delme)
            {
                if (!i.Deleted)
                {
                    m_Points += i.Amount;
                    i.Delete();
                }
            }
        }



        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_Points > 0)
                list.Add("  <BASEFONT COLOR=#cc0000>{0}<BASEFONT COLOR=#001bcc> Trash points!", m_Points.ToString());
            else list.Add(" *Empty* ");
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)m_Points);
            writer.Write((int)0); // version 
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            m_Points = reader.ReadInt();
            int version = reader.ReadInt();
        }
    }
}
