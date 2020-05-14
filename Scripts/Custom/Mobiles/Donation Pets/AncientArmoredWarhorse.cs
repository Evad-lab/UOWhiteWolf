using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a corpse an ancient armored warhorse" )]
	[TypeAlias( "Server.Mobiles.BrownHorse", "Server.Mobiles.DirtyHorse", "Server.Mobiles.GrayHorse", "Server.Mobiles.TanHorse" )]
	public class AncientArmoredWarhorse : BaseMount
	{
		private static int[] m_IDs = new int[]
			{
				0x11C, 0x2D9C
			};

		[Constructable]
		public AncientArmoredWarhorse() : this( "a Ancient Armored Warhorse" )
		{
		}

		[Constructable]
		public AncientArmoredWarhorse( string name ) : base( name, 0x11C, 16018, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			int random = Utility.Random( 4 );
			BaseSoundID = 0xA8;
			Hue = 1857;
			BodyValue = 0x11C;

			SetStr( 589, 640 );
            SetDex( 603, 712 );
			SetInt( 670, 700 );								   
            SetHits( 1200 );                                   
            SetDamage( 35 );                                  
            SetDamageType( ResistanceType.Physical, 50 );
            SetDamageType( ResistanceType.Cold, 50 );
            SetDamageType( ResistanceType.Fire, 50 );
            SetDamageType( ResistanceType.Energy, 50 );
            SetDamageType( ResistanceType.Poison, 50 );

            SetResistance( ResistanceType.Physical, 70 );
            SetResistance( ResistanceType.Cold, 80 );
            SetResistance( ResistanceType.Fire, 80 );
            SetResistance( ResistanceType.Energy, 80 );
            SetResistance( ResistanceType.Poison, 80 );

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
			MinTameSkill = 120.0;
		}


		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );			
		}

		public override int Meat{ get{ return 3; } }
		public override int Hides{ get{ return 10; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public AncientArmoredWarhorse( Serial serial ) : base( serial )
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