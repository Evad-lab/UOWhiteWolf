using System; 
using Server.Network; 
using Server.Targeting; 
using Server.Items; 

namespace Server.Items 
{
    [FlipableAttribute(0x1EFD, 0x1EFE)]
    public class CursedPirateShirt : BaseShirt
    {
        public override int ArtifactRarity { get { return 20; } }  
        public override int PoisonResistance{ get{ return 10; } } 
        public override int PhysicalResistance{ get{ return 6; } }
        public override int FireResistance{ get{ return 5; } }
        public override int EnergyResistance{ get{ return 2; } }
        public override int ColdResistance{ get{ return 4; } }

        [Constructable] 
        public CursedPirateShirt() : base( 0x1EFD ) 
        { 
            Hue = 1153; 
            Weight = 1.0; 
            Layer = Layer.Shirt; 
            Name = "Cursed Pirate Shirt";

            SkillBonuses.SetValues(0, SkillName.Anatomy, (Utility.Random(4) == 0 ? 10.0 : 5.0));
            SkillBonuses.SetValues(0, SkillName.Swords, (Utility.Random(4) == 0 ? 15.0 : 10.0));

            Attributes.DefendChance = 10;
            Attributes.Luck = 100;
            //Attributes.ReflectPhysical = 10;
            Attributes.AttackChance = 10;
            Attributes.BonusDex = 5;
        } 

        public CursedPirateShirt( Serial serial ) : base( serial ) 
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