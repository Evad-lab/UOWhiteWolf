
// Created by Script Creator
using System;
using Server.Items;

namespace Server.Mobiles
{
     [CorpseName( "Ganon's corpse" )]
     public class Ganon: BaseCreature
     {
         [Constructable]
		public Ganon () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.5, 0.7 ) 
         {
             Name = "Ganon";
             Body = 796;
             BaseSoundID = 609;
             SetStr( 850 );
             SetDex( 2300 );
             SetInt( 1300 );
             SetHits( 5000 );
             SetDamage( 35 );
             SetDamageType( ResistanceType.Physical, 5 );
             SetDamageType( ResistanceType.Fire, 5 );
             SetDamageType( ResistanceType.Cold, 5 );
             SetDamageType( ResistanceType.Energy, 5 );
             SetDamageType( ResistanceType.Poison, 80 );

             SetResistance( ResistanceType.Physical, 95);
             SetResistance( ResistanceType.Fire, 70);
             SetResistance( ResistanceType.Cold, 70 );
             SetResistance( ResistanceType.Energy, 70 );
             SetResistance( ResistanceType.Poison, 70 );

	SetSkill( SkillName.MagicResist, 40.1, 40.0 );
	SetSkill( SkillName.Tactics, 125.1, 135.0 );
	SetSkill( SkillName.Wrestling, 120.1, 145.0 );



             Fame = 15000;
             Karma = -15000;
             VirtualArmor = 10;
		
		PackItem( new GanonHead() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}


	        public override bool BardImmune{ get{ return true; } }
                public override bool AlwaysMurderer { get { return true; } }
		public override bool AutoDispel{ get{ return true; } }
        

		 public Ganon( Serial serial ) : base( serial )
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