using System; 
using Server.Items; 

namespace Server.Items 
{ 
   public class HatOfKillar : BaseArmor 
   { 
                public override int PhysicalResistance{ get{ return 0; } } 
                public override int FireResistance{ get{ return 5; } } 
                public override int ColdResistance{ get{ return 9; } } 
                public override int PoisonResistance{ get{ return 20; } } 
                public override int EnergyResistance{ get{ return 7; } } 

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

      public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } } 

                public override int ArtifactRarity{ get{ return 20; } } 

      [Constructable] 
      public HatOfKillar() : base( 0x1718 ) 
      { 
         Weight = 1.0; 
                        Name = "Hat Of Killar"; 
                        Hue = 1161; 
                        StrRequirement = 10;
 
                        Attributes.BonusInt = 10;
			Attributes.BonusDex = 5;
			Attributes.RegenMana = 3;
			Attributes.WeaponSpeed = 5;
			Attributes.CastRecovery = 2;
			Attributes.CastSpeed = 1;

      } 

      public HatOfKillar( Serial serial ) : base( serial ) 
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