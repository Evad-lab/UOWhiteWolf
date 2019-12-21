using System;
using System.Drawing;
using Server.Targeting;

namespace Server.Items
{
    public class UseBestSkillTarget : Target
    {
        private readonly UseBestSkillDeed _mDeed;

        public UseBestSkillTarget(UseBestSkillDeed deed)
            : base(1, false, TargetFlags.None)
        {
            _mDeed = deed;
        }

        protected override void OnTarget(Mobile from, object target)
        {
            var weapon = target as BaseWeapon;
            if (weapon == null)
            {
                @from.SendMessage("You cannot put Use Best Skill on that");
            }
            else
            {
                var item = (Item)target;

                if (((BaseWeapon)item).WeaponAttributes.UseBestSkill == 1)
                {
                    @from.SendMessage("That weapon already has Use Best Skill!");
                }
                else
                {
                    if (item.RootParent != @from)
                    {
                        @from.SendMessage("You cannot put Use Best Skill on that item!");
                    }
                    else
                    {
                        ((BaseWeapon)item).WeaponAttributes.UseBestSkill = 1;
                        @from.SendMessage("You add Use Best Skill to your weapon....");

                        _mDeed.Delete();
                    }
                }
            }
        }
    }

    public sealed class UseBestSkillDeed : Item
    {
        [Constructable]
        public UseBestSkillDeed()
            : base(0x14F0)
        {
            Weight = 1.0;
            Name = "a Use Best Skill deed";
            LootType = LootType.Blessed;
            Hue = 0x492;
        }

        public UseBestSkillDeed(Serial serial)
            : base(serial)
        {
        }
        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            LootType = LootType.Blessed;

            reader.ReadInt();
        }

        public override bool DisplayLootType { get { return false; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001);
            }
            else
            {
                from.SendMessage("What item would you like to add Use Best Skill to?");
                from.Target = new UseBestSkillTarget(this);
            }
        }
    }
}