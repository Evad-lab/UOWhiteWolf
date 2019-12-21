using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "A Croc's Corpse" )]
	public class Crocodill : BaseCreature
	{
		[Constructable]
		public Crocodill() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "A Croc";
			Body = 0xCA;
			BaseSoundID = 660;

			SetStr( 176, 200 );
			SetDex( 76, 95 );
			SetInt( 11, 20 );

			SetHits( 146, 160 );
			SetStam( 146, 165 );
			SetMana( 0 );

			SetDamage( 15, 20 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 35, 50 );
			SetResistance( ResistanceType.Poison, 35, 50 );

			SetSkill( SkillName.MagicResist, 25.1, 40.0 );
			SetSkill( SkillName.Tactics, 40.1, 60.0 );
			SetSkill( SkillName.Wrestling, 40.1, 60.0 );

			Fame = 600;
			Karma = 600;

			VirtualArmor = 30;

			//Tamable = true;
			ControlSlots = 2;
			//MinTameSkill = 47.1;
		}

		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 12; } }
		public override HideType HideType{ get{ return HideType.Spined; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Fish; } }

		public Crocodill(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( BaseSoundID == 0x5A )
				BaseSoundID = 660;
		}
	}
}