using System;
using Server;
using Server.Network;
using Server.Items;
using System.Collections;

namespace Server.Items
{
	public class SawmillBlade : AddonComponent
	{
		[Constructable]
		public SawmillBlade() : base(4533)
		{
			Name = "An dangerous looking saw blade";
		}

		public override void OnDoubleClick(Mobile from)
		{
			Item typeE = from.FindItemOnLayer( Layer.TwoHanded );
			if (!from.InRange(this.GetWorldLocation(), 1)) { from.SendMessage(89, "Your too far away from the spinning blade to do any damage."); }
			if (typeE != null && typeE is ArmStumps) { from.SendMessage(89, "Your want the 1st aid kit!!!! not the blades."); }
			else
			{
				Item typeA = from.FindItemOnLayer( Layer.OneHanded );
				if (typeA != null) typeA.MoveToWorld( new Point3D( from.X, from.Y, from.Z ), from.Map );
				Item typeB = from.FindItemOnLayer( Layer.TwoHanded );
				if (typeB != null) typeB.MoveToWorld( new Point3D( from.X, from.Y, from.Z ), from.Map );
				Item typeC = from.FindItemOnLayer( Layer.Gloves );
				if (typeC != null) typeC.MoveToWorld( new Point3D( from.X, from.Y, from.Z ), from.Map );
				ArmStumps armStumps = new ArmStumps();
				armStumps.Movable = false;
				from.EquipItem( armStumps );
				from.SendMessage(89, "You have cut off your hands and the stuff they were hold fell to the ground");
				Effects.PlaySound(from.Location, from.Map, 0x218);
				BeginBleed(from);
			}
		}

		private static Hashtable m_BloodTable = new Hashtable();

		public static bool IsBleeding(Mobile m) { return m_BloodTable.Contains(m); }

		public static void BeginBleed(Mobile m)
		{
			Timer t = (Timer)m_BloodTable[m];
			if (t != null) t.Stop();
			t = new InternalTimer(m);
			m_BloodTable[m] = t;
			t.Start();
		}

		public static void DoBleed(Mobile m)
		{
			if (m.Alive)
			{
				m.PlaySound(0x133);
				Blood blood = new Blood();
				blood.ItemID = Utility.Random(0x122A, 5);
				blood.MoveToWorld(m.Location, m.Map);
			}
			else { EndBleed(m, false); }
		}

		public static void EndBleed(Mobile m, bool message)
		{
			Timer t = (Timer)m_BloodTable[m];
			if (t == null) return;
			t.Stop();
			m_BloodTable.Remove(m);
			if (message) m.SendLocalizedMessage(1060167); // The bleeding wounds have healed, you are no longer bleeding!
		}

		private class InternalTimer : Timer
		{
			private Mobile m_Mobile;
			private int m_Count;

			public InternalTimer(Mobile m) : base(TimeSpan.FromSeconds(2.0), TimeSpan.FromSeconds(2.0))
			{
				m_Mobile = m;
				Priority = TimerPriority.TwoFiftyMS;
			}

			protected override void OnTick()
			{
				DoBleed(m_Mobile);
				if (++m_Count == 5) EndBleed(m_Mobile, true);
			}
		}

		public SawmillBlade(Serial serial) : base(serial) { }

		public override void Serialize(GenericWriter writer) { base.Serialize(writer); writer.Write(0); }

		public override void Deserialize(GenericReader reader) { base.Deserialize(reader); int version = reader.ReadInt(); }
	}

	public class SawmillSign : AddonComponent
	{
		private string m_SafetyWarning = "Safety Warning";
		private string m_Resource = "Logs";

		[Constructable]
		public SawmillSign() : base(3026)
		{
			Name = "The Yaki 'Cut-O-Matic' Lumber Mill";
			Hue = 33;
		}

