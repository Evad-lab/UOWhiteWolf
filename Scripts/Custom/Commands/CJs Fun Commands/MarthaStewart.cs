using System;
using System.Collections;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "an evil bitch corpse" )]
	public class MarthaStewart : BaseCreature
	{

		private Mobile m_ToKill;
		[Constructable]
		public MarthaStewart( Mobile m ) : base( AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			m_ToKill = m;
			Name = "Martha Stewart";
			Title = "the Hermit";
			Body = 401;
			this.Female = true;
			this.Hue = 1037;
			HairItemID = 8252;

			SetStr( 100 );
			SetDex( 100 );
			SetInt( 100 );

			SetMana( 300 );
			SetHits( 100000 );

			SetDamage( 450, 650 );

			SetDamageType( ResistanceType.Physical, 60 );

			SetResistance( ResistanceType.Physical, 60 );
			SetResistance( ResistanceType.Fire, 60 );
			SetResistance( ResistanceType.Cold, 60 );
			SetResistance( ResistanceType.Poison, 60 );
			SetResistance( ResistanceType.Energy, 60 );

			SetSkill( SkillName.MagicResist, 120.0 );
			SetSkill( SkillName.Tactics, 120.0 );
			SetSkill( SkillName.Macing, 120.0 );
			SetSkill( SkillName.Anatomy, 120.0 );
		    SetSkill(SkillName.DetectHidden, 1000.00);

			AddItem( new OrnateAxe() );
			AddItem( new FancyShirt( 1634 ));
			AddItem( new Skirt( 1810 ));
			AddItem( new Shoes( 1818 ));

			Fame = 5000;
			Karma = -5000;

			VirtualArmor = 40;
		}

		public override void OnThink()
		{
			if ( this.m_ToKill != null )
			{
				if ( this.m_ToKill.InRange( this.Location, 10 ))
				{}
				else
					this.MoveToWorld( m_ToKill.Location, m_ToKill.Map );
				if ( this.Combatant == null )
					this.Combatant = this.m_ToKill;
				if ( this.Frozen = true )
					this.Frozen = false;
			}
			else
				this.Delete();
		}

		public override bool OnBeforeDeath()
		{
			if ( this.m_ToKill != null )
			{
				MarthaStewart martha = new MarthaStewart( this.m_ToKill );
				this.CantWalk = true;
				this.Hidden = true;
				martha.MoveToWorld( this.Location, this.Map );
				int chance = Utility.Random( 1, 100 );
				if ( chance <= 20 )
					martha.Say( "I catnap now and then, but I think while I nap, so it's not a waste of time." );
				else if ( chance <= 40 )
					martha.Say( "I invented 'It's a good thing' before you were even born." );
				else if ( chance <= 60 )
					martha.Say( "I want you to know that I am innocent - and that I will fight to clear my name." );
				else if ( chance <= 80 )
					martha.Say( "I was married for 30 years. Isn't that enough? I've had my share of dirty underwear on the floor." );
				else
					martha.Say( "Without an open-minded mind, you can never be a great success." );
				this.Delete();
			}

			return base.OnBeforeDeath();
		}

		public override int GetAngerSound()
		{
			return 372;
		}

		public override int GetIdleSound()
		{
			return 1150;
		}

		public override int GetAttackSound()
		{
			return 374;
		}

		public override int GetHurtSound()
		{
			return 375;
		}

		public override int GetDeathSound()
		{
			return 376;
		}

		public override bool AlwaysMurderer{ get{ return true; }}

		public override void GenerateLoot()
		{
		}

		public MarthaStewart( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( (Mobile) m_ToKill );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			m_ToKill = reader.ReadMobile();
		}
	}
}