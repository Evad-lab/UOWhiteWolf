using System;
using Server.Items;


namespace Server.Items
{
    public class CursedPirateBoots : BaseArmor
    {
        public override int ArtifactRarity { get { return 20; } }  
        public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }
        public override int PhysicalResistance { get { return 6; } }
        public override int PoisonResistance { get { return 12; } }
        public override int FireResistance { get { return 8; } } 
        public override int EnergyResistance { get { return 10; } } 
        public override int ColdResistance { get { return 6; } } 
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
                
		[Constructable]
		public CursedPirateBoots() : base( 0x1711 )
		{
			Weight = 0.3;
            Hue = 0x497;
            Name = "Cursed Pirate Boots";

            SkillBonuses.SetValues(0, SkillName.Stealth, (Utility.Random(4) == 0 ? 15.0 : 10.0));

            Attributes.BonusDex = 5;
            //Attributes.BonusStr = 15;
            Attributes.Luck = 100;
            Attributes.RegenHits = 2;
		}

		public CursedPirateBoots( Serial serial ) : base( serial )
		{
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