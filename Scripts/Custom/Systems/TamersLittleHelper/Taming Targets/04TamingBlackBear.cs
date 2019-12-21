//Based on three scripts from RunUO Distro 1.0  Thanks RunUO!!!!
//Created by Ashlar, beloved of Morrigan
using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a TamingBlackBear corpse" )]
	public class TamingBlackBear : BaseCreature
	{
		[Constructable]
		public TamingBlackBear() : base( AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "a Taming Black Bear";
			Body = 211;
			BaseSoundID = 0xA3;

			SetStr( 35 );
			SetDex( 35 );
			SetInt( 35 );

			SetHits( 35 );
			SetMana( 0 );

			SetDamage( 0 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 1, 5 );

			SetSkill( SkillName.MagicResist, 35.0 );
			SetSkill( SkillName.Tactics, 35.0 );
			SetSkill( SkillName.Wrestling, 35.0 );

			Fame = 150;
			Karma = 0;

			VirtualArmor = 2;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = 35.1;
			CantWalk = true;			
		}

		public override int Meat{ get{ return 1; } }
		public override MeatType MeatType{ get{ return MeatType.Bird; } }
		public override FoodType FavoriteFood{ get{ return FoodType.GrainsAndHay; } }


		public override void OnDoubleClick( Mobile from )
		{
			Delete();
		}

		public override bool CanBeDamaged()
		{
			return false;
		}

		public bool HandlesOnMovement{ get{ return true; } }

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if ( InRange( m.Location, 8 ) && !InRange( oldLocation, 7 ) )
			{
				Delete();
			}

			base.OnMovement( m, oldLocation );
		}

		public TamingBlackBear(Serial serial) : base(serial)
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



