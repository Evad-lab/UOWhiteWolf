using System;
using Server.Mobiles;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a geryon cow corpse" )]
	public class GeryonCow : BaseCreature
	{
		[Constructable]
		public GeryonCow() : base( AIType.AI_Animal, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Geryon's Cow";
			Body = Utility.RandomList( 0xD8, 0xE7 );
			Hue = 0x26;
			BaseSoundID = 0x78;

			SetStr( 300 );
			SetDex( 150 );
			SetInt( 50 );

			SetHits( 180 );
			SetMana( 0 );

			SetDamage( 10, 40 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 150 );

			SetSkill( SkillName.MagicResist, 50.5 );
			SetSkill( SkillName.Tactics, 50.5 );
			SetSkill( SkillName.Wrestling, 50.5 );

			Fame = 5000;
			Karma = -5000;

			VirtualArmor = 10;

			Tamable = false;

			PackItem( new GeryonCowHide() );
		}

		public override int Meat{ get{ return 8; } }
		public override int Hides{ get{ return 12; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public GeryonCow(Serial serial) : base(serial)
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
		}
	}
}
