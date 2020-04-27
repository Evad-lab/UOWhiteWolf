/*
 * Created by SharpDevelop.
 * User: Sharon
 * Date: 12/1/2005
 * Time: 5:35 AM
 * 
 * 
 */
 using System; 
 using Server;

namespace Server.Items
{
	
	[FlipableAttribute( 0x2FC4, 0x317A )]
	public class SantasElfBoots : BaseShoes, IArcaneEquip
	{
		#region Arcane Impl
		[CommandProperty( AccessLevel.GameMaster )]
		public int TempHue { get; set; }

		[CommandProperty( AccessLevel.GameMaster )]
		public int MaxArcaneCharges { get; set; }

		[CommandProperty( AccessLevel.GameMaster )]
		public int CurArcaneCharges { get; set; }

		[CommandProperty( AccessLevel.GameMaster )]
		public bool IsArcane
		{
			get{ return ( MaxArcaneCharges > 0 && CurArcaneCharges >= 0 ); }
		}

		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			if ( IsArcane )
				LabelTo( from, 1061837, String.Format( "{0}\t{1}", CurArcaneCharges, MaxArcaneCharges ) );
		}

		public void Update()
		{
			if ( IsArcane )
				ItemID = 0x317A;
			else if ( ItemID == 0x317A )
				ItemID = 0x2FCA;

			if ( IsArcane && CurArcaneCharges == 0 )
				Hue = 0;
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			if ( IsArcane )
				list.Add( 1061837, "{0}\t{1}", CurArcaneCharges, MaxArcaneCharges ); // arcane charges: ~1_val~ / ~2_val~
		}

		public void Flip()
		{
			if ( ItemID == 0x2FCA )
				ItemID = 0x317A;
			else if ( ItemID == 0x317A )
				ItemID = 0x2FCA;
		}
		#endregion

		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		[Constructable]
		public SantasElfBoots() : this( 0 )
		{
		}

		[Constructable]
		public SantasElfBoots( int hue ) : base( 0x2FCA, hue )
		{
            Name = "Santa's Elf Boots";
			Weight = 4.0;
			
			MaxArcaneCharges= 25;
			CurArcaneCharges = 25;
			TempHue = 1159;
			
			Attributes.NightSight = 1;
			Attributes.BonusDex = 3;
		}

		public SantasElfBoots( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

			if ( IsArcane )
			{
				writer.Write( true );
				writer.Write( (int) CurArcaneCharges );
				writer.Write( (int) MaxArcaneCharges );
			}
			else
			{
				writer.Write( false );
			}
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					if ( reader.ReadBool() )
					{
						CurArcaneCharges = reader.ReadInt();
						MaxArcaneCharges = reader.ReadInt();

						if ( Hue == 2118 )
							Hue = ArcaneGem.DefaultArcaneHue;
					}

					break;
				}
			}
		}
	}
}
