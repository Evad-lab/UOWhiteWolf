using System;
using Server;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class DontOfferConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "I am busy at the moment, Could you come back later?";
			}
		}

		public override bool Logged{ get{ return false; } }

		public DontOfferConversation()
		{
		}
	}

	public class DeclineConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>That old man gives you a dirty look</I><BR><BR>Fine go then, Don't help me. I remember when young folk use to respect there elders. Go go shoo i am sure someone will help me.";
			}
		}

		public override bool Logged{ get{ return false; } }

		public DeclineConversation()
		{
		}
	}

	public class AcceptConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>The old man looks very pleased</I><BR><BR>Ok great! Here is a list of what you need and where to get it. Don't forget to read the end about where to take them after you have collected them all.<BR><BR><I>The list the old man handed you.</I><BR><BR><U>Yeast</U><BR>Only known place to get this is from a farmer out in Jhelom. He don't much like strangers and even worse don't sell his wares. You will have to take it from him.<BR><BR><U>Asian Oils</U><BR>There is a man that wanders around the Yew bone yard, His name is Yoshimitsu, He does not know you so you might attack get the oils from him.<BR><BR><U>Rice Flavor Sticks</U><BR>Blood liches eat these alot, not really sure why but humans cant seem to find them in the wild your best bet is to hunt down a blood lich and get some from it. There is some in the ruins south of Trinsic<BR><BR><U>Pure Grain Alcohol</U><BR>You can find this off of Bacchus, Be careful he claims to be a god of something. He can be found around the shrine of Sacrifice.<BR><BR>Once you have got all of the above go to Britain, find Vincent Gasto, He will be somewhere inside the city.";
			}
		}

		public AcceptConversation()
		{
		}

		public override void OnRead()
		{
			System.AddObjective( new FindYeastObjective() );
		}
	}

	public class DuringCollectingConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>The old me turns around as you tap his shoulder</I><BR><BR>Hey! your back so soon, Great great! where is it??? huh? You don't have it. Bah your worthless go get me what i ask for!";
			}
		}

		public override bool Logged{ get{ return false; } }

		public DuringCollectingConversation()
		{
		}
	}

	public class DuringBrewingConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>You notice the old man shacking while he speaks</I><BR><BR>Hello again! Did you get it? No? You have collected what you need go take it to Vincent... What are you waiting for?";
			}
		}

		public override bool Logged{ get{ return false; } }

		public DuringBrewingConversation()
		{
		}
	}

	public class DuringSearchConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>Vincent breaks away from his work to speak with you.</I><BR><BR>Hi there, Did you find her? No? *sigh* well please keep looking. I should have the brew done soon.";
			}
		}

		public override bool Logged{ get{ return false; } }

		public DuringSearchConversation()
		{
		}
	}

	public class VincentConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>Vincent greets you with a warm smile.</I><BR><BR>Hello my friend what can i help you with today? Hmm, I see, Medicine!<BR><BR><I>Vincent rolls on the floor laughing uncontrollably</I><BR><BR>He told you that line of garbage. I am not healer. I brew alcoholic drinks. The man who sent you one this trek around the global is a drunk, Hes not dying, Hes just broke and to lazy to go out and get the stuff i need to make his (Medicine). Aye broke he didn't tell you my fee? Look my friend if you have the stuff to make the brew its only 10k but if you do not its 100k per bottle. Oh i see you have the stuff i need well then 10k it is... You don't have 10k? Ok look i have a favor to ask you myself. My little girl just turned 18 a few days ago and more and more she is running off with this boy who hangs out in bucs den, That is not place for my litte girl. She told me today she was going to her friends house in Yew but i would bet my last gold piece shes in bucs with that thug find her and ill make it for free.";
			}
		}

		public VincentConversation()
		{
		}

		public override void OnRead()
		{
			System.AddObjective( new VincentsLittleGirlObjective() );
		}
	}

	public class VincentSecondConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>Vincent welcomes you back and ask you about what you have found out</I><BR><BR>She was?!? I knew it. They attacked you? Glad to see you made it out alive. Well lets see what she has to say when she gets home. Thank you my friend for helping a concerned father, and as promised here is the brew that drunk wants. Return it to him he will hold true one his end of the bargain. Stop back by anytime friend.";
			}
		}

		public VincentSecondConversation()
		{
		}

		public override void OnRead()
		{
			System.AddObjective( new ReturnToDrunkObjective() );
		}
	}

	public class EndConversation : QuestConversation
	{
		public override object Message
		{
			get
			{
				return "<I>The old man grabs the bottle from out your hands and starts to drink</I><BR><BR>Mmmm that hit the spot. What? So i lied to you. So what! You would not have went after it if i told you the truth... So how did you pay for it? Bah never mind that who cares you got it that is all i am happy about.<BR><BR><I>The old man drinks some more</I><BR><BR>Payment? ah yes since you held true to your word even after knowing i lied here is your reward. Just be warned that you can find riches with this shovel or your death. The more about mining you know the better you will know where to find the good stuff.<BR><BR><I>The old man hands you a bag and the shovel</I><BR><BR>There you god lad, now run along come back any time... Sooner the better.";
			}
		}

		public EndConversation()
		{
		}

		public override void OnRead()
		{
			System.Complete();
		}
	}

	public class FullEndConversation : QuestConversation
	{
		private bool m_Logged;

		public override object Message
		{
			get
			{
				return "<I>The old man looks at your backpack</I><BR><BR>Where is it? How could you find anything in that mess. Go clean out your backpack and bring me back my drink.. err Medicine.";
			}
		}

		public override bool Logged{ get{ return m_Logged; } }

		public FullEndConversation( bool logged )
		{
			m_Logged = logged;
		}

		public FullEndConversation()
		{
			m_Logged = true;
		}

		public override void OnRead()
		{
			if ( m_Logged )
				System.AddObjective( new MakeRoomObjective() );
		}
	}
}