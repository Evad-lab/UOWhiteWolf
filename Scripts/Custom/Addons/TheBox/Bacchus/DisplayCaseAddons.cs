/// Made By: ThatGuyBehindYou ///
/// DO NOT REMOVE OR   ///
/// MODIFY THIS HEADER ///

using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DisplayCaseSouth : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new DisplayCaseSouthDeed(); } }

		[Constructable]
		public DisplayCaseSouth()
		{
                AddComponent(new AddonComponent(0xb02), 0, 0, 0);
                AddComponent(new AddonComponent(0xb01), 1, 0, 0);
                AddComponent(new AddonComponent(0xb00), 2, 0, 0);
                AddComponent(new AddonComponent(0xaff), 0, 0, 2);
                AddComponent(new AddonComponent(0xafe), 1, 0, 2);
                AddComponent(new AddonComponent(0xafd), 2, 0, 2);
                }

                public DisplayCaseSouth(Serial serial) : base(serial)
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

	public class DisplayCaseSouthDeed : BaseAddonDeed
	{
        public override BaseAddon Addon { get { return new DisplayCaseSouth(); } }
		
		[Constructable]
		public DisplayCaseSouthDeed()
		{
		}

                public DisplayCaseSouthDeed(Serial serial) : base(serial)
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

//////////////////////////////////////////////////////////////////////////////////////////////////

	public class DisplayCaseEast : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new DisplayCaseEastDeed(); } }

		[Constructable]
		public DisplayCaseEast()
		{
                AddComponent(new AddonComponent(0xb08), 0, 0, 0);
                AddComponent(new AddonComponent(0xb07), 0, 1, 0);
                AddComponent(new AddonComponent(0xb06), 0, 2, 0);
                AddComponent(new AddonComponent(0xb05), 0, 0, 2);
                AddComponent(new AddonComponent(0xb04), 0, 1, 2);
                AddComponent(new AddonComponent(0xb03), 0, 2, 2);
                }

                public DisplayCaseEast(Serial serial) : base(serial)
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

	public class DisplayCaseEastDeed : BaseAddonDeed
	{
        public override BaseAddon Addon { get { return new DisplayCaseEast(); } }
		
		[Constructable]
		public DisplayCaseEastDeed()
		{
		}

                public DisplayCaseEastDeed(Serial serial) : base(serial)
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
