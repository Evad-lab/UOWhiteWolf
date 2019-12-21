using Server;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;
using System.Collections;

namespace Server.Mobiles
{
[CorpseName( "Cerberus's corpse" )]
	public class Cerberus : BaseMount
	{
		[Constructable]
		public Cerberus() : this( "Cerberus" )
		{
		}
		[Constructable]
		public Cerberus( string name ) : base( name, 277, 0x3e91, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{			
			BaseSoundID = 0xE5;
			Hue = 0x497;

			SetStr( 896, 1025 );
			SetDex( 286, 305 );
			SetInt( 286, 325 );

			SetHits( 898, 1215 );

			SetDamage( 66, 82 );

			SetDamageType( ResistanceType.Physical, 70 );
			SetDamageType( ResistanceType.Cold, 30 );			

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Fire, 55, 65 );
			SetResistance( ResistanceType.Cold, 85 );
			SetResistance( ResistanceType.Poison, 85 );
			SetResistance( ResistanceType.Energy, 65, 75 );

			SetSkill( SkillName.EvalInt, 130.4, 150.0 );
			SetSkill( SkillName.Magery, 130.9, 153.0 );
			SetSkill( SkillName.MagicResist, 135.3, 148.0 );
			SetSkill( SkillName.Tactics, 137.6, 149.3 );
			SetSkill( SkillName.Wrestling, 120.5, 152.5 );

			Fame = 14000;
			Karma = -14000;

			VirtualArmor = 75;

			Tamable = false;

			PackItem( new CerberusBone() );

			
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
		}

		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override int Meat{ get{ return 5; } }
		public override int Hides{ get{ return 10; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool BardImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }		
		public override Poison HitPoison{ get{ return Poison.Lethal; } }

		public Cerberus( Serial serial ) : base( serial )
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

			if ( BaseSoundID == 0x16A )
				BaseSoundID = 0xA8;
		}
	}
}