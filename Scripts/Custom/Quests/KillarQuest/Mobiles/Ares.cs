using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Ares corpse" )]
	public class Ares : BaseCreature
	{
		[Constructable]
		public Ares () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = " Ares ";
			Body = 76;
			BaseSoundID = 362;
			Hue = 1153;

			SetStr( 500, 700 );
			SetDex( 300, 300 );
			SetInt( 500, 700 );

			SetHits( 2500, 3000 );

			SetDamage( 50, 60 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 25 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 65, 80 );
			SetResistance( ResistanceType.Fire, 45, 60 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 95.1, 150.0 );
			SetSkill( SkillName.EvalInt, 90.1, 120.0 );
			SetSkill( SkillName.Magery, 95.5, 100.0 );
			SetSkill( SkillName.Meditation, 125.1, 150.0 );
			SetSkill( SkillName.MagicResist, 90.5, 100.0 );
			SetSkill( SkillName.Tactics, 190.1, 200.0 );
			SetSkill( SkillName.Wrestling, 110.1, 130.0 );

			Fame = 24000;
			Karma = -24000;

			VirtualArmor = 60;

			PackItem( new Longsword() );
			PackGold( 1000, 2000 );
			//PackScroll( 2, 8 );
			//PackArmor( 2, 5 );
			//PackWeapon( 3, 5 );
			//PackWeapon( 5, 5 );
			//PackSlayer();
			PackItem( new HeadOfAres() );
			//PackItem( new Tokens( 1000, 1200 ) );
			
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 1; } }

		public Ares( Serial serial ) : base( serial )
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

