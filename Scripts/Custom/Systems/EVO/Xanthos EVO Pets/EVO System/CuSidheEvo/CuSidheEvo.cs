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
	[CorpseName( "a Cu Sidhe corpse" )]
	public class EvoCuSidhe : BaseEvoMount, IEvoCreature
	{
		public override BaseEvoSpec GetEvoSpec()
		{
			return CuSidheEvoSpec.Instance;
		}

		public override BaseEvoEgg GetEvoEgg()
		{
			return new CuSidheEvoEgg();
		}

		public override bool AddPointsOnDamage { get { return true; } }
		public override bool AddPointsOnMelee { get { return false; } }
		public override Type GetEvoDustType() { return typeof( CuSidheEvoDust ); }

		public override bool HasBreath { get{ return true; } }
		
		//UOWW = commented out on core upgrade for compatilibty with BaseCreature.cs
		//
		//public override bool CanHealOwner { get { return true; } }
		
		public override double HealChance { get { return 1.0; } }

		public EvoCuSidhe( string name ) : base( name, 277, 0x3E91 )
		{
			SetSpecialAbility(SpecialAbility.Heal);
		}

		public EvoCuSidhe( Serial serial ) : base( serial )
		{
		}

		public override WeaponAbility GetWeaponAbility()	
		{
			return WeaponAbility.BleedAttack;
		} 

		public override bool SubdueBeforeTame{ get{ return true; } } // Must be beaten into submission
		
		public override int GetAngerSound()
		{
			return 0x4FF;
		}

		public override int GetIdleSound()
		{
			return 0x4FE;
		}

		public override int GetAttackSound()
		{
			return 0x4FD;
		}

		public override int GetHurtSound()
		{
			return 0x500;
		}

		public override int GetDeathSound()
		{
			return 0x4FC;
		}
		
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write( (int)0 );			
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}