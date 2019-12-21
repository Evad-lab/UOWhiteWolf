using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Deku's corpse" )]
	public class Deku : BaseCreature
	{
		[Constructable]
		public Deku() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Deku";
			Body = 271;
			BaseSoundID = 451;

			SetStr( 416, 505 );
			SetDex( 1246, 1365 );
			SetInt( 1566, 1655 );

			SetHits( 3550, 5603 );

			SetDamage( 25, 40 );
			
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Physical, 40 );

			SetResistance( ResistanceType.Physical, 70, 80 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 50, 60 );

			SetSkill( SkillName.Musicianship, 120.1, 130.0 );
			SetSkill( SkillName.Peacemaking, 120.1, 130.0 );
			SetSkill( SkillName.Discordance, 150.5, 200.0 );
			SetSkill( SkillName.EvalInt, 120.1, 130.0 );
			SetSkill( SkillName.Magery, 120.1, 130.0 );
			SetSkill( SkillName.MagicResist, 150.5, 200.0 );
			SetSkill( SkillName.Tactics, 100.1, 120.0 );
			SetSkill( SkillName.Wrestling, 110.1, 140.0 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 50;

			PackItem( new DekuShield() );
			PackNecroReg( 50, 80 );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

                public override bool DrainsLife { get { return true; } }
                public override bool AutoDispel{ get{ return true; } }
	        public override bool BardImmune{ get{ return true; } }
                public override bool AlwaysMurderer { get { return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 4; } }

		public Deku( Serial serial ) : base( serial )
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