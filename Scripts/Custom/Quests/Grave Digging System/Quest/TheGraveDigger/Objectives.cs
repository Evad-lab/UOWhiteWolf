using System;
using Server;
using Server.Mobiles;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class FindYeastObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "<U>Yeast</U> Only known place to get this is from a farmer out in Jhelom. He dont much like strangers and even worse dont sell his wares. You will have to take it from him.";
			}
		}

		public FindYeastObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddObjective( new FindAsianOilObjective() );
		}
	}

	public class FindAsianOilObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "<U>Asian Oils</U> There is a man that wanders around the Yew bone yard, His name is Yoshimitsu, He does not know you so you might attack get the oils from him.";
			}
		}

		public FindAsianOilObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddObjective( new FindRiceFlavorSticksObjective() );
		}
	}

	public class FindRiceFlavorSticksObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "<U>Rice Flavor Sticks</U> Blood liches eat these alot, not really sure why but humans cant seem to find them in the wild your best bet is to hunt down a blood lich and get some from it. There is some in the ruins south of Trinsic";
			}
		}

		public FindRiceFlavorSticksObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddObjective( new FindPureGrainAlcoholObjective() );
		}
	}

	public class FindPureGrainAlcoholObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "<U>Pure Grain Alcohol</U> You can find this off of Bacchus, Be careful he claims to be a god of something. He can be found around the shrine of Sacrifice.";
			}
		}

		public FindPureGrainAlcoholObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddObjective( new FindVincentObjective() );
		}
	}

	public class FindVincentObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "<I>You check your list</I><BR>Once you have got all of the above go to Britain, find Vincent Gasto, He will be somewhere inside the city.";
			}
		}

		public FindVincentObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddConversation( new VincentConversation() );
		}
	}

	public class VincentsLittleGirlObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "Goto Buccaneers Den and search for Vincents little girl Linda.";
			}
		}

		public VincentsLittleGirlObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddObjective( new ReturnToVincentObjective() );
		}
	}

	public class ReturnToVincentObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "You found her. Now return to Vincent and tell him where she was.";
			}
		}

		public ReturnToVincentObjective()
		{
		}

		public override void OnComplete()
		{
			System.AddConversation( new VincentSecondConversation() );
		}
	}

	public class ReturnToDrunkObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "Return to the old man, and give him his brew to collect your reward.";
			}
		}

		public ReturnToDrunkObjective()
		{
		}
	}

	public class MakeRoomObjective : QuestObjective
	{
		public override object Message
		{
			get
			{
				return "Your backpack is to full to carry any more items. Please clean it out before you return here to collect your reward.";
			}
		}

		public MakeRoomObjective()
		{
		}
	}
}