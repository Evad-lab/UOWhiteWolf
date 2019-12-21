using System;
using Server.Network;
using Server.Prompts;
using Server.Mobiles;
using Server.Misc;
using Server.Items;
using Server.Gumps;
using Server.Targeting;
using Server.Targets;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
	public class PetLevelUpDeed : Item
	{
        private int m_Value;

        [CommandProperty(AccessLevel.GameMaster)]
        public int Value
        {
            get
            {
                return m_Value;
            }
        }

		[Constructable]
        public PetLevelUpDeed( int value ): base(0x14F0)
		{
			Weight = 1.0;
			Name = "Pet Level Increase Deed";
            Hue = 0x64;

			LootType = LootType.Cursed;

            m_Value = value;
		}
		
		[Constructable]
        public PetLevelUpDeed( ): base(0x14F0)
		{
			Weight = 1.0;
			Name = "Pet Level Increase Deed";
            Hue = 0x64;

			LootType = LootType.Cursed;

            m_Value = 1;
		}		

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (m_Value == 5.0)
                list.Add("a wonderous scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 10.0)
                list.Add("an exalted scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 15.0)
                list.Add("a mythical scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 20.0)
                list.Add("a legendary scroll of Pet Leveling (+{0} max levels)", m_Value);
            else
                list.Add("a scroll of Pet Leveling (+{0} max levels)", m_Value);
        }

        public override void OnSingleClick(Mobile from)
        {
            if (m_Value == 5.0)
                base.LabelTo(from, "a wonderous scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 10.0)
                base.LabelTo(from, "an exalted scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 15.0)
                base.LabelTo(from, "a mythical scroll of Pet Leveling (+{0} max levels)", m_Value);
            else if (m_Value == 20.0)
                base.LabelTo(from, "a legendary scroll of Pet Leveling (+{0} max levels)", m_Value);
            else
                base.LabelTo(from, "a scroll of Pet Leveling (+{0} max levels)", m_Value);
        }


		public PetLevelUpDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            //Version 0
            writer.Write((int)m_Value);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    {
                        m_Value = reader.ReadInt();
                        break;
                    }
            }
		}

		public override void OnDoubleClick( Mobile from )
		{

			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
				return;
			}
			else
			{
				from.SendMessage( "Which pet would you like to level up?" );
				from.Target = new PetTarget( this ); // Call our target
			}
		}

		public class PetTarget : Target
		{
			private PetLevelUpDeed m_Scroll;

            public PetTarget(PetLevelUpDeed scroll): base(-1, false, TargetFlags.None)
			{
				this.m_Scroll = scroll;
			}

			protected override void OnTarget( Mobile from, object target )
			{
				if ( target is Item )
				{
					from.SendMessage( "This scroll cannot be applied to that!" );
				}
                else if (target is BaseCreature)
                {
                    BaseCreature pet = (BaseCreature)target;

                    if (pet != null && pet.ControlMaster != null && pet.ControlMaster != from) // Make sure they own the pet
                    {
                        from.SendMessage("The pet must be yours to level it up.");
                    }
                    else if (pet.ControlMaster != null && pet.ControlMaster == from)
                    {
						pet.MaxLevel += m_Scroll.Value;
						from.SendMessage("Your pet's maximum level has been increased by " + m_Scroll.Value + " levels.");
						m_Scroll.Delete();						
                    }
                }
                else
                {
                    from.SendMessage("Invalid Target Type.");
                }
			}
		}
	}
}