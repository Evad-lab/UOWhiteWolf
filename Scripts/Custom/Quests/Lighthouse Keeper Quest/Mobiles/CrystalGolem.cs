using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a crystal golem corpse" )]
	public class CrystalGolem : BaseCreature
	{
		[Constructable]
		public CrystalGolem() : base( AIType.AI_Melee, FightMode.Closest, 10, 5, 2, 1.5 )
		{		
			Name = "A Crystal Golem";
			Body = 752;
			BaseSoundID = 541;
			Hue = 1153;

			SetStr( 500 );
			SetDex( 250 );
			SetInt( 500 );

			SetHits( 2500 );

			SetDamage( 1, 50 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 50 );
			SetResistance( ResistanceType.Fire, 50 );
			SetResistance( ResistanceType.Cold, 50 );
			SetResistance( ResistanceType.Energy, 50 );
			SetResistance( ResistanceType.Poison, 50 );

			SetSkill( SkillName.Anatomy, 100.0 );
			SetSkill( SkillName.Focus, 100.0 );
			SetSkill( SkillName.MagicResist, 100.0 );
			SetSkill( SkillName.Tactics, 100.0 );
			SetSkill( SkillName.Wrestling, 100.0 );

			Fame = 1;
			Karma = 1;

			VirtualArmor = 50;

			PackItem( new LightEnhancingCrystal() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.FilthyRich );
		}

		public CrystalGolem( Serial serial ) : base( serial )
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