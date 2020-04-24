using System;
using Server;

namespace Xanthos.Evo
{
	public sealed class FerretSpec : BaseEvoSpec
	{
		// This class implements a singleton pattern; meaning that no matter how many times the
		// Instance attribute is used, there will only ever be one of these created in the entire system.
		// Copy this template and give it a new name.  Assign all of the data members of the EvoSpec
		// base class in the constructor.  Your subclass must not be abstract.
		// Never call new on this class, use the Instance attribute to get the instance instead.

		FerretSpec()
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
			m_MaxTrainingStage = 8;
			m_CanAttackPlayers = false;

			m_RandomHues = new int[] { 1157, 1175, 1172, 1170, 2703, 2473, 2643, 1156, 2704, 2734, 2669, 2621, 2859, 2716, 2791, 2927, 2974, 1161, 2717, 2652, 2821, 2818, 2730, 2670, 2678, 2630, 2641, 2644, 2592, 2543, 2526, 2338, 2339, 1793, 1980, 1983 };

			m_Skills = new SkillName[7] { SkillName.Magery, SkillName.EvalInt, SkillName.Meditation, SkillName.MagicResist,
										  SkillName.Tactics, SkillName.Wrestling, SkillName.Anatomy };
			m_MinSkillValues = new int[7] { 50, 50, 50, 15, 19, 19, 19 };
			m_MaxSkillValues = new int[7] { 120, 120, 110, 110, 100, 100, 100 };

			m_Stages = new BaseEvoStage[] { new FerretStageOne(), new FerretStageTwo(),
											  new FerretStageThree(), new FerretStageFour(),
											  new FerretStageFive(), new FerretStageSix(),
											  new FerretStageSeven() };
		}

		// These next 2 lines facilitate the singleton pattern.  In your subclass only change the
		// BaseEvoSpec class name to your subclass of BaseEvoSpec class name and uncomment both lines.
		public static FerretSpec Instance { get { return Nested.instance; } }
		class Nested { static Nested() { } internal static readonly FerretSpec instance = new FerretSpec();}
	}	

	// Define a subclass of BaseEvoStage for each stage in your creature and place them in the
	// array in your subclass of BaseEvoSpec.  See the example classes for how to do this.
	// Your subclass must not be abstract.

	public class FerretStageOne : BaseEvoStage
	{
		public FerretStageOne()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 75000; EpMinDivisor = 10; EpMaxDivisor = 5; DustMultiplier = 20;
			BaseSoundID = 0xCC;
			BodyValue = 238; ControlSlots = 2; MinTameSkill = 99.9; VirtualArmor = 30;
			Hue = Evo.Flags.kRandomHueFlag;

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

	public class FerretStageTwo : BaseEvoStage
	{
		public FerretStageTwo()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 150000; EpMinDivisor = 20; EpMaxDivisor = 10; DustMultiplier = 20;
			BaseSoundID = 0x1B;
			BodyValue = 6; VirtualArmor = 40;
            ControlSlots = 2;
		
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

	public class FerretStageThree : BaseEvoStage
	{
		public FerretStageThree()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 300000; EpMinDivisor = 30; EpMaxDivisor = 20; DustMultiplier = 20;
			BaseSoundID = 0xD6;
			BodyValue = 207; VirtualArmor = 50;
            ControlSlots = 2;
		
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

	public class FerretStageFour : BaseEvoStage
	{
		public FerretStageFour()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 6000000; EpMinDivisor = 50; EpMaxDivisor = 40; DustMultiplier = 20;
			BaseSoundID = 69;
			BodyValue = 201; ControlSlots = 3; MinTameSkill = 119.9; VirtualArmor = 60;
		
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

	public class FerretStageFive : BaseEvoStage
	{
		public FerretStageFive()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 1000000; EpMinDivisor = 160; EpMaxDivisor = 40; DustMultiplier = 20;
			BaseSoundID = 133;
			BodyValue = 217; VirtualArmor = 70;
            ControlSlots = 3;
		
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

	public class FerretStageSix : BaseEvoStage
	{
		public FerretStageSix()
		{
			EvolutionMessage = "has evolved";
			NextEpThreshold = 15000000; EpMinDivisor = 540; EpMaxDivisor = 480; DustMultiplier = 20;
			BaseSoundID = 392;
			BodyValue = 217; VirtualArmor = 170;
            ControlSlots = 4;
		
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

	public class FerretStageSeven : BaseEvoStage
	{
		public FerretStageSeven()
		{
			Title = "The Ancient Ferret";
			EvolutionMessage = "has evolved to its highest form";
			NextEpThreshold = 0; EpMinDivisor = 740; EpMaxDivisor = 660; DustMultiplier = 20;
			BaseSoundID = 0xCC;
			BodyValue = 279; ControlSlots = 4; VirtualArmor = 270;
		
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