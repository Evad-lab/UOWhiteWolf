using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a slimey corpse" )]
	public class MMQFungusEatingSlime : BaseCreature
	{
		[Constructable]
		public MMQFungusEatingSlime() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Fungus Eating Slime";
			Body = 775;
			BaseSoundID = 456;

			Hue = Utility.RandomSlimeHue();

			SetStr( 500 );
			SetDex( 500 );
			SetInt( 500 );

			SetHits( 4500 );

			SetDamage( 30, 40 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Poison, 50 );

			SetResistance( ResistanceType.Physical, 50 );
			SetResistance( ResistanceType.Fire, 50 );
			SetResistance( ResistanceType.Cold, 50 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 50 );

			SetSkill( SkillName.EvalInt, 100.0 );
			SetSkill( SkillName.Magery, 100.0 );
			SetSkill( SkillName.Poisoning, 100.0 );
			SetSkill( SkillName.Wrestling, 100.0 );

			Fame = 1;
			Karma = -1;

			VirtualArmor = 70;

			PackItem( new MMQSpores() );
			//PackSlayer();

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss );
		}

		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override Poison HitPoison{ get{ return Poison.Deadly; } }

		public MMQFungusEatingSlime( Serial serial ) : base( serial )
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
