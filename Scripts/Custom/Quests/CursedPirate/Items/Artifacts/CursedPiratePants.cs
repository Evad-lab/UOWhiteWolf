using System; 
using Server.Network; 
using Server.Targeting; 
using Server.Items; 

namespace Server.Items 
{
	[FlipableAttribute( 0x152e, 0x152f )]
	public class CursedPiratePants : BasePants
	{
            public override int ArtifactRarity { get { return 20; } }  
            public override int PoisonResistance{ get{ return 8; } } 
	    public override int PhysicalResistance{ get{ return 10; } }
	    public override int FireResistance{ get{ return 12; } }
	    public override int EnergyResistance{ get{ return 6; } }
            public override int ColdResistance{ get{ return 6; } }

		[Constructable]
		public CursedPiratePants() : this( 0 )
		{
            Name = "Cursed Pirate Pants";
            Hue = 0x497;

            SkillBonuses.SetValues(0, SkillName.Parry, (Utility.Random(4) == 0 ? 15.0 : 10.0));

            Attributes.DefendChance = 10;
            Attributes.BonusStr = 5;
            //Attributes.ReflectPhysical = 10;
            Attributes.Luck = 100;
		}

		[Constructable]
		public CursedPiratePants( int hue ) : base( 0x152E, hue )
		{
			Weight = 2.0;
		}

		public CursedPiratePants( Serial serial ) : base( serial )
		{
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