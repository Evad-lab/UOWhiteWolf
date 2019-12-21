///This book was exported to c# file using daat99's copybook script.
///Thanx a lot for jjarmis for his HUGE support on writing this script.
using System;
using Server;
namespace Server.Items
{
	public class DHQuestBook: BaseBook
	{
		[Constructable]
		public DHQuestBook() : base( 4030, 20, true)
		{

			Title = "Dragon Heart Quest";
			Author = "Dragon Smith";
			LootType = LootType.Blessed;
			int cnt = 0;
			string[] lines;
			lines = new string[] //page 0
			{
				"Now that you have ",
				"accepted my bargain, ",
				"there are two parts that ",
				"you need to get. One is ",
				"the Dragon Ore and the ",
				"other is the Dragon ",
				"Heart. To get the Dragon ",
				"Ore you must search ",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 1
			{
				"for the earth elemental ",
				"that has the scroll to ",
				"summon the Dragon ",
				"Elemental. Once you have ",
				"the scroll you can ",
				"summon the Dragon ",
				"Elemental at the crystal ",
				"found in Despise. ",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 2
			{
				"Then to get the Dragon ",
				"Heart you must get the ",
				"scroll to summon the ",
				"keeper of the heart. To ",
				"do this you must find ",
				"the dragon that holds the ",
				"scroll. Once you have the ",
				"scroll you must Summon ",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 3
			{
				"the Keeper of the Heart ",
				"at the Summoning Ball ",
				"found in Fire Dungeon. ",
				"Once you have both of ",
				"the items you then can ",
				"give them to me for a ",
				"piece of my specially ",
				"crafted armor.",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 4
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 5
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 6
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 7
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 8
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 9
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 10
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 11
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 12
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 13
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 14
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 15
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 16
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 17
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 18
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
			lines = new string[] //page 19
			{
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
			};
			Pages[cnt++].Lines = lines;
		}
		public DHQuestBook( Serial serial ) : base( serial )
		{
		}
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int)0 ); // version
		}
	}
}
