
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class VampRing : GoldRing
	{
		public override int ArtifactRarity{ get{ return 4377; } }

		public bool m_Transformed;
		public Timer m_TransformTimer;
		private DateTime m_End;

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Transformed
		{
			get{ return m_Transformed; }
			set{ m_Transformed = value; }
		}

		[Constructable]
		public VampRing()
		{
			Hue = 2410;
			LootType = LootType.Blessed;
			Name = "Draculas Embrace";
			Hue = 37;
			Attributes.WeaponDamage = 15;
			Attributes.ReflectPhysical = 15;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			Attributes.RegenStam = 5;
			Attributes.RegenMana = 5;
			Attributes.RegenHits = 5;
		}

		public VampRing( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDoubleClick( Mobile from ) 
		{ 
			VampGloves gloves = from.FindItemOnLayer( Layer.Gloves ) as VampGloves;
			VampHelm helm = from.FindItemOnLayer( Layer.Helm ) as VampHelm;
			VampLegs legs = from.FindItemOnLayer( Layer.Pants ) as VampLegs;
			VampArms arms = from.FindItemOnLayer( Layer.Arms ) as VampArms;
			VampGorget gorget = from.FindItemOnLayer( Layer.Neck ) as VampGorget;
			VampEarrings earrings = from.FindItemOnLayer( Layer.Earrings ) as VampEarrings;
			VampRing ring = from.FindItemOnLayer( Layer.Ring ) as VampRing;
			VampBracelet bracelet = from.FindItemOnLayer( Layer.Bracelet ) as VampBracelet;

                        if ( Parent != from ) 
                        { 
                                from.SendMessage( "Draculas ring must be equiped to recieve the keys to the inner chamber" ); 
                        } 

			else if ( gloves == null || helm == null || legs == null || arms == null || gorget == null || earrings == null || ring == null || bracelet == null )
			{
				from.SendMessage( "You must have all the pieces of the Vampire and Dracula equiped to transform!" );
			}

                        else if ( this.Transformed == false )
                        { 
				from.PlaySound( 0x220 );
				from.BodyMod = 0x0;
				from.DisplayGuildTitle = false; 
				this.Transformed = true; 
				from.AddToBackpack( new DracsKey() );
				from.AddToBackpack( new BookOfTheDammed() );
			}
			else
			{
				from.PlaySound( 0x220 );
				from.BodyMod = 0x0;
				from.DisplayGuildTitle = true;
				this.Transformed = false;
			}
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}