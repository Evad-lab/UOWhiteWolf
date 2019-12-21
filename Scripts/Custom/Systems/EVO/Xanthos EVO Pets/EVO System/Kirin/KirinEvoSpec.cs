using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Misc;
using Server.SkillHandlers;
using System.Collections;
using System.Collections.Generic;
using Server.Targeting;
using Xanthos.Utilities;
using Xanthos.Interfaces;

namespace Xanthos.Evo
{
	public sealed class KirinEvoSpec : BaseEvoSpec
	{
		// This class implements a singleton pattern; meaning that no matter how many times the
		// Instance attribute is used, there will only ever be one of these created in the entire system.
		// Copy this template and give it a new name.  Assign all of the data members of the EvoSpec
		// base class in the constructor.  Your subclass must not be abstract.
		// Never call new on this class, use the Instance attribute to get the instance instead.

		KirinEvoSpec()
		{
			m_Tamable = true;
			m_MinTamingToHatch = 99.9;
			m_PercentFemaleChance = 0.0;
			m_GuardianEggOrDeedChance = .15;
			m_AlwaysHappy = false;
			m_ProducesYoung = false;
			m_PregnancyTerm = 0.10;
			m_AbsoluteStatValues = false;
			m_MaxEvoResistance = 90;
			m_MaxTrainingStage = 9;
			m_MountStage = 3;
			m_CanAttackPlayers = false;

			m_Skills = new SkillName[4] { SkillName.MagicResist, SkillName.Tactics, SkillName.Wrestling, SkillName.Anatomy };
			m_MinSkillValues = new int[4] { 50, 50, 50, 15, };
			m_MaxSkillValues = new int[4] { 100, 110, 120, 110 };


			m_Stages = new BaseEvoStage[] { new KirinStageOne(), new KirinStageTwo(), new KirinStageThree(),
											  new KirinStageFour(), new KirinStageFive() };
		}

		// These next 2 lines facilitate the singleton pattern.  In your subclass only change the
		// BaseEvoSpec class name to your subclass of BaseEvoSpec class name and uncomment both lines.
		public static KirinEvoSpec Instance { get { return Nested.instance; } }
		class Nested { static Nested() { } internal static readonly KirinEvoSpec instance = new KirinEvoSpec();}
	}	

	// Define a subclass of BaseEvoStage for each stage in your creature and place them in the
	// array in your subclass of BaseEvoSpec.  See the example classes for how to do this.
	// Your subclass must not be abstract.

	public class KirinStageOne : BaseEvoStage
	{
		public KirinStageOne()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 25000; EpMinDivisor = 25; EpMaxDivisor = 25; DustMultiplier = 20;
			BaseSoundID = 0x4FD;
			BodyValue = 220; ControlSlots = 2; MinTameSkill = 99.9; VirtualArmor = 30;

			DamagesTypes = new ResistanceType[1] { ResistanceType.Physical };
			MinDamages = new int[1] { 100 };
			MaxDamages = new int[1] { 100 };
			Hue = Utility.RandomList( 1157, 1175, 1172, 1171, 1170, 1169, 1168, 1167, 1166, 1165 );
			ResistanceTypes = new ResistanceType[1] { ResistanceType.Physical };
			MinResistances = new int[1] { 15 };
			MaxResistances = new int[1] { 15 };

			DamageMin = 11; DamageMax = 15; HitsMin = 150; HitsMax = 200;
			StrMin = 200; StrMax = 250; DexMin = 95; DexMax = 105; IntMin = 80; IntMax = 100;
		}
	}

	public class KirinStageTwo : BaseEvoStage
	{
		public KirinStageTwo()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 75000; EpMinDivisor = 20; EpMaxDivisor = 25; DustMultiplier = 20;
			BaseSoundID = 0x4FD;
			BodyValue = 220; VirtualArmor = 40;
		
			DamagesTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
													ResistanceType.Poison, ResistanceType.Energy };
			MinDamages = new int[5] { 20, 20, 20, 20, 20 };
			MaxDamages = new int[5] { 20, 20, 20, 20, 20 };

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 25, 25, 25, 25, 25 };
			MaxResistances = new int[5] { 25, 25, 25, 25, 25 };

			DamageMin = 2; DamageMax = 2; HitsMin= 450; HitsMax = 450;
			StrMin = 150; StrMax = 150; DexMin = 40; DexMax = 40; IntMin = 50; IntMax = 50;
		}
	}

	public class KirinStageThree : BaseEvoStage
	{
		public KirinStageThree()
		{
			EvolutionMessage = "has evolved into Unholy Ki-Rin";
			NextEpThreshold = 1250000; EpMinDivisor = 30; EpMaxDivisor = 30; DustMultiplier = 20;
			BaseSoundID = 0x5A;
			BodyValue = 132; VirtualArmor = 50;
		
			DamagesTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
													 ResistanceType.Poison, ResistanceType.Energy };
			MinDamages = new int[5] { 100, 20, 20, 20, 20 };
			MaxDamages = new int[5] { 100, 20, 20, 20, 20 };

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 35, 35, 35, 35, 35 };
			MaxResistances = new int[5] { 35, 35, 35, 35, 35 };

			DamageMin = 5; DamageMax = 5; HitsMin= 100; HitsMax = 100;
			StrMin = 100; StrMax = 100; DexMin = 40; DexMax = 40; IntMin = 40; IntMax = 40;
		}
	}

	public class KirinStageFour : BaseEvoStage
	{
		public KirinStageFour()
		{
			EvolutionMessage = "has evolved into dark Ki-Rin";
			NextEpThreshold = 7750000; EpMinDivisor = 30; EpMaxDivisor = 30; DustMultiplier = 20;
			BaseSoundID = 0x4FD;
			BodyValue = 132; ControlSlots = 3; MinTameSkill = 119.9; VirtualArmor = 60;
		
			DamagesTypes = null;
			MinDamages = null;
			MaxDamages = null;

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 40, 40, 40, 40, 40 };
			MaxResistances = new int[5] { 40, 40, 40, 40, 40 };	

			DamageMin = 5; DamageMax = 5; HitsMin= 100; HitsMax = 100;
			StrMin = 150; StrMax = 150; DexMin = 40; DexMax = 40; IntMin = 100; IntMax = 100;
		}
	}

	public class KirinStageFive : BaseEvoStage
	{
		public KirinStageFive()
		{
			EvolutionMessage = "has evolved to its highest form and is now an Ancient Ki-Rin";
			NextEpThreshold = 0; EpMinDivisor = 40; EpMaxDivisor = 40; DustMultiplier = 20;
			BaseSoundID = 362; ControlSlots = 4;
			BodyValue = 132; VirtualArmor = 100;
		
			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 55, 70, 25, 40, 40 };
			MaxResistances = new int[5] { 90, 90, 90, 90, 90 };	

			DamageMin = 10; DamageMax = 10; HitsMin= 300; HitsMax = 300;
			StrMin = 200; StrMax = 200; DexMin = 60; DexMax = 60; IntMin = 200; IntMax = 200;
		}
	}
}