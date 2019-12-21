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
	public class YeastFarmer : BaseCreature
	{
		public override bool AlwaysAttackable{ get{ return true; } }

		private DateTime m_NextCall;
		private Mobile m_LastQuester;

		public override bool ClickTitle{ get{ return false; } }

		[Constructable]
		public YeastFarmer() : base( AIType.AI_Animal, FightMode.None, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the farmer";
			Hue = Utility.RandomSkinHue();
			Female = false;
			BodyValue = 400;
			Name = "Hayden Failstorm";

			SetStr( 200 );
			SetDex( 100 );
			SetInt( 100 );

			SetHits( 1000 );

			SetDamage( 10, 23 );

			SetSkill( SkillName.Fencing, 66.0, 97.5 );
			SetSkill( SkillName.Macing, 65.0, 87.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Swords, 65.0, 87.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );
			SetSkill( SkillName.Wrestling, 15.0, 37.5 );

			Fame = 1000;
			Karma = -1000;

			AddItem( new Boots( Utility.RandomNeutralHue() ) );
			AddItem( new FancyShirt( Utility.RandomNeutralHue() ) );
			AddItem( new LongPants( Utility.RandomNeutralHue() ) );
			AddItem( new Pitchfork() );

			//AddItem( Server.Items.Hair.GetRandomHair( Female ) );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}

		public YeastFarmer( Serial serial ) : base( serial )
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

				QuestObjective obj = qs.FindObjective( typeof( FindYeastObjective ) );

				if ( obj != null && !obj.Completed )
				{
					Item yeast = new Yeast();

					if ( !pm.PlaceInBackpack( yeast ) )
					{
						yeast.Delete();
						pm.SendLocalizedMessage( 1046260 ); // You need to clear some space in your inventory to continue with the quest.  Come back here when you have more space in your inventory.
					}
					else
					{
						obj.Complete();
						pm.SendMessage( "You loot the yeast off the farmers corpse." );
					}
				}
			}	
		}

		public override bool OnBeforeDeath()
		{
			CheckQuest();
			return base.OnBeforeDeath();
		}

		public override void OnDamagedBySpell( Mobile caster )
		{
			base.OnDamagedBySpell( caster );

			if ( caster != m_LastQuester && m_NextCall <= DateTime.UtcNow )
			{
				if ( caster is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)caster;
					if ( bc.ControlMaster != m_LastQuester && bc.ControlMaster != null )
					{
						if ( bc.ControlMaster is PlayerMobile )
						{
							PlayerMobile cm = (PlayerMobile)bc.ControlMaster;
							QuestSystem qs = cm.Quest;

							if ( qs is TheGraveDiggerQuest )
							{
								QuestObjective obj = qs.FindObjective( typeof( FindYeastObjective ) );

								if ( obj != null && !obj.Completed )
								{
									m_LastQuester = cm;
									cm.SendMessage( "The yeast farmer calls for help." );
									switch ( Utility.Random ( 3 ) )
									{
										case 0:
										this.Say( "HELP! HELP! I am being attacked!" );
										break;
				
										case 1:
										this.Say( "Ahhh! So you want to attack a farmer... Get'em Boys!" );
										break;

										case 2:
										this.Say( "Ill show you how we handle things around here!" );
										break;
									}

									int x1 = cm.X + Utility.RandomMinMax( 3, 10 );
									int y1 = cm.Y - Utility.RandomMinMax( 3, 10 );
									int x2 = cm.X - Utility.RandomMinMax( 3, 10 );
									int y2 = cm.Y + Utility.RandomMinMax( 3, 10 );

									FarmHand fh1 = new FarmHand();
									fh1.X = x1;
									fh1.Y = y1;
									fh1.Z = cm.Z;
									fh1.Map = cm.Map;
									fh1.Combatant = cm;
									World.AddMobile( fh1 );

									fh1.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

									FarmHand fh2 = new FarmHand();
									fh2.X = x2;
									fh2.Y = y2;
									fh2.Z = cm.Z;
									fh2.Map = cm.Map;
									fh2.Combatant = cm;
									World.AddMobile( fh2 );

									fh2.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

									cm.PlaySound( 510 );

									m_NextCall = DateTime.UtcNow + TimeSpan.FromMinutes( 15.0 );
								}	
							}
						}
					}
				}
				else if ( caster is PlayerMobile )
				{
					PlayerMobile pm = (PlayerMobile)caster;
					QuestSystem qs = pm.Quest;

					if ( qs is TheGraveDiggerQuest )
					{
						QuestObjective obj = qs.FindObjective( typeof( FindYeastObjective ) );

						if ( obj != null && !obj.Completed )
						{
							m_LastQuester = pm;
							pm.SendMessage( "The yeast farmer calls for help." );
							switch ( Utility.Random ( 3 ) )
							{
								case 0:
								this.Say( "HELP! HELP! I am being attacked!" );
								break;
				
								case 1:
								this.Say( "Ahhh! So you want to attack a farmer... Get'em Boys!" );
								break;

								case 2:
								this.Say( "Ill show you how we handle things around here!" );
								break;
							}

							int x1 = pm.X + Utility.RandomMinMax( 3, 10 );
							int y1 = pm.Y - Utility.RandomMinMax( 3, 10 );
							int x2 = pm.X - Utility.RandomMinMax( 3, 10 );
							int y2 = pm.Y + Utility.RandomMinMax( 3, 10 );

							FarmHand fh1 = new FarmHand();
							fh1.X = x1;
							fh1.Y = y1;
							fh1.Z = pm.Z;
							fh1.Map = pm.Map;
							fh1.Combatant = pm;
							World.AddMobile( fh1 );

							fh1.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

							FarmHand fh2 = new FarmHand();
							fh2.X = x2;
							fh2.Y = y2;
							fh2.Z = pm.Z;
							fh2.Map = pm.Map;
							fh2.Combatant = pm;
							World.AddMobile( fh2 );

							fh2.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

							pm.PlaySound( 510 );

							m_NextCall = DateTime.UtcNow + TimeSpan.FromMinutes( 15.0 );
						}
					}
				}
			}
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );
			
			if ( attacker != m_LastQuester )
			{
				if ( attacker is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)attacker;
					if ( bc.ControlMaster != m_LastQuester && bc.ControlMaster != null )
					{
						if ( bc.ControlMaster is PlayerMobile )
						{
							PlayerMobile cm = (PlayerMobile)bc.ControlMaster;
							QuestSystem qs = cm.Quest;

							if ( qs is TheGraveDiggerQuest )
							{
								QuestObjective obj = qs.FindObjective( typeof( FindYeastObjective ) );

								if ( obj != null && !obj.Completed )
								{
									m_LastQuester = cm;
									cm.SendMessage( "The yeast farmer calls for help." );
									switch ( Utility.Random ( 3 ) )
									{
										case 0:
										this.Say( "HELP! HELP! I am being attacked!" );
										break;
				
										case 1:
										this.Say( "Ahhh! So you want to attack a farmer... Get'em Boys!" );
										break;

										case 2:
										this.Say( "Ill show you how we handle things around here!" );
										break;
									}

									int x1 = cm.X + Utility.RandomMinMax( 3, 10 );
									int y1 = cm.Y - Utility.RandomMinMax( 3, 10 );
									int x2 = cm.X - Utility.RandomMinMax( 3, 10 );
									int y2 = cm.Y + Utility.RandomMinMax( 3, 10 );

									FarmHand fh1 = new FarmHand();
									fh1.X = x1;
									fh1.Y = y1;
									fh1.Z = cm.Z;
									fh1.Map = cm.Map;
									fh1.Combatant = cm;
									World.AddMobile( fh1 );

									fh1.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

									FarmHand fh2 = new FarmHand();
									fh2.X = x2;
									fh2.Y = y2;
									fh2.Z = cm.Z;
									fh2.Map = cm.Map;
									fh2.Combatant = cm;
									World.AddMobile( fh2 );

									fh2.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

									cm.PlaySound( 510 );
								}	
							}
						}
					}
				}
				else if ( attacker is PlayerMobile )
				{
					PlayerMobile pm = (PlayerMobile)attacker;
					QuestSystem qs = pm.Quest;

					if ( qs is TheGraveDiggerQuest )
					{
						QuestObjective obj = qs.FindObjective( typeof( FindYeastObjective ) );

						if ( obj != null && !obj.Completed )
						{
							m_LastQuester = pm;
							pm.SendMessage( "The yeast farmer calls for help." );
							switch ( Utility.Random ( 3 ) )
							{
								case 0:
								this.Say( "HELP! HELP! I am being attacked!" );
								break;
				
								case 1:
								this.Say( "Ahhh! So you want to attack a farmer... Get'em Boys!" );
								break;

								case 2:
								this.Say( "Ill show you how we handle things around here!" );
								break;
							}

							int x1 = pm.X + Utility.RandomMinMax( 3, 10 );
							int y1 = pm.Y - Utility.RandomMinMax( 3, 10 );
							int x2 = pm.X - Utility.RandomMinMax( 3, 10 );
							int y2 = pm.Y + Utility.RandomMinMax( 3, 10 );

							FarmHand fh1 = new FarmHand();
							fh1.X = x1;
							fh1.Y = y1;
							fh1.Z = pm.Z;
							fh1.Map = pm.Map;
							fh1.Combatant = pm;
							World.AddMobile( fh1 );

							fh1.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

							FarmHand fh2 = new FarmHand();
							fh2.X = x2;
							fh2.Y = y2;
							fh2.Z = pm.Z;
							fh2.Map = pm.Map;
							fh2.Combatant = pm;
							World.AddMobile( fh2 );

							fh2.FixedParticles( 14120, 10, 15, 5012, EffectLayer.Waist );

							pm.PlaySound( 510 );
						}
					}
				}
			}
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( m_NextCall );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_NextCall = reader.ReadDeltaTime();
					break;
				}
			}
		}
	}
}
