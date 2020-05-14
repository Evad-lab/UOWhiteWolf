using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a corpse of a T-Rex" )]
	public class Tyrannosaurus: BaseCreature
	{

		[Constructable]
		public Tyrannosaurus() : this( "T-Rex" )
		{
		}

		[Constructable]
		public Tyrannosaurus( string name ) : base( AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{

			Name = "T-Rex";
			BodyValue = 1400;
			BaseSoundID = 0;

			SetStr( 900 );
                                               SetDex( 500, 600 );
                                               SetInt( 400, 500 );
                                               SetHits( 3000, 4000 );
                                               SetDamage( 34 );
                                               SetDamageType( ResistanceType.Physical, 100 );
                                               SetDamageType( ResistanceType.Cold, 66 );
                                               SetDamageType( ResistanceType.Fire, 66 );
                                               SetDamageType( ResistanceType.Energy, 66 );
                                               SetDamageType( ResistanceType.Poison, 66 );

                                               SetResistance( ResistanceType.Physical, 65 );
                                               SetResistance( ResistanceType.Cold, 65 );
                                               SetResistance( ResistanceType.Fire, 65 );
                                               SetResistance( ResistanceType.Energy, 65 );
                                               SetResistance( ResistanceType.Poison, 65 );


						SetSkill( SkillName.EvalInt, 150.4, 200.0 );
						SetSkill( SkillName.Magery, 130.4, 150.0 );
						SetSkill( SkillName.MagicResist, 135.3, 150.0 );
						SetSkill( SkillName.Tactics, 137.6, 158.0 );
						SetSkill( SkillName.Wrestling, 130.5, 152.5 );

                                               Fame = 1200;
                                               Karma = 1200;
                                               VirtualArmor = 60;
     
			Tamable = true;
			ControlSlots = 6;
			ControlSlotsMin= 6;
			ControlSlotsMax= 6;
			MinTameSkill = 120.0;
		}


		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );			
		}

		public override int Meat{ get{ return 3; } }
		public override int Hides{ get{ return 10; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public Tyrannosaurus( Serial serial ) : base( serial )
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