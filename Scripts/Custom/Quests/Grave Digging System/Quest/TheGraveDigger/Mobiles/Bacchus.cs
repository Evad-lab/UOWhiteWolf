using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Mobiles;
using Server.Engines.Quests;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class Bacchus : BaseCreature
	{
		public override bool ClickTitle{ get{ return false; } }

		[Constructable]
		public Bacchus() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Hue = 1150;
			Female = false;
			BodyValue = 123;
			BaseSoundID = 1001;
			Title = "the god of wine";
			Name = "Bacchus";

			SetStr( 350 );
			SetDex( 100 );
			SetInt( 300 );

			SetHits( 2000 );
			SetMana( 3000 );

			SetDamage( 10, 23 );

			SetSkill( SkillName.MagicResist, 90.0, 97.5 );
			SetSkill( SkillName.Tactics, 90.0, 97.5 );
			SetSkill( SkillName.Wrestling, 90.0, 97.5 );
			SetSkill( SkillName.Magery, 95.0, 115.5 );
			SetSkill( SkillName.EvalInt, 95.0, 115.5 );

			Fame = 5000;
			Karma = -5000;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich );
		}

		public Bacchus( Serial serial ) : base( serial )
		{
		}

		public void CheckQuest()
		{
			List<DamageStore> rights = GetLootingRights( );
			ArrayList mobile = new ArrayList();

			for ( int i = rights.Count - 1; i >= 0; --i )
			{
				DamageStore ds = (DamageStore)rights[i];

				if ( ds.m_HasRight )
				{
					if ( ds.m_Mobile is PlayerMobile )
					{
						PlayerMobile pm = (PlayerMobile)ds.m_Mobile;
						QuestSystem qs = pm.Quest;
						if ( qs is TheGraveDiggerQuest )
						{
							mobile.Add( ds.m_Mobile );
						}
					}
				}
			}

			for ( int i = 0; i < mobile.Count; ++i )
			{
				PlayerMobile pm = (PlayerMobile)mobile[i % mobile.Count];
				QuestSystem qs = pm.Quest;

				QuestObjective obj = qs.FindObjective( typeof( FindPureGrainAlcoholObjective ) );

				if ( obj != null && !obj.Completed )
				{
					Item pure = new PureGrainAlcohol();

					if ( !pm.PlaceInBackpack( pure ) )
					{
						pure.Delete();
						pm.SendLocalizedMessage( 1046260 ); // You need to clear some space in your inventory to continue with the quest.  Come back here when you have more space in your inventory.
					}
					else
					{
						obj.Complete();
						pm.SendMessage( "You loot the alcohol off the gods corpse." );
					}
				}
			}	
		}

		public override bool OnBeforeDeath()
		{
			CheckQuest();
			return base.OnBeforeDeath();
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
