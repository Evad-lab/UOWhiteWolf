
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class BookOfTheDammed : RedBook
	{
		[Constructable]
		public BookOfTheDammed() : base( "Greetings", "Lost Sinner", 24, false )
		{
			Hue = 0x89B;
			Weight = 1.0;
			Name = "Book of the Dammed";
			Hue = 1;

			
			Pages[0].Lines = new string[]
				{
					"  Greetings to you,",
					"Slayer of the Vampi",
					"res seeker of the .",
					"Abyss",
					" because you have",
					"been deemed worthy",
					"you have the honor",
					"of seeking out the"
				};

			Pages[1].Lines = new string[]
				{
					"most dreaded and vile.",
					"Vampire.. Dracula",
					"betrayer of mankind, I",
					"pray you are ready for",
					"this challenge. His",
					"resting place is in",
					"the Crystal Fens Cave",
					"south of Luna"
				};

			Pages[2].Lines = new string[]
				{
					"Click on the Keys ",
					"to open a gate.",
					"    Safe journey ",
					"brave warrior",
					
				};
		}

		public BookOfTheDammed( Serial serial ) : base( serial )
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