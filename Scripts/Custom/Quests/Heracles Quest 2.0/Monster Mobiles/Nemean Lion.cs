using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "the Nemeanlion corpse" )]
	public class Nemeanlion : BaseCreature
	{
		[Constructable]
		public Nemeanlion() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "The Nemean Lion";
			
		       	Body = 788;
			BaseSoundID = 1149;
			Hue= 0x487;

			SetStr( 8000 );
			SetDex( 510, 750 );
			SetInt( 310, 400 );

			SetHits( 5000);

			SetDamage( 34, 36 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 45 );
			SetResistance( ResistanceType.Cold, 45 );
			SetResistance( ResistanceType.Poison, 45 );
			SetResistance( ResistanceType.Energy, 45 );

			SetSkill( SkillName.EvalInt, 150.0 );
			SetSkill( SkillName.Magery, 150.0 );
			SetSkill( SkillName.Meditation, 150.0 );
			SetSkill( SkillName.MagicResist, 150.0 );
			SetSkill( SkillName.Tactics, 150.0 );
			SetSkill( SkillName.Wrestling, 150.0 );


			Fame = 0;
			Karma = -20000;

			VirtualArmor = 64;
		 
			PackGem(3);
			PackItem( new NemeanSkin() );
			PackItem( new NemeanTooth() );
			PackGold( 4500, 7000 );
                 } 
		public override bool Unprovokable{ get{ return true; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 1; } 
               }

		public Nemeanlion( Serial serial ) : base( serial )
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