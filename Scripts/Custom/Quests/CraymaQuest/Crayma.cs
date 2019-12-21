//////////////////////
//Created by KyleMan//
//////////////////////

using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
    [CorpseName( "a dead crayma" )]
    public class Crayma : BaseCreature
    {
    		[Constructable] 
    		public Crayma() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
    		{
				 Name = "Crayma";
				 Body = 551;
				 BaseSoundID = 451;
				 
				 SetStr( 250, 360 );
				 SetDex( 100, 150 );
				 SetInt( 200, 250 );
				 
				 SetHits( 5000, 6500 );
				 
				 SetDamage( 15, 25 );
				 
				 SetDamageType( ResistanceType.Physical, 100 );
				 //SetDamageType( ResistanceType.Cold, 10 );
				 //SetDamageType( ResistanceType.Fire, 10 );
				 
				 SetResistance( ResistanceType.Physical, 25, 45 );
				 SetResistance( ResistanceType.Energy, 25, 45 );
				 SetResistance( ResistanceType.Poison, 55, 60 );
				 SetResistance( ResistanceType.Cold, 55, 60 );
				 SetResistance( ResistanceType.Fire, 55, 60 );
				 
				 SetSkill( SkillName.Wrestling, 95.1, 100.0 );
				 SetSkill( SkillName.Anatomy, 95.1, 100.0 );
				 SetSkill( SkillName.MagicResist, 95.1, 100.0 );
				 SetSkill( SkillName.Swords, 95.1, 100.0 );
				 SetSkill( SkillName.Tactics, 95.1, 100.0 );
				 SetSkill( SkillName.Parry, 95.1, 100.0 );
				 SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
				 Fame = 20000;
				 Karma = -20000;
				 
				 VirtualArmor = 65;
				 
				 switch ( Utility.Random( 20 ) )
				 {
				 	case 0: PackItem( new NobleSword() ); break;
				 	case 1: PackItem( new HoodRobe() ); break;
					case 2: PackItem( new DeathAxe() ); break;
				 }
				 
			 	 //PackSlayer()
			 	 switch ( Utility.Random( 5 ) )
                                 {
                                   case 0: PackItem( new CraymaCrap() ); break;
                                 }
                                  
			}
			 
			public override void GenerateLoot()
			{
			 	AddLoot( LootPack.FilthyRich, 2 );
			}
			
			public Crayma( Serial serial ) : base( serial )
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
				 				 
				 				 				 				 				     				