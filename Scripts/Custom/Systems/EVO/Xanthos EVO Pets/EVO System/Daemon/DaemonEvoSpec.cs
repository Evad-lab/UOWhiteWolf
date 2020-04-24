using System;
using Server;

namespace Xanthos.Evo
{
	public sealed class RaelisDaemonSpec : BaseEvoSpec
	{
		// This class implements a singleton pattern; meaning that no matter how many times the
		// Instance attribute is used, there will only ever be one of these created in the entire system.
		// Copy this template and give it a new name.  Assign all of the data members of the EvoSpec
		// base class in the constructor.  Your subclass must not be abstract.
		// Never call new on this class, use the Instance attribute to get the instance instead.

		RaelisDaemonSpec()
		{
			m_Tamable = true;
			m_MinTamingToHatch = 99.9;
			m_PercentFemaleChance = 0.02;	// Made small to limit access to eggs.
			m_GuardianEggOrDeedChance = .01;
			m_AlwaysHappy = true;
			m_ProducesYoung = true;
			m_PregnancyTerm = 0.10;
			m_AbsoluteStatValues = false;
			m_MaxEvoResistance = 100;
			m_MaxTrainingStage = 7;
			m_CanAttackPlayers = false;

			m_RandomHues = new int[] { 1157, 1175, 1172, 1170, 319, 130, 573, 285, 133, 432, 149, 622, 204, 29, 55, 745, 987, 514, 42, 17, 61, 80 };

			m_Skills = new SkillName[7] { SkillName.Magery, SkillName.EvalInt, SkillName.Meditation, SkillName.MagicResist,
										  SkillName.Tactics, SkillName.Wrestling, SkillName.Anatomy };
			m_MinSkillValues = new int[7] { 50, 50, 50, 15, 19, 19, 19 };
			m_MaxSkillValues = new int[7] { 120, 120, 110, 110, 100, 100, 100 };

			m_Stages = new BaseEvoStage[] { new RaelisDaemonStageOne(), new RaelisDaemonStageTwo(),
											  new RaelisDaemonStageThree(), new RaelisDaemonStageFour(),
											  new RaelisDaemonStageFive(), new RaelisDaemonStageSix(),
											  new RaelisDaemonStageSeven() };
		}

		// These next 2 lines facilitate the singleton pattern.  In your subclass only change the
		// BaseEvoSpec class name to your subclass of BaseEvoSpec class name and uncomment both lines.
		public static RaelisDaemonSpec Instance { get { return Nested.instance; } }
		class Nested { static Nested() { } internal static readonly RaelisDaemonSpec instance = new RaelisDaemonSpec();}
	}	

	// Define a subclass of BaseEvoStage for each stage in your creature and place them in the
	// array in your subclass of BaseEvoSpec.  See the example classes for how to do this.
	// Your subclass must not be abstract.

	public class RaelisDaemonStageOne : BaseEvoStage
	{
		public RaelisDaemonStageOne()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 25000; EpMinDivisor = 10; EpMaxDivisor = 5; DustMultiplier = 20;
			BaseSoundID = 422;
			BodyValue = 74; ControlSlots = 2; MinTameSkill = 99.9; VirtualArmor = 30;
//			Hue = Evo.Flags.kRandomHueFlag;

			DamagesTypes = new ResistanceType[1] { ResistanceType.Physical };
			MinDamages = new int[1] { 100 };
			MaxDamages = new int[1] { 100 };

			ResistanceTypes = new ResistanceType[1] { ResistanceType.Physical };
			MinResistances = new int[1] { 15 };
			MaxResistances = new int[1] { 15 };

