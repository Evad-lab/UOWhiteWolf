//////////////////////
//Created by KyleMan//
//////////////////////

using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
    [CorpseName( "A Dead Thief" )]
    public class LizardThief : BaseCreature
    {
    		[Constructable] 
    		public LizardThief() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
    		{
				 Name = "Egg Napper";
				 Body = Utility.RandomList( 35, 36 );
				 BaseSoundID = 417;
				 
				 SetStr( 280, 360 );
				 SetDex( 150, 200 );
				 SetInt( 200, 250 );
				 
				 SetHits( 350, 600 );
				 
				 SetDamage( 15, 20 );
				 
				 SetDamageType( ResistanceType.Physical, 70 );
				 SetDamageType( ResistanceType.Cold, 20 );
				 SetDamageType( ResistanceType.Fire, 30 );
				 
				 SetResistance( ResistanceType.Physical, 45, 60 );
				 SetResistance( ResistanceType.Energy, 35, 60 );
				 SetResistance( ResistanceType.Poison, 55, 60 );
				 SetResistance( ResistanceType.Cold, 55, 60 );
				 SetResistance( ResistanceType.Fire, 35, 60 );
				 
				 SetSkill( SkillName.Wrestling, 95.1, 100.0 );
				 SetSkill( SkillName.Anatomy, 95.1, 100.0 );
				 SetSkill( SkillName.MagicResist, 65.1, 80.0 );
				 SetSkill( SkillName.Swords, 95.1, 100.0 );
				 SetSkill( SkillName.Tactics, 95.1, 100.0 );
				 SetSkill( SkillName.Parry, 65.1, 80.0 );
				 SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
				 Fame = 20000;
				 Karma = -20000;
				 
				 VirtualArmor = 25;
				 
				 switch ( Utility.Random( 5 ) )
				 {
				 	//case 0: PackItem( new NobleSword() ); //break;
				 	case 0: PackItem( new StevesRobe() ); break;
					case 1: PackItem( new CrocEgg() ); break;
				 }
				 
			 	 //PackSlayer();
			 	 PackItem( new Gold( 500) );
			 	 switch ( Utility.Random( 8 ) )
                                 {
                                   case 0: PackItem( new StevesShirt() ); break;
                                 }
                                  
			}
			 
			public override void GenerateLoot()
			{
			 	AddLoot( LootPack.FilthyRich, 2 );
			}
			public override int Meat{ get{ return 2; } }
		    public override int Hides{ get{ return 25; } }
		    public override HideType HideType{ get{ return HideType.Spined; } }
			
			public LizardThief( Serial serial ) : base( serial )
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
				 				 
				 				 				 				 				     				