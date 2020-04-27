using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Engines.CannedEvil;
using System.Collections.Generic;

namespace Server.Mobiles
{
	public class KimKardashian : BaseCreature
	{

        public MonsterStatuetteType[] StatueTypes{ get{ return new MonsterStatuetteType[] { }; } }

		private bool m_TrueForm;
		private Item m_GateItem;

		private static ArrayList m_Instances = new ArrayList();

		public static ArrayList Instances{ get{ return m_Instances; } }

		public static bool CanSpawn
		{
			get
			{
				return ( m_Instances.Count == 0 );
			}
		}

		[Constructable]
		public KimKardashian() : base( AIType.AI_Mage, FightMode.Closest, 18, 1, 0.2, 0.4 )
		{
					
			m_Instances.Add( this );

			Name = " Kim Kardashian ";
			BodyValue = 401;
			Hue = 35075;
			HairItemID = 8252;
			HairHue = 1;
			
			AddItem( new AntiqueWeddingDress ());

			SetStr( 1000, 1560 );
			SetDex( 750, 950 );
			SetInt( 1000, 2200 );
			SetDamage( 20, 25 );

			SetFameLevel( 50000 );
			SetKarmaLevel( -50000 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Energy, 80 );

			SetResistance( ResistanceType.Physical, 55, 80 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 60, 80 );
			SetResistance( ResistanceType.Poison, 60, 80 );
			SetResistance( ResistanceType.Energy, 60, 80 );

			SetSkill( SkillName.Wrestling, 100.9, 155.5 );
			SetSkill( SkillName.Tactics, 196.9, 202.2 );
			SetSkill( SkillName.MagicResist, 131.4, 140.8 );
			SetSkill( SkillName.Magery, 100.2, 141.4 );
			SetSkill( SkillName.EvalInt, 110.0 );
			SetSkill( SkillName.Meditation, 120.0 );

			SetSpecialAbility(SpecialAbility.LifeDrain);
		}

		public override int GetIdleSound() { return 0x667; } 
		public override int GetAngerSound() { return 0x63E; } 
		public override int GetHurtSound() { return 0x641; } 
		public override int GetDeathSound() { return 0x63F; }
		
			        public override void OnMovement(Mobile m, Point3D oldLocation)
        {
        }
		
		public override void GenerateLoot()
		{

                        PackItem (new CrystallineBlackrock(10));
                        PackItem (new RelicFragment(10));
                        PackItem (new MagicClothDeed());
                        PackItem( new WhiteFang( 100 ) );
                        AddLoot( LootPack.SuperBoss, 3 );
			AddLoot( LootPack.Meager );
			
			if (Utility.Random(100) < 98)
            		{

                		int level;

                		double random = Utility.RandomDouble();

                		if (0.30 >= random)
                    		level = 120;

                		else if (0.50 >= random)
                    		level = 105;
						else level = 110;

                		switch (Utility.Random(27))
                		{
                    			case 0: AddToBackpack(new PowerScroll(SkillName.Swords, level)); break;
                    			case 1: AddToBackpack(new PowerScroll(SkillName.Fencing, level)); break;
                    			case 2: AddToBackpack(new PowerScroll(SkillName.Archery, level)); break;
                    			case 3: AddToBackpack(new PowerScroll(SkillName.Parry, level)); break;
                    			case 4: AddToBackpack(new PowerScroll(SkillName.Tactics, level)); break;
                    			case 5: AddToBackpack(new PowerScroll(SkillName.Anatomy, level)); break;
                    			case 6: AddToBackpack(new PowerScroll(SkillName.Healing, level)); break;
                    			case 7: AddToBackpack(new PowerScroll(SkillName.Magery, level)); break;
                    			case 8: AddToBackpack(new PowerScroll(SkillName.Meditation, level)); break;
                    			case 9: AddToBackpack(new PowerScroll(SkillName.EvalInt, level)); break;
                    			case 10: AddToBackpack(new PowerScroll(SkillName.MagicResist, level)); break;
                    			case 11: AddToBackpack(new PowerScroll(SkillName.Musicianship, level)); break;
                    			case 12: AddToBackpack(new PowerScroll(SkillName.Provocation, level)); break;
                    			case 13: AddToBackpack(new PowerScroll(SkillName.Discordance, level)); break;
                    			case 18: AddToBackpack(new PowerScroll(SkillName.Bushido, level)); break;
                    			case 19: AddToBackpack(new PowerScroll(SkillName.Imbuing, level)); break;
                    			case 20: AddToBackpack(new PowerScroll(SkillName.Macing, level)); break;
                    			case 21: AddToBackpack(new PowerScroll(SkillName.Wrestling, level)); break;
                    			case 22: AddToBackpack(new PowerScroll(SkillName.Blacksmith, level)); break;
                    			case 23: AddToBackpack(new PowerScroll(SkillName.Inscribe, level)); break;
                    			case 24: AddToBackpack(new PowerScroll(SkillName.Carpentry, level)); break;
                    			case 25: AddToBackpack(new PowerScroll(SkillName.Fletching, level)); break;
                    			case 26: AddToBackpack(new PowerScroll(SkillName.Tinkering, level)); break;
                		}
            		}
			
		}

