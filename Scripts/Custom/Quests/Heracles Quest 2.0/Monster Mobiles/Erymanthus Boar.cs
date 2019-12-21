using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "the Mt. Erymanthus Boar corpse" )]
	public class ErymanthusBoar : BaseCreature
	{
		[Constructable]
		public ErymanthusBoar() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "The Boar of Mt. Erymanthus";
			
		       	Body = 0x122;
			BaseSoundID = 0xC4;

			SetStr( 250 );
			SetDex( 150 );
			SetInt( 50 );

			SetHits( 3500 );

			SetDamage( 30, 60 );

			SetDamageType( ResistanceType.Physical, 100 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 45 );
			SetResistance( ResistanceType.Cold, 45 );
			SetResistance( ResistanceType.Poison, 45 );
			SetResistance( ResistanceType.Energy, 45 );

			SetSkill( SkillName.MagicResist, 100.0, 120.0 );
			SetSkill( SkillName.Tactics, 100.0, 120.0 );
			SetSkill( SkillName.Wrestling, 100.0, 120.0 );


			Fame = 0;
			Karma = -20000;

			VirtualArmor = 35;
		 
			PackGem();
			PackItem( new ErymanthusHam() );
			PackGold( 2500, 3000 );
                 } 
		public override bool Unprovokable{ get{ return true; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 1; } 
               }

		public ErymanthusBoar( Serial serial ) : base( serial )
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