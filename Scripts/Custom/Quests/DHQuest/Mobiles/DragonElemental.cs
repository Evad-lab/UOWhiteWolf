// Scripted by Karmageddon.
using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a dragon elemental corpse" )]
	public class DragonElemental : BaseCreature
	{
		[Constructable]
		public DragonElemental() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a dragon elemental";
			Hue = 0x846;
			Body = 14;
			BaseSoundID = 268;
			ActiveSpeed = -2;

			SetStr( 898, 1030 );
			SetDex( 568, 600 );
			SetInt( 488, 620 );

			SetHits( 4558, 5599 );

			SetDamage( 25, 30 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Fire, 100 );

			SetResistance( ResistanceType.Physical, 50, 70 );
			SetResistance( ResistanceType.Fire, 90, 100 );
			SetResistance( ResistanceType.Cold, 45, 55 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 50, 70 );

			SetSkill( SkillName.EvalInt, 100.1, 120.0 );
			SetSkill( SkillName.Magery, 100.1, 120.0 );
			SetSkill( SkillName.Meditation, 52.5, 75.0 );
			SetSkill( SkillName.MagicResist, 100.3, 130.0 );
			SetSkill( SkillName.Tactics, 100.6, 120.0 );
			SetSkill( SkillName.Wrestling, 100.6, 120.0 );
			SetSkill( SkillName.Anatomy, 97.6, 100.0 );

			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 75;
			
			PackItem( new DragonOre() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 4 );
		}

		public override bool AutoDispel{ get{ return true; } }
		public override bool BardImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }		

		public DragonElemental( Serial serial ) : base( serial )
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