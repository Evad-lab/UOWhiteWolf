using Server.Targeting;

namespace Server.Items
{
    public class DurabilityRemovalScroll : Item
    {
        [Constructable]
        public DurabilityRemovalScroll()
            : base(0x14F0)
        {
            Weight = 1.0;
            Name = "Durability Removal Scroll";
            LootType = LootType.Blessed;
            Hue = 1174;
        }

        public override bool DisplayLootType { get { return false; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
            else
            {
                from.SendMessage("Target the item you wish to remove durability from.");
                from.Target = new RemoveDurabilityTarget(this);
            }
        }

        public DurabilityRemovalScroll(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            LootType = LootType.Blessed;

            int version = reader.ReadInt();
        }

    }
    public class RemoveDurabilityTarget : Target
    {
        private DurabilityRemovalScroll m_Deed;

        public RemoveDurabilityTarget(DurabilityRemovalScroll deed)
            : base(1, false, TargetFlags.None)
        {
            m_Deed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            object t = target;
            Mobile m = from;

            if (t is BaseWeapon || t is BaseArmor || t is BaseJewel || t is BaseClothing )
            {
                Item i = (Item)target;
                if (i.RootParent != m)
                {
                    m.SendMessage("The item is out of range");
                }

                RemoveDurability(i);
                m_Deed.Delete();
            }
        }
        private void RemoveDurability(Item i)
        {
            if (i is BaseWeapon)
            {
                ((BaseWeapon)i).MaxHitPoints = 0;
                ((BaseWeapon)i).HitPoints = 0;
            }

            if (i is BaseArmor)
            {
                ((BaseArmor)i).MaxHitPoints = 0;
                ((BaseArmor)i).HitPoints = 0;
            }
            if (i is BaseJewel)
            {
                ((BaseJewel)i).MaxHitPoints = 0;
                ((BaseJewel)i).HitPoints = 0;
            }
            if (i is BaseClothing)
            {
                ((BaseClothing)i).MaxHitPoints = 0;
                ((BaseClothing)i).HitPoints = 0;
            }
        }

    }


}