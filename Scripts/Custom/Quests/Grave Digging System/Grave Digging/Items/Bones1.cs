using System;

namespace Server.Items
{
	public class bones1 : Item, IDyable
	{
		//Grave ItemIDs
		public static int[] m_BoneID = new int[]
		{
			6921, 6922, 6923, 6924, 6925, 6926, 
			6927, 6928, 6929, 6930, 6931, 6932, 
			6933, 6934, 6935, 6936, 6937, 6938, 
			6939, 6940, 6880, 6881, 6882, 6883, 
			6884
		};

		public bones1() : base( 1 )
		{
			int weight = this.ItemData.Weight;

			if ( weight >= 255 )
				weight = 1;

			ItemID = m_BoneID[Utility.Random(m_BoneID.Length)];

			this.Weight = weight;
		}

		public bones1( Serial serial ) : base( serial )
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

		public bool Dye( Mobile from, DyeTub sender )
		{
			if ( Deleted )
				return false;

			if ( ItemID >= 0x13A4 && ItemID <= 0x13AE )
			{
				Hue = sender.DyedHue;
				return true;
			}

			from.SendLocalizedMessage( sender.FailMessage );
			return false;
		}
	}
}