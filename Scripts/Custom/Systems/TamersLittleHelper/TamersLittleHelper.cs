//Created by Ashlar, beloved of Morrigan
using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
	public class TamersLittleHelper : Item
	{
		private Mobile m_InUseBy = null;
        private DateTime m_LastUsed = DateTime.Now;
        private TimeSpan m_TimeOut;
        private TimeSpan m_IdleTimer = TimeSpan.FromMinutes(1); // How long can a person be standing at the machine idle?
		private double m_MaxSkillAllowed;

        [CommandProperty(AccessLevel.GameMaster)]
        public Mobile InUseBy
        {
            get { return m_InUseBy; }
            set { m_InUseBy = value; InvalidateProperties(); }

        }

        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime LastUsed
        {
            get { return m_LastUsed; }
            set { m_LastUsed = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public double MaxSkillAllowed
        {
            get { return m_MaxSkillAllowed; }
            set { m_MaxSkillAllowed = value; }
        }


		[Constructable]
		public TamersLittleHelper() : base( 0x139A )
		{
			Hue = 401;
			Name = "Tamers Little Helper";
			LootType = LootType.Blessed;
			Weight = 0.1;
			MaxSkillAllowed = 120;
		}

		public TamersLittleHelper( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			m_TimeOut = DateTime.Now - m_LastUsed;

            if (m_InUseBy == null || m_InUseBy.Deleted)
                InUseBy = from;
            else
            {
                if (m_IdleTimer < m_TimeOut)
                {
                    if (from != m_InUseBy)
                    {
						from.SendMessage("{0} has left this machine idle too long, it is yours to play.", m_InUseBy.Name);
						InUseBy = from;
					}
                }
            }

            if (from == m_InUseBy)
            {
				if (from.Skills[SkillName.AnimalTaming].Base >= m_MaxSkillAllowed )
				{
					InUseBy = null;

					from.SendMessage( "You can no longer gain skill in Animal Taming, by using this device.  Time to hit the forests!" );
				}
				else
				{
					SummonTamable(this, from);
				}
            }
            else
            {
                string text = String.Format("{0} is currently using this taming helper.", m_InUseBy.Name);
                from.SendMessage(text);
            }
		}

		public static void SummonTamable(TamersLittleHelper tlh, Mobile m_From)
		{
 			if (m_From == null || tlh == null)
				return;

			if (tlh.InUseBy == null)
			{
				m_From.SendMessage("Someone else used this taming helper while you were idle. Double click it again to resume taming.");

				return;
			}

			if (m_From.Serial != tlh.InUseBy.Serial)
			{
				m_From.SendMessage("You have left this machine idle too long and {0} has taken it over!",tlh.InUseBy.Name);

				return;
			}

			if (!m_From.Alive)
			{
				m_From.SendMessage("Ghosts can not use this taming helper.");
				tlh.InUseBy = null;

				return;
			}

			tlh.LastUsed = DateTime.Now;

			double theirSkill = m_From.Skills[SkillName.AnimalTaming].Value;
			if ( theirSkill >= tlh.MaxSkillAllowed )
				return;

			if ( theirSkill <= 11 )
			{
				Mobile TamingMountainGoat = new TamingMountainGoat();
				TamingMountainGoat.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 11 && theirSkill <= 23 )
			{
				Mobile TamingSheep = new TamingSheep();
				TamingSheep.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 23 && theirSkill <= 35 )
			{
				Mobile TamingTimberWolf = new TamingTimberWolf();
				TamingTimberWolf.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 35 && theirSkill <= 41 )
			{
				Mobile TamingBlackBear = new TamingBlackBear();
				TamingBlackBear.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 41 && theirSkill <= 47 )
			{
				Mobile TamingBrownBear = new TamingBrownBear();
				TamingBrownBear.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 47 && theirSkill <= 59 )
			{
				Mobile TamingAlligator = new TamingAlligator();
				TamingAlligator.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 59 && theirSkill <= 65 )
			{
				Mobile TamingGreatHart = new TamingGreatHart();
				TamingGreatHart.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 65 && theirSkill <= 70 )
			{
				Mobile TamingGrizzlyBear = new TamingGrizzlyBear();
				TamingGrizzlyBear.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 70 && theirSkill <= 80 )
			{
				Mobile TamingBull = new TamingBull();
				TamingBull.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 80 && theirSkill <= 90 )
			{
				Mobile TamingGiantToad = new TamingGiantToad();
				TamingGiantToad.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 90 && theirSkill <= 100 )
			{
				Mobile TamingBakeKitsune = new TamingBakeKitsune();
				TamingBakeKitsune.MoveToWorld( m_From.Location, m_From.Map );
			}
			else if ( theirSkill > 100.0 )
			{
				Mobile TamingHiryu = new TamingHiryu();
				TamingHiryu.MoveToWorld( m_From.Location, m_From.Map );
			}
			else
			{
				m_From.SendLocalizedMessage( 502694 ); // Cancelled action.
				tlh.InUseBy = null;
			}
		}

		private bool CheckInRange(Point3D loc, int range)
		{
			return Utility.InRange(GetWorldLocation(), loc, range);
		}

		public override void OnMovement(Mobile m, Point3D oldLocation)
		{
			if (m_InUseBy != null)
			{
				if (!m_InUseBy.InRange(GetWorldLocation(), 3) || m_InUseBy.Map == Map.Internal)
				{
					m_InUseBy.SendMessage("You have walked away from the taming helper, others may now use it.");
					InUseBy = null;
				}
			}
		}

        private string GetStatus(Mobile m)
        {
            string useStatus;

            if (m_InUseBy == null)
            {
                useStatus = "Available";
            }
            else
            {
                useStatus = "In Use by " + m_InUseBy.Name;
            }

            return useStatus;
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);

            list.Add(1060658, "Status\t" + GetStatus(m_InUseBy));
        }

        public override void OnSingleClick(Mobile from)
        {
            base.OnSingleClick(from);

            this.LabelTo(from, "Status {0}", GetStatus(m_InUseBy));
        }

        public override void OnAosSingleClick(Mobile from)
        {
            base.OnSingleClick(from);

            this.LabelTo(from, GetStatus(m_InUseBy));
        }

        public override bool HandlesOnMovement { get { return (m_InUseBy != null); } }// Tell the core that we implement OnMovement

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 2 ); // version

			writer.Write(m_MaxSkillAllowed);
			writer.Write(m_InUseBy);
			writer.Write(m_LastUsed);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			switch (version)
            {
				case 2:
				{
					m_MaxSkillAllowed = reader.ReadDouble();

					goto case 1;
				}
				case 1:
				{
					m_InUseBy = reader.ReadMobile();
					m_LastUsed = reader.ReadDateTime();

					goto case 0;
				}
				case 0:
					break;
			}
		}
	}
}
