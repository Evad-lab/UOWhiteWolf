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
	public class LordYoshimitsu : BaseCreature
	{
		public override bool AlwaysAttackable{ get{ return true; } }

		public override bool ClickTitle{ get{ return false; } }

		[Constructable]
		public LordYoshimitsu() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the ninja";
			Hue = Utility.RandomSkinHue();
			Female = false;
			BodyValue = 400;
			Name = "Yoshimitsu";

			SetStr( 350 );
			SetDex( 100 );
			SetInt( 50 );

			SetHits( 2000 );

			SetDamage( 10, 23 );

			SetSkill( SkillName.Fencing, 66.0, 97.5 );
			SetSkill( SkillName.Macing, 65.0, 87.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Swords, 65.0, 87.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 15.0, 37.5 );

			LeatherNinjaHood nh = new LeatherNinjaHood();
			nh.Hue = 1175;
			AddItem( nh );

			LeatherNinjaMitts nm = new LeatherNinjaMitts();
			nm.Hue = 1175;
			AddItem( nm );

			LeatherNinjaJacket nj = new LeatherNinjaJacket();
			nj.Hue = 1175;
			AddItem( nj );

			LeatherNinjaPants np = new LeatherNinjaPants();
			np.Hue = 1175;
			AddItem( np );

			NinjaTabi nt = new NinjaTabi();
			nt.Hue = 1175;
			AddItem( nt );

			Daisho d = new Daisho();
			AddItem( d );

			Fame = 5000;
			Karma = -5000;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich );
		}

		public LordYoshimitsu( Serial serial ) : base( serial )
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

				QuestObjective obj = qs.FindObjective( typeof( FindAsianOilObjective ) );

				if ( obj != null && !obj.Completed )
				{
					Item oil = new AsianOil();

					if ( !pm.PlaceInBackpack( oil ) )
					{
						oil.Delete();
						pm.SendLocalizedMessage( 1046260 ); // You need to clear some space in your inventory to continue with the quest.  Come back here when you have more space in your inventory.
					}
					else
					{
						obj.Complete();
						pm.SendMessage( "You loot the oils off the ninja's corpse." );
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
