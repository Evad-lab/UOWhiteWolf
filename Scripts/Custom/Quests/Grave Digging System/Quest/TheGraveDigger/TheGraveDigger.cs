using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class TheGraveDiggerQuest : QuestSystem
	{
		private static Type[] m_TypeReferenceTable = new Type[]
			{
				typeof( TheGraveDigger.DontOfferConversation ),
				typeof( TheGraveDigger.DeclineConversation ),
				typeof( TheGraveDigger.AcceptConversation ),
				typeof( TheGraveDigger.DuringCollectingConversation ),
				typeof( TheGraveDigger.DuringBrewingConversation ),
				typeof( TheGraveDigger.DuringSearchConversation ),
				typeof( TheGraveDigger.VincentConversation ),
				typeof( TheGraveDigger.VincentSecondConversation ),
				typeof( TheGraveDigger.EndConversation ),
				typeof( TheGraveDigger.FullEndConversation ),
				typeof( TheGraveDigger.FindYeastObjective ),
				typeof( TheGraveDigger.FindAsianOilObjective ),
				typeof( TheGraveDigger.FindRiceFlavorSticksObjective ),
				typeof( TheGraveDigger.FindPureGrainAlcoholObjective ),
				typeof( TheGraveDigger.FindVincentObjective ),
				typeof( TheGraveDigger.VincentsLittleGirlObjective ),
				typeof( TheGraveDigger.ReturnToVincentObjective ),
				typeof( TheGraveDigger.ReturnToDrunkObjective ),
				typeof( TheGraveDigger.MakeRoomObjective )
			};

		public override Type[] TypeReferenceTable{ get{ return m_TypeReferenceTable; } }

		public override object Name
		{
			get
			{
				return "A Dying Wish";
			}
		}

		public override object OfferMessage
		{
			get
			{
				return "<U>The tired looking man starts to speak.</U><BR><BR>Could you help a dying old man? I need the proper ingredients for my medicine and have them taken to a man named Vincent in Britain. I would go myself but i am to tired and weak to go it alone. If you do this favor for me i can reward you with a very profitable tool, A grave diggers shovel. You know how to mine don't you? Well that is not important.<BR><BR>Yes grave digging can be very profitable you would not be able to dream of the riches you can gather in your local grave yard, No no its not wrong... well as long as no one sees you that is.<BR><BR><I>That old man smiles at you</I><BR><BR>Well my child with you grant me this dying wish?";
			}
		}

		public override TimeSpan RestartDelay{ get{ return TimeSpan.FromMinutes( 30.0 ); } }
		public override bool IsTutorial{ get{ return false; } }

		public override int Picture{ get{ return 0x15A9; } }

		public TheGraveDiggerQuest( PlayerMobile from ) : base( from )
		{
		}

		// Serialization
		public TheGraveDiggerQuest()
		{
		}

		public override void Accept()
		{
			base.Accept();

			AddConversation( new AcceptConversation() );
		}

		public override void Decline()
		{
			base.Decline();

			AddConversation( new DeclineConversation() );
		}
	}
}