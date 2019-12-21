using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "the Arcadia Stag corpse" )]
	public class ArcadiaStag : BaseCreature
	{
		[Constructable]
		public ArcadiaStag() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "The Stag of Arcadia";
			
		       	Body = 0xEA;
			BaseSoundID = 0x82;

			SetStr( 120, 125 );
			SetDex( 70, 77 );
			SetInt( 130, 150 );

			SetHits( 3000, 4000 );

			SetDamage( 25, 35 );

			SetDamageType( ResistanceType.Physical, 50 );
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
			PackItem( new StagAntler() );
			PackGold( 2500, 3000 );
                 } 
		public override bool Unprovokable{ get{ return true; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 1; } 
               }

		public ArcadiaStag( Serial serial ) : base( serial )
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