  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
using Server;

namespace Server.Items
{
	public class DraculasShroud : BaseArmor, IDyable
	{
        	public override int ArtifactRarity{ get{return 666; } }

		public override int BasePhysicalResistance{ get{ return 15; } }
		public override int BaseFireResistance{ get{ return 15; } }
		public override int BaseColdResistance{ get{ return 15; } }
		public override int BasePoisonResistance{ get{ return 15; } }
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int OldDexBonus{ get{ return -8; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }

		public bool m_Transformed;
		public Timer m_TransformTimer;
		private DateTime m_End;

		private StatMod m_StatMod0;
		private StatMod m_StatMod1;
		private StatMod m_StatMod2;

		[CommandProperty( AccessLevel.GameMaster )]
		public bool Transformed
		{
			get{ return m_Transformed; }
			set{ m_Transformed = value; }
		}

		[Constructable]
		public DraculasShroud() : base( 0x2684 )
		{
                        Name = "Draculas Demise";
                        Attributes.CastRecovery = 6;
                        Attributes.CastSpeed = 4;
                        Attributes.SpellDamage = 25;  
                        Attributes.LowerManaCost = 15;
						Attributes.ReflectPhysical = 15;
						Attributes.WeaponSpeed = 30;
						Attributes.WeaponDamage = 25;
			
                        Hue = 1;
                        Layer = Layer.OuterTorso;
                        ItemID = 0x2684;

						Weight = 3.0;
						LootType = LootType.Blessed;
		}

		public DraculasShroud( Serial serial ) : base( serial )
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
                                from.SendMessage( "The Shroud of Dracula must be equiped to be used." ); 
                        } 

			else if ( from.Mounted == true )
			{
				from.SendMessage( "You cannot be mounted while trying to transform!" );
			}

			else if ( gloves == null || helm == null || legs == null || arms == null || gorget == null || earrings == null || ring == null || bracelet == null )
			{
				from.SendMessage( "You must have all the pieces of the Vampire equiped to transform!" );
			}

                        else if ( this.Transformed == false )
                        { 
				
				LootType = LootType.Blessed;
               			from.SendMessage( "You pull the hood over your head." );
				from.PlaySound( 0x220 );
				//from.Title = "the True Vampire";
				from.BodyMod = 146;
				from.NameHue = 39;
				from.HueMod = 1;
				from.DisplayGuildTitle = false; 
				this.Transformed = true; 
				ItemID = 9860;
				from.RemoveItem(this);
              			from.EquipItem(this);

				m_StatMod0 = new StatMod( StatType.Str, "MOD0", 25, TimeSpan.Zero );
				m_StatMod1 = new StatMod( StatType.Int, "MOD1", 25, TimeSpan.Zero );
				m_StatMod2 = new StatMod( StatType.Dex, "MOD2", 25, TimeSpan.Zero );
				from.AddStatMod( m_StatMod0 );
				from.AddStatMod( m_StatMod1 );
				from.AddStatMod( m_StatMod2 );
                        
			}
			else
			{
				from.SendMessage( "You lower the hood." );
				from.PlaySound( 0x220 );
				//from.Title = null;
				from.BodyMod = 0x0;
				from.NameHue = -1;
				from.HueMod = -1;
				from.DisplayGuildTitle = true;
				this.Transformed = false;
				ItemID = 0x1F03;
				from.RemoveItem(this);
              			from.EquipItem(this);
				from.RemoveStatMod( "MOD0" );
				from.RemoveStatMod( "MOD1" );
				from.RemoveStatMod( "MOD2" );
			}
		}

		public virtual bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted )
				return false;
			else if ( RootParent is Mobile && from != RootParent )
				return false;

			Hue = sender.DyedHue;

			return true;
		}
			
		public override void OnRemoved( Object o )
      		{
      			if( o is Mobile )
      			{
				( (Mobile)o).RemoveStatMod( "MOD0" );
				( (Mobile)o).RemoveStatMod( "MOD1" );
				( (Mobile)o).RemoveStatMod( "MOD2" );
				
     			}
      			if( o is Mobile && ((Mobile)o).Kills >= 5)
               		{
               			( (Mobile)o).Criminal = true;
                	}
      			if( o is Mobile && ((Mobile)o).GuildTitle != null )
               		{
          			( (Mobile)o).DisplayGuildTitle = true;
                	}
				
      			base.OnRemoved( o );
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