			DamageMin = 11; DamageMax = 17; HitsMin = 200; HitsMax = 250;
			StrMin = 296; StrMax = 325; DexMin = 56; DexMax = 75; IntMin = 76; IntMax = 96;
		}
	}

	public class RaelisDaemonStageTwo : BaseEvoStage
	{
		public RaelisDaemonStageTwo()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 75000; EpMinDivisor = 20; EpMaxDivisor = 10; DustMultiplier = 20;
			BaseSoundID = 0x174;
			BodyValue = 130; ControlSlots = 2; VirtualArmor = 40;
		
			DamagesTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
													ResistanceType.Poison, ResistanceType.Energy };
			MinDamages = new int[5] { 100, 25, 25, 25, 25 };
			MaxDamages = new int[5] { 100, 25, 25, 25, 25 };

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 20, 20, 20, 20, 20 };
			MaxResistances = new int[5] { 20, 20, 20, 20, 20 };

			DamageMin = 1; DamageMax = 1; HitsMin= 500; HitsMax = 500;
			StrMin = 200; StrMax = 200; DexMin = 20; DexMax = 20; IntMin = 30; IntMax = 30;
		}
	}

	public class RaelisDaemonStageThree : BaseEvoStage
	{
		public RaelisDaemonStageThree()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 175000; EpMinDivisor = 30; EpMaxDivisor = 20; DustMultiplier = 20;
			BaseSoundID = 0x174;
			BodyValue = 0x2F2; ControlSlots = 2; VirtualArmor = 50;
		
			DamagesTypes = null;
			MinDamages = null;
			MaxDamages = null;

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 40, 40, 40, 40, 40 };
			MaxResistances = new int[5] { 40, 40, 40, 40, 40 };

			DamageMin = 1; DamageMax = 1; HitsMin= 100; HitsMax = 100;
			StrMin = 100; StrMax = 100; DexMin = 10; DexMax = 10; IntMin = 20; IntMax = 20;
		}
	}

	public class RaelisDaemonStageFour : BaseEvoStage
	{
		public RaelisDaemonStageFour()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 375000; EpMinDivisor = 50; EpMaxDivisor = 40; DustMultiplier = 20;
			BaseSoundID = 0x174;
			BodyValue = 0x2F3; ControlSlots = 3; MinTameSkill = 119.9; VirtualArmor = 60;
		
			DamagesTypes = null;
			MinDamages = null;
			MaxDamages = null;

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 60, 60, 60, 60, 60 };
			MaxResistances = new int[5] { 60, 60, 60, 60, 60 };	

			DamageMin = 1; DamageMax = 1; HitsMin= 100; HitsMax = 100;
			StrMin = 100; StrMax = 100; DexMin = 10; DexMax = 10; IntMin = 120; IntMax = 120;
		}
	}

	public class RaelisDaemonStageFive : BaseEvoStage
	{
		public RaelisDaemonStageFive()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 775000; EpMinDivisor = 160; EpMaxDivisor = 40; DustMultiplier = 20;
			BaseSoundID = 357;
			BodyValue = 9; ControlSlots = 3; VirtualArmor = 70;
		
			DamagesTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
													 ResistanceType.Poison, ResistanceType.Energy };
			MinDamages = new int[5] { 100, 50, 50, 50, 50 };
			MaxDamages = new int[5] { 100, 50, 50, 50, 50 };

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 70, 70, 70, 70, 70 };
			MaxResistances = new int[5] { 70, 70, 70, 70, 70 };	

			DamageMin = 5; DamageMax = 5; HitsMin= 100; HitsMax = 100;
			StrMin = 100; StrMax = 100; DexMin = 20; DexMax = 20; IntMin = 120; IntMax = 120;
		}
	}

	public class RaelisDaemonStageSix : BaseEvoStage
	{
		public RaelisDaemonStageSix()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 1500000; EpMinDivisor = 540; EpMaxDivisor = 480; DustMultiplier = 20;
			BaseSoundID = 357;
			BodyValue = 40; ControlSlots = 4; VirtualArmor = 170;
		
			DamagesTypes = null;
			MinDamages = null;
			MaxDamages = null;

			ResistanceTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
														ResistanceType.Poison, ResistanceType.Energy };
			MinResistances = new int[5] { 75, 75, 75, 75, 75 };
			MaxResistances = new int[5] { 90, 90, 90, 90, 90 };	

			DamageMin = 5; DamageMax = 5; HitsMin= 100; HitsMax = 100;
			StrMin = 100; StrMax = 100; DexMin = 20; DexMax = 20; IntMin = 120; IntMax = 120;
		}
	}

	public class RaelisDaemonStageSeven : BaseEvoStage
	{
		public RaelisDaemonStageSeven()
		{
			Title = "The Ancient Daemon";
			EvolutionMessage = "has evolved to its highest form";
			NextEpThreshold = 0; EpMinDivisor = 740; EpMaxDivisor = 660; DustMultiplier = 20;
			BaseSoundID = 0x48D;
			BodyValue = 308; ControlSlots = 4; VirtualArmor = 270;
		
			DamagesTypes = new ResistanceType[5] { ResistanceType.Physical, ResistanceType.Fire, ResistanceType.Cold,
													 ResistanceType.Poison, ResistanceType.Energy };
			MinDamages = new int[5] { 100, 75, 75, 75, 75 };
			MaxDamages = new int[5] { 100, 75, 75, 75, 75 };

			ResistanceTypes = null;
			MinResistances = null;
			MaxResistances = null;	

			DamageMin = 15; DamageMax = 15; HitsMin= 1350; HitsMax = 1400;
			StrMin = 125; StrMax = 125; DexMin = 125; DexMax = 35; IntMin = 125; IntMax = 125;
		}
	}
}