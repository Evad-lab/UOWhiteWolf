using System;
using Server;
using Server.Targeting;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{

     public class UnivTubTarget : Target
     {
            private Item m_Item;

            public UnivTubTarget( Item item ) : base( 12, false, TargetFlags.None )
            {
                   m_Item = item;
            }

protected override void OnTarget( Mobile from, object target )
		{
			//Gold m_Gold = (Gold)from.BankBox.FindItemByType( typeof( Gold ) );
			//Gold b_Gold = (Gold)from.BankBox.FindItemByType( typeof( Gold ) );
			//int m_Amount = from.BankBox.GetAmount( typeof( Gold ) );
			//int b_Amount = from.BankBox.GetAmount( typeof( Gold ) );
			

			if (target is BaseContainer)
			{
				//if (b_Amount > 99999)
				{
					BaseContainer z = target as BaseContainer;

                             		if ( !z.IsChildOf (from.Backpack))
                             		{
						if ( z is Backpack ) //it allow players to dye their backpacks for 1kk
						{
							//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
							//from.SendMessage( "Removed 100,000 gold from bank and hued it." );
                               		  		z.Hue = m_Item.Hue;
                                                    m_Item.Delete();
                               		  		//from.PlaySound( 0x23F );
						}

						else
						{                                 	 	
							from.SendMessage( "The item is not in your pack!" );
						}
                             		}					
					else
					{
                                 		z.Hue = m_Item.Hue;
                                           m_Item.Delete();
                                 		//from.PlaySound( 0x23F );
						//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
						//from.SendMessage( "Removed 50,000 gold from your bank and hued your item." );
					}
				}

				//else if (m_Amount >= 99999)
				{
					BaseContainer z = target as BaseContainer;
					
					if ( !z.IsChildOf (from.Backpack))
					{
						from.SendMessage( "The item is not in your pack!" );
					}
					else
					{
						z.Hue = m_Item.Hue;
                           m_Item.Delete();
                                 		//from.PlaySound( 0x23F );
						//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
						//from.SendMessage( "Removed 100,000 gold from your BankBox and hued your item." );
					}
				}

				//else if (b_Amount >= 99999)
				{
					BaseContainer z = target as BaseContainer;
					
					if ( !z.IsChildOf (from.Backpack))
					{
						from.SendMessage( "The item is not in your pack!" );
					}
					else
					{
						z.Hue = m_Item.Hue;
                           m_Item.Delete();
                                 		//from.PlaySound( 0x23F );
						//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
						//from.SendMessage( "Removed 100,000 gold from your bank and hued your item." );
					}
				}
			}

			else if (target is BaseJewel || target is BaseArmor || target is BaseClothing || target is BaseWeapon || target is BaseShield || target is EtherealMount || target is BaseSuit || target is Item )
			{
				//if (m_Amount > 99999)
				{
					if ( target is Item )
                        		{
                            			Item x = (Item)target;
                             			if ( !x.IsChildOf (from.Backpack))
                             			{
                                  			from.SendMessage( "The item is not in your pack!" );
                             			}
                             			else
                             			{
                                 			x.Hue = m_Item.Hue;
                                               m_Item.Delete();
                                 			//from.PlaySound( 0x23F );
							//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
							//from.SendMessage( "Removed 100,000 gold from your BankBox and hued your item." );
                             			}
					}
				}

				//else if (b_Amount > 99999)
				{
					if ( target is Item )
                        		{
                            			Item x = (Item)target;
                             			if ( !x.IsChildOf (from.Backpack))
                             			{
                                  			from.SendMessage( "The item is not in your pack!" );
                             			}
                             			else
                             			{
                                 			x.Hue = m_Item.Hue;
                                               m_Item.Delete();
                                 			//from.PlaySound( 0x23F );
							//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
							//from.SendMessage( "Removed 100,000 gold from your bank and hued your item." );
                             			}
					}
				}
				
			}

			else if (target is BaseCreature)
			{
				//if (m_Amount > 99999)
				{
					BaseCreature y = target as BaseCreature;
					
					if (y.Controlled && y.ControlMaster == from)
					{
						y.Hue = m_Item.Hue;
                            m_Item.Delete();
						//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
						//from.SendMessage( "Removed 100,000 gold from BankBox and hued your pet." );
					}
					else
					{
						from.SendMessage("You can only dye animals whom you control!");
					}
				}

				//else if (b_Amount > 99999)
				{
					BaseCreature y = target as BaseCreature;
					
					if (y.Controlled && y.ControlMaster == from)
					{
						y.Hue = m_Item.Hue;
                            m_Item.Delete();
						//from.BankBox.ConsumeTotal( typeof( Gold ), 100000 );
						//from.SendMessage( "Removed 100,000 gold from your bank and hued your pet." );
					}
					else
					{
						from.SendMessage("You can only dye animals whom you control!");
					}
				}
			}

			else
			{
				from.SendMessage("Invalid target.");
			}
		}
	}
	

     public class UniversalDyeTub : Item
     {

            private bool m_Redyable;


            [Constructable]
            public UniversalDyeTub() : base( 0xFAB )
            {
                   Weight = 0.0;
                   Hue = 0;
                   Name = "Universal Dye Tub";
                   m_Redyable = false;
            }

            public UniversalDyeTub( Serial serial ) : base( serial )
            {
            }

            public override void OnDoubleClick( Mobile from )
            {

                   from.Target = new UnivTubTarget( this );
                   from.SendMessage( "What do you wish to dye?" );

            }

            public override void Serialize( GenericWriter writer )
            {
                   base.Serialize( writer );
                   writer.Write( (int) 0 ); // version
            }

            public override void Deserialize( GenericReader reader )
            {
                   base.Deserialize( reader );
                   int version = reader.ReadInt();
            }
     }
}