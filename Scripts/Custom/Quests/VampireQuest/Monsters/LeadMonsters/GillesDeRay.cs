/////////////////
///LostSinner///
///////////////
using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles 
{ 
	[CorpseName( "an Demonic corpse" )] 
	public class GillesDeRay : BaseCreature 
	{ 
		[Constructable] 
		public GillesDeRay() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Title = "Lord of Darkness";
			Name = ( "Gilles De Ray" );
			Body = 400;
			Hue = 1;  

			SetStr( 800, 950 );
			SetDex( 91, 115 );
			SetInt( 300, 320 );

			SetHits( 2820, 3225 );

			SetDamage( 20, 22 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 0, 1 );
			SetResistance( ResistanceType.Fire, 0, 1 );
			SetResistance( ResistanceType.Poison, 0, 1 );
			SetResistance( ResistanceType.Energy, 0, 1 );
			SetResistance( ResistanceType.Cold, 0, 1 );

			SetSkill( SkillName.EvalInt, 135.0, 100.0 );
			SetSkill( SkillName.Tactics, 125.1, 130.0 );
			SetSkill( SkillName.MagicResist, 75.0, 97.5 );
			SetSkill( SkillName.Wrestling, 100.2, 100.0 );
			SetSkill( SkillName.Meditation, 120.0);
			SetSkill( SkillName.Focus, 120.0);
			SetSkill( SkillName.Magery, 120.0, 140 );

			Fame = 2500;
			Karma = -2500;

			VirtualArmor = 70;
			
			VampireRobe robe = new VampireRobe();
			robe.Movable = false;
			robe.Hue = 1;
			AddItem(robe);
		}

		public override void GenerateLoot()
		{

			PackGold( 12575, 12700);
		}

		public override bool AlwaysMurderer{ get{ return true; } }

		public GillesDeRay( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
