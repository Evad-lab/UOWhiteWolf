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

using Xanthos.Evo;

namespace Server.Items
{
	public class PetGenderChangeDeed : Item
	{		
		[Constructable]
        public PetGenderChangeDeed( ): base(0x14F0)
		{
			Weight = 1.0;
			Name = "Pet Gender Change Deed";
            Hue = 0x64;

			LootType = LootType.Cursed;
		}		

		public PetGenderChangeDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            //Version 0
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

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
				from.SendMessage( "Which pet would you like to change ?" );
				from.Target = new PetTarget( this ); // Call our target
			}
		}

		public class PetTarget : Target
		{
			private PetGenderChangeDeed m_Scroll;

            public PetTarget(PetGenderChangeDeed scroll): base(-1, false, TargetFlags.None)
			{
				m_Scroll = scroll;
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
                        from.SendMessage("The pet must be yours to change it.");
                    }
                    else if (pet != null && pet.ControlMaster != null && pet.ControlMaster == from  )
                    {
						if (pet != null && !(pet is BaseEvo) && !(pet is BaseEvoMount) && !(pet is Squire))
						{
							if (pet != null && pet.Female == true)
							{
								pet.Female = false;
								pet.InvalidateProperties();
								from.SendMessage("Your pet's gender has changed.");
								m_Scroll.Delete();		
							}
							else if (pet != null && pet.Female == false)
							{
								pet.Female = true;
								pet.InvalidateProperties();
								from.SendMessage("Your pet's gender has changed.");
								m_Scroll.Delete();	
							}
						}
						else
						{
							from.SendMessage("The pet must not be an EVO or a Squire to change its gender.");
						}
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