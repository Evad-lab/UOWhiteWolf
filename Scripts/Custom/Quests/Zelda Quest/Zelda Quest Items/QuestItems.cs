using System;
using Server;

namespace Server.Items
{
	


	public class Mirror : BronzeShield
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int ArtifactRarity{ get{ return 50; } }

		[Constructable]
		public Mirror()
		{
			Name = "Mirror Shield";
			Hue = 1150;

			Attributes.DefendChance = 30;
			Attributes.AttackChance = 30;
			FireBonus = 10;
			PhysicalBonus = 20;
			Attributes.WeaponDamage = 20;
			Attributes.WeaponSpeed = 20;
			ArmorAttributes.SelfRepair = 10;
			Attributes.SpellChanneling = 1;

		}

		public Mirror( Serial serial ) : base( serial )
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
	public class MegatonHammer : WarHammer
	{

      		public override int AosMinDamage{ get{ return 30; } } 
      		public override int AosMaxDamage{ get{ return 40; } } 
      		public override int AosSpeed{ get{ return 40; } } 


		public override int ArtifactRarity{ get{ return 500; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MegatonHammer()
		{
			Name = "Megaton Hammer";
			Hue = 1161;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 30;
			Attributes.WeaponDamage = 50;
			Attributes.BonusDex = 10;
			Attributes.BonusStr = 10;
			
			

		}

		public MegatonHammer( Serial serial ) : base( serial )
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
	public class Mastersword : Longsword
	{

		public override int ArtifactRarity{ get{ return 500; } }
		public override int AosMinDamage{ get{ return 25; } } 
      		public override int AosMaxDamage{ get{ return 35; } } 
      		public override int AosSpeed{ get{ return 40; } } 
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Mastersword()
		{
			Name = "The Master Sword";
			Hue = 2220;

			WeaponAttributes.UseBestSkill = 1;
			//WeaponAttributes.HitEnergyArea = 25;
			WeaponAttributes.HitPhysicalArea = 25;
			WeaponAttributes.HitPoisonArea = 25;
			//WeaponAttributes.HitColdArea = 50;
			//WeaponAttributes.HitFireArea = 50;
			Attributes.WeaponDamage = 50;
			Attributes.BonusStr = 5;
			Attributes.RegenHits = 5;
			Attributes.BonusDex = 5;
			Attributes.BonusInt = 5;

		}

		public Mastersword( Serial serial ) : base( serial )
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
	public class KokiriKnife : SkinningKnife
	{

		public override int ArtifactRarity{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public KokiriKnife()
		{
			Name = "Kokiri Knife";
			Hue = 547;

			Attributes.SpellChanneling = 1;
			Attributes.SpellDamage = 50;
			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 150;
			Attributes.WeaponDamage = -50;
			Attributes.BonusInt = 100;

		}

		public KokiriKnife( Serial serial ) : base( serial )
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
	public class GreatFairyS : Longsword
	{

	      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
	      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosMinDamage{ get{ return 20; } } 
		public override int AosMaxDamage{ get{ return 25; } } 
		public override int AosSpeed{ get{ return 25; } } 


		public override int ArtifactRarity{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GreatFairyS() : base( 0x26CF )
		{
			Name = "Great Fairy Sword";
			Hue = 1150;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 50;
			Attributes.RegenMana = 25;
			Attributes.WeaponDamage = 50;
			Attributes.WeaponSpeed = 150;
			Attributes.BonusDex = 10;
			Attributes.BonusStr = 10;
			Attributes.RegenHits = 5;

		}

		public GreatFairyS( Serial serial ) : base( serial )
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
	public class DekuShield : BronzeShield
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int ArtifactRarity{ get{ return 50; } }

		[Constructable]
		public DekuShield()
		{
			Name = "Deku Shield";
			Hue = 347;

			Attributes.DefendChance = 30;
			Attributes.AttackChance = 30;
			FireBonus = -40;
			PhysicalBonus = 25;
			Attributes.SpellDamage = 30;
			Attributes.WeaponSpeed = 10;
			ArmorAttributes.SelfRepair = 5;
			Attributes.SpellChanneling = 1;

		}

		public DekuShield( Serial serial ) : base( serial )
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
	public class Biggoron : BaseSword
	{

	      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
	      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosMinDamage{ get{ return 20; } } 
		public override int AosMaxDamage{ get{ return 30; } } 
		public override int AosSpeed{ get{ return 25; } } 


		public override int ArtifactRarity{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Biggoron() : base( 0x26CE )  //Item ID changed by Red Kitty
		{
			Name = "Biggoron Sword";
			Hue = 2101;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponDamage = 50;
			Attributes.BonusDex = 10;
			Attributes.BonusStr = 10;
			Attributes.RegenHits = 10;

		}

		public Biggoron( Serial serial ) : base( serial )
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