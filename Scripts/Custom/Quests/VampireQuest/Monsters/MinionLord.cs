//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a Minion's Lord corpse" )]
	public class MinionLord : BaseCreature
	{
		[Constructable]
		public MinionLord() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Title = " of the walking dead";
			Name = "Minion Lord";
			Body = Utility.RandomList( 50, 56 );
			BaseSoundID = 0x48D;
			Hue = 39;

			SetStr( 600, 750 );
			SetDex( 56, 75 );
			SetInt( 16, 40 );

			SetHits( 500, 550 );

			SetDamage( 15, 18 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 30, 40 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 35 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.MagicResist, 75.1, 90.0 );
			SetSkill( SkillName.Tactics, 75.1, 90.0 );
			SetSkill( SkillName.Wrestling, 75.1, 90.0 );

			Fame = 450;
			Karma = -450;

			VirtualArmor = 16;
			 
			
			switch ( Utility.Random( 15 ))
			{	
				case 0: PackItem( new MinionLordsAxe() ); break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 );
		}

		public override Poison PoisonImmune{ get{ return Poison.Lesser; } }

		public MinionLord( Serial serial ) : base( serial )
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