		public override void OnDoubleClick(Mobile from)
		{
			from.SendMessage(89, "Don't play with the blade");
		}

		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);
			list.Add(1060661, "This Sawmill Cuts \t{0}", m_Resource.ToString());
			list.Add(1060658, "{0}\tNever Put Your Fingers Near The Blade.", m_SafetyWarning.ToString());
			list.Add(1060659, "{0}\tAlways Use Correct Protective Equipment.", m_SafetyWarning.ToString());
		}

		public SawmillSign(Serial serial) : base(serial) { }

		public override void Serialize(GenericWriter writer) { base.Serialize(writer); writer.Write(0); }

		public override void Deserialize(GenericReader reader) { base.Deserialize(reader); int version = reader.ReadInt(); }
	}

	public class Sawmill1stAidKit : AddonComponent
	{
		[Constructable]
		public Sawmill1stAidKit() : base(3026)
		{
			Name = "Sawmill 1st Aid Kit";
			Hue = 30;
		}

		public override void OnDoubleClick(Mobile from)
		{
			Item typeD = from.FindItemOnLayer( Layer.TwoHanded );
			if (typeD != null)
			{
				typeD.Delete();
				from.SendMessage(89, "The magic of the kit reataches your hands");
			}
			else from.SendMessage(89, "Please be careful with the saw");
		}

		public Sawmill1stAidKit(Serial serial) : base(serial) { }

		public override void Serialize(GenericWriter writer) { base.Serialize(writer); writer.Write(0); }

		public override void Deserialize(GenericReader reader) { base.Deserialize(reader); int version = reader.ReadInt(); }
	}

	public class SawmillCrate : AddonComponent
	{
		[Constructable]
		public SawmillCrate() : base(3645)
		{
			Name = "Sawmill Crate";
		}

		public override void OnDoubleClick(Mobile from)
		{
			from.SendMessage(89, "Place your logs into the crate");
		}

		public override bool OnDragDrop(Mobile from, Item dropped)
		{
			int amounttocut = 0;

			if (!from.InRange(this.GetWorldLocation(), 1)) { from.SendMessage(89, "You are too far from the machine, step closer."); return false; }
			else
			{
				if (dropped is Log)
				{
					Log yourlogs = (Log)dropped;
					dropped.Delete();
					amounttocut = yourlogs.Amount;
					from.SendMessage(89, "You recieve {0} boards", amounttocut);
					Effects.PlaySound(from.Location, from.Map, 0x218);
					string s_resource = Convert.ToString(yourlogs.Resource);
					Item spawn;
					switch (s_resource)
					{
						default: spawn = new Board(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						//case "Pine": spawn = new PineBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "AshWood": spawn = new AshBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						//case "Mahogany": spawn = new MahoganyBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "YewWood": spawn = new YewBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "OakWood": spawn = new OakBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						//case "Cedar": spawn = new CedarBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						//case "Cherry": spawn = new CherryBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "Heartwood": spawn = new HeartwoodBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "Frostwood": spawn = new FrostwoodBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						case "Bloodwood": spawn = new BloodwoodBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); break;
						//case "Eucalyptus": spawn = new EucalyptusBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); //break;
						//case "Willow": spawn = new WillowBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); //break;
						//case "Cherry": spawn = new CherryBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); //break;
						//case "Heartwood": spawn = new HeartwoodBoard(yourlogs.Amount); spawn.MoveToWorld(new Point3D(this.X, this.Y-3, this.Z+3), this.Map); //break;
					}
					return true;
				}

				from.SendMessage(89, "This can only cut logs.");
				return false;
			}
			return false;
		}
		public SawmillCrate(Serial serial) : base(serial) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}

	public class SawmillAddon : BaseAddon
	{
		public override BaseAddonDeed Deed { get { return new SawmillAddonDeed(); } }

		[Constructable]
		public SawmillAddon()
		{
			// base
			AddComponent(new AddonComponent(2328), 0, 0, 0);
			AddComponent(new AddonComponent(2328), 0, -3, 0);
			AddComponent(new AddonComponent(1872), 0, -1, 0);
			AddComponent(new AddonComponent(1872), 0, -2, 0);

			// platforms
			AddComponent(new AddonComponent(1981), 0, -1, 5);
			AddComponent(new AddonComponent(1981), 0, -2, 5);
			AddComponent(new AddonComponent(1981), 0, -3, 1);

			// blade
			AddComponent(new SawmillBlade(), 0, -1, 4);

			// sign
			AddComponent(new SawmillSign(), 1, -1, -6);

			// 1st aid kit
			AddComponent(new Sawmill1stAidKit(), 1, -2, -6);

			// crate
			AddComponent(new SawmillCrate(), 0, 0, 0);
		}

		public SawmillAddon(Serial serial) : base(serial) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); } }

	public class SawmillAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon { get { return new SawmillAddon(); } }

		[Constructable]
		public SawmillAddonDeed()
		{
			Name = "Cut-o-matic Sawmill";
		}

		public SawmillAddonDeed(Serial serial) : base(serial) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( 0 ); }

		public override void	Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}

	public class ArmStumps : BaseStaff
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosStrengthReq{ get{ return 1; } }
		public override int AosMinDamage{ get{ return 1; } }
		public override int AosMaxDamage{ get{ return 3; } }
		public override int AosSpeed{ get{ return 25; } }

		public override int OldStrengthReq{ get{ return 1; } }
		public override int OldMinDamage{ get{ return 1; } }
		public override int OldMaxDamage{ get{ return 3; } }
		public override int OldSpeed{ get{ return 25; } }

		public override int InitMinHits{ get{ return 0; } }
		public override int InitMaxHits{ get{ return 0; } }

		public override int DefHitSound{ get{ return 330; } }
		public override int DefMissSound{ get{ return -1; } }

		public override SkillName DefSkill{ get{ return SkillName.Wrestling; } }
		public override WeaponType DefType{ get{ return WeaponType.Fists; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Wrestle; } }

		[Constructable]
		public ArmStumps() : base( 0x1414 )
		{
			Weight = 0;
			Hue = 2972;
			Layer = Layer.TwoHanded;
			Name = "Bloody Arm Stumps";
		}

		public ArmStumps( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( (int) 0 );}

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt();}
	}
}