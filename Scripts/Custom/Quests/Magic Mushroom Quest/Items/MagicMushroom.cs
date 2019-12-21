using System;

namespace Server.Items
{
	public abstract class BaseMagicMushroom : Item
	{

		public virtual int Bonus{ get{ return 0; } }
		public virtual StatType Type{ get{ return StatType.All; } }

		public BaseMagicMushroom( int hue ) : base( 0x26B7 )
		{
			Weight = 1.0;
			Hue = hue;
		}

		public BaseMagicMushroom( Serial serial ) : base( serial )
		{
		}

		public virtual bool Apply( Mobile from )
		{
			bool applied = Spells.SpellHelper.AddStatOffset( from, Type, Bonus, TimeSpan.FromMinutes( 15.0 ) );

			if ( !applied )
				from.SendLocalizedMessage( 502173 ); // You are already under a similar effect.

			return applied;
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else if ( Apply( from ) )
			{
				from.FixedEffect( 0x375A, 10, 15 );
				from.PlaySound( 0x1E7 );
				from.SendMessage( "After eating the Magic Mushroom, you feel an intensity run throughout your body." );
				Delete();
			}
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}

	public class MagicMushroom : BaseMagicMushroom
	{
		public override int Bonus{ get{ return 15; } }
		public override StatType Type{ get{ return StatType.All; } }

		[Constructable]
		public MagicMushroom() : base( 1159 )
		{
			Name = "Magic Mushroom";
		}

		public MagicMushroom( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}

}