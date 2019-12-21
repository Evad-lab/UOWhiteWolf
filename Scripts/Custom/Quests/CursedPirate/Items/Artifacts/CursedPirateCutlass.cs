using System;
using Server;

namespace Server.Items
{
    public class CursedPirateCutlass : Cutlass
    {
        public override int ArtifactRarity{ get{ return 20; } }
        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }
              
        [Constructable]
        public CursedPirateCutlass() 
        {
            Weight = 8;
            Name = "Cursed Pirate Cutlass";
            Hue = 0x497;

            SkillBonuses.SetValues(0, SkillName.Swords, (Utility.Random(4) == 0 ? 10.0 : 5.0));

            //WeaponAttributes.HitLeechHits = 50;
            WeaponAttributes.HitLightning = 50;
            //WeaponAttributes.SelfRepair = 5;
              
            Attributes.AttackChance = 10;
            Attributes.BonusStr = 5;
            Attributes.Luck = 100;
            //Attributes.SpellChanneling = 1;
            Attributes.WeaponDamage = 50;
            Attributes.WeaponSpeed = 25;
        }   
              
        public CursedPirateCutlass( Serial serial ) : base( serial )  
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