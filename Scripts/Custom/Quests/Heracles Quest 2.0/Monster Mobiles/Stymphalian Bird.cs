using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a bird corpse" )]
	public class StymphalianBird : BaseCreature
	{
		[Constructable]
		public StymphalianBird() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a man-eating Stymphalian marsh bird";
			Body = 30;
			BaseSoundID = 402;

			SetStr( 196, 200 );
			SetDex( 186, 200 );
			SetInt( 151, 175 );

			SetHits( 1580, 1720 );

			SetDamage( 15, 17 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 250, 300 );
			SetResistance( ResistanceType.Fire, 100, 200 );
			SetResistance( ResistanceType.Cold, 100, 300);
			SetResistance( ResistanceType.Poison, 200, 300);
			SetResistance( ResistanceType.Energy, 100, 200 );

			SetSkill( SkillName.MagicResist, 50.1, 65.0 );
			SetSkill( SkillName.Tactics, 100.0, 120.0 );
			SetSkill( SkillName.Wrestling, 100.0, 120.0 );

			Fame = 0;
			Karma = -2500;

			VirtualArmor = 28;

			PackItem( new StymphalianFeather() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Meager, 2 );
		}

		public override int GetAttackSound()
		{
			return 916;
		}

		public override int GetAngerSound()
		{
			return 916;
		}

		public override int GetDeathSound()
		{
			return 917;
		}

		public override int GetHurtSound()
		{
			return 919;
		}

		public override int GetIdleSound()
		{
			return 918;
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override int Meat{ get{ return 4; } }
		public override MeatType MeatType{ get{ return MeatType.Bird; } }
		public override int Feathers{ get{ return 50; } }

		public StymphalianBird( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}