		public override bool AutoDispel{ get{ return true; } }
	    public override bool BardImmune{ get{ return true; } }
        public override bool AlwaysMurderer { get { return true; } }
        
		//UOWW: commented out for compatibility with the new Core
		//
		//public override bool DrainsLife { get { return true; } }
		
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } } 
        public override Poison HitPoison { get { return Poison.Deadly; } }


		private static readonly double[] m_Offsets = new double[]
			{
				Math.Cos( 000.0 / 180.0 * Math.PI ), Math.Sin( 000.0 / 180.0 * Math.PI ),
				Math.Cos( 040.0 / 180.0 * Math.PI ), Math.Sin( 040.0 / 180.0 * Math.PI ),
				Math.Cos( 080.0 / 180.0 * Math.PI ), Math.Sin( 080.0 / 180.0 * Math.PI ),
				Math.Cos( 120.0 / 180.0 * Math.PI ), Math.Sin( 120.0 / 180.0 * Math.PI ),
				Math.Cos( 160.0 / 180.0 * Math.PI ), Math.Sin( 160.0 / 180.0 * Math.PI ),
				Math.Cos( 200.0 / 180.0 * Math.PI ), Math.Sin( 200.0 / 180.0 * Math.PI ),
				Math.Cos( 240.0 / 180.0 * Math.PI ), Math.Sin( 240.0 / 180.0 * Math.PI ),
				Math.Cos( 280.0 / 180.0 * Math.PI ), Math.Sin( 280.0 / 180.0 * Math.PI ),
				Math.Cos( 320.0 / 180.0 * Math.PI ), Math.Sin( 320.0 / 180.0 * Math.PI ),
			};

		public void Morph()
		{
			if ( m_TrueForm )
				return;

			m_TrueForm = true;

			Name = " Bridezilla ";
			BodyValue = 1400;

			Hits = HitsMax;
			Stam = StamMax;
			Mana = ManaMax;

			ProcessDelta();

			Say( 1049499 ); // Better watch out Bitches!

			Map map = this.Map;

			if ( map != null )
			{
				for ( int i = 0; i < m_Offsets.Length; i += 2 )
				{
					double rx = m_Offsets[i];
					double ry = m_Offsets[i + 1];

					int dist = 0;
					bool ok = false;
					int x = 0, y = 0, z = 0;

					while ( !ok && dist < 10 )
					{
						int rdist = 10 + dist;

						x = this.X + (int)(rx * rdist);
						y = this.Y + (int)(ry * rdist);
						z = map.GetAverageZ( x, y );

						if ( !(ok = map.CanFit( x, y, this.Z, 16, false, false ) ) )
							ok = map.CanFit( x, y, z, 16, false, false );

						if ( dist >= 0 )
							dist = -(dist + 1);
						else
							dist = -(dist - 1);
					}

					if ( !ok )
						continue;

				}
			}
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 30000 : 30000; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public override int ManaMax{ get{ return 5000; } }

		public KimKardashian( Serial serial ) : base( serial )
		{
			m_Instances.Add( this );
		}

		public override void OnAfterDelete()
		{
			m_Instances.Remove( this );

			base.OnAfterDelete();
		}

		public override bool DisallowAllMoves{ get{ return m_TrueForm; } }

		//UOWW: DrainsLife compatibility with the new Core
		//
		public override void OnDrainLife(Mobile victim)
        {
            if (Map == null)
                return;

            ArrayList list = new ArrayList();
            int count = 0;
            IPooledEnumerable eable = GetMobilesInRange(20);

            foreach (Mobile m in eable)
            {
                if (m == this || !CanBeHarmful(m))
                {
                    if (m is DarkWisp) { count++; }
                    continue;
                }

                if (m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != Team))
                    list.Add(m);
                else if (m.Player)
                    list.Add(m);
            }

            eable.Free();

            foreach (Mobile m in list)
            {
                (new DarkWisp()).MoveToWorld(new Point3D(Location), Map);
                int teleportchance = Hits / HitsMax;

                if (teleportchance < Utility.RandomDouble() && m.Alive)
                {
                    switch (Utility.Random(6))
                    {
                        case 0: m.MoveToWorld(new Point3D(6431, 1664, 0), Map); break;
                        case 1: m.MoveToWorld(new Point3D(6432, 1634, 0), Map); break;
                        case 2: m.MoveToWorld(new Point3D(6401, 1657, 0), Map); break;
                        case 3: m.MoveToWorld(new Point3D(6401, 1637, 0), Map); break;
                        default: m.MoveToWorld(new Point3D(Location), Map); break;
                    }
                }
            }
        }		
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( m_TrueForm );
			writer.Write( m_GateItem );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_TrueForm = reader.ReadBool();
					m_GateItem = reader.ReadItem();


					break;
				}
			}
		}

		public override bool OnBeforeDeath()
		{
			if ( m_TrueForm )
			{
				 List<DamageStore> rights = GetLootingRights();

				if ( !NoKillAwards )
				{
					Map map = this.Map;

					if ( map != null )
					{
						for ( int x = -16; x <= 16; ++x )
						{
							for ( int y = -16; y <= 16; ++y )
							{
								double dist = Math.Sqrt(x*x+y*y);

								if ( dist <= 16 )
									new GoodiesTimer( map, X + x, Y + y ).Start();
							}
						}
					}

					if ( m_GateItem != null )
						m_GateItem.Delete();
				}
				
				return base.OnBeforeDeath();

				
			}
			else
			{
				Morph();
				return false;
			}
		}

		Dictionary<Mobile, int> m_DamageEntries;

		public virtual void RegisterDamageTo( Mobile m )
		{
			if( m == null )
				return;

			foreach( DamageEntry de in m.DamageEntries )
			{
				Mobile damager = de.Damager;

				Mobile master = damager.GetDamageMaster( m );

				if( master != null )
					damager = master;

				RegisterDamage( damager, de.DamageGiven );
			}
		}

		public void RegisterDamage( Mobile from, int amount )
		{
			if( from == null || !from.Player )
				return;

			if( m_DamageEntries.ContainsKey( from ) )
				m_DamageEntries[from] += amount;
			else
				m_DamageEntries.Add( from, amount );

			from.SendMessage(String.Format("Total Damage: {0}", m_DamageEntries[from]) );
		}

		public void AwardArtifact( Item artifact )
		{
			if (artifact == null )
				return;

			int totalDamage = 0;

			Dictionary<Mobile, int> validEntries = new Dictionary<Mobile, int>();

			foreach (KeyValuePair<Mobile, int> kvp in m_DamageEntries)
			{
				if( IsEligible( kvp.Key, artifact ) )
				{
					validEntries.Add( kvp.Key, kvp.Value );
					totalDamage += kvp.Value;
				}
			}

			int randomDamage = Utility.RandomMinMax( 1, totalDamage );

			totalDamage = 0;

			foreach (KeyValuePair<Mobile, int> kvp in m_DamageEntries)
			{
				totalDamage += kvp.Value;

				if( totalDamage > randomDamage )
				{
					GiveArtifact( kvp.Key, artifact );
					break;
				}
			}
		}

		public void GiveArtifact( Mobile to, Item artifact )
		{
			if ( to == null || artifact == null )
				return;

			Container pack = to.Backpack;

			if ( pack == null || !pack.TryDropItem( to, artifact, false ) )
				artifact.Delete();
			else
				to.SendLocalizedMessage( 1062317 ); // For your valor in combating the fallen beast, a special artifact has been bestowed on you.
		}

		public bool IsEligible( Mobile m, Item Artifact )
		{
			return m.Player && m.Alive && m.InRange( Location, 32 ) && m.Backpack != null && m.Backpack.CheckHold( m, Artifact, false );
		}

        public Item CreateArtifact(Type[] list)
        {
            if (list.Length == 0)
                return null;

            int random = Utility.Random(list.Length);

            Type type = list[random];

            Item artifact = Loot.Construct(type);

            if (artifact is MonsterStatuette && StatueTypes.Length > 0)
            {
                ((MonsterStatuette)artifact).Type = StatueTypes[Utility.Random(StatueTypes.Length)];
                ((MonsterStatuette)artifact).LootType = LootType.Regular;
            }

            return artifact;
        }

		private class TeleportTimer : Timer
		{
			private Mobile m_Owner;

			private static int[] m_Offsets = new int[]
			{
				-1, -1,
				-1,  0,
				-1,  1,
				0, -1,
				0,  1,
				1, -1,
				1,  0,
				1,  1
			};

			public TeleportTimer( Mobile owner ) : base( TimeSpan.FromSeconds( 5.0 ), TimeSpan.FromSeconds( 5.0 ) )
			{
				Priority = TimerPriority.TwoFiftyMS;

				m_Owner = owner;
			}

			protected override void OnTick()
			{
				if ( m_Owner.Deleted )
				{
					Stop();
					return;
				}

				Map map = m_Owner.Map;

				if ( map == null )
					return;

				if ( 0.25 < Utility.RandomDouble() )
					return;

				Mobile toTeleport = null;

				foreach ( Mobile m in m_Owner.GetMobilesInRange( 16 ) )
				{
					if ( m != m_Owner && m.Player && m_Owner.CanBeHarmful( m ) && m_Owner.CanSee( m ) )
					{
						toTeleport = m;
						break;
					}
				}

				if ( toTeleport != null )
				{
					int offset = Utility.Random( 8 ) * 2;

					Point3D to = m_Owner.Location;

					for ( int i = 0; i < m_Offsets.Length; i += 2 )
					{
						int x = m_Owner.X + m_Offsets[(offset + i) % m_Offsets.Length];
						int y = m_Owner.Y + m_Offsets[(offset + i + 1) % m_Offsets.Length];

						if ( map.CanSpawnMobile( x, y, m_Owner.Z ) )
						{
							to = new Point3D( x, y, m_Owner.Z );
							break;
						}
						else
						{
							int z = map.GetAverageZ( x, y );

							if ( map.CanSpawnMobile( x, y, z ) )
							{
								to = new Point3D( x, y, z );
								break;
							}
						}
					}

					Mobile m = toTeleport;

					Point3D from = m.Location;

					m.Location = to;

					Server.Spells.SpellHelper.Turn( m_Owner, toTeleport );
					Server.Spells.SpellHelper.Turn( toTeleport, m_Owner );

					m.ProcessDelta();

					Effects.SendLocationParticles( EffectItem.Create( from, m.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
					Effects.SendLocationParticles( EffectItem.Create(   to, m.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 5023 );

					m.PlaySound( 0x1FE );

					m_Owner.Combatant = toTeleport;
				}
			}
		}

		private class GoodiesTimer : Timer
		{
			private Map m_Map;
			private int m_X, m_Y;

			public GoodiesTimer( Map map, int x, int y ) : base( TimeSpan.FromSeconds( Utility.RandomDouble() * 10.0 ) )
			{
				Priority = TimerPriority.TwoFiftyMS;

				m_Map = map;
				m_X = x;
				m_Y = y;
			}

			protected override void OnTick()
			{
				int z = m_Map.GetAverageZ( m_X, m_Y );
				bool canFit = m_Map.CanFit( m_X, m_Y, z, 6, false, false );

				for ( int i = -3; !canFit && i <= 3; ++i )
				{
					canFit = m_Map.CanFit( m_X, m_Y, z + i, 6, false, false );

					if ( canFit )
						z += i;
				}

			}
		}
	}

}