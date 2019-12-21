// Golden thread for Scottie's Quest
// By GreyWolf
// 
// Created Oct 6, 2007

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
    [CorpseName( "Scottie's Wolf corpse" )]
    public class ScottiesWolf : BaseCreature
    {
        [Constructable]
        public ScottiesWolf() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
        {
            this.Name = "Scottie's Wolf";
            this.Hue = 2213;
            this.Body = 23;
            this.BaseSoundID = 229;

            this.SetStr( 280, 340 );
            this.SetDex( 180, 220 );
            this.SetInt( 200, 300 );
            this.SetHits( 800, 1200 );
            this.SetDamage( 15, 44 );
            this.SetDamageType( ResistanceType.Physical, 100 );
            this.SetResistance( ResistanceType.Physical, 75 );
            this.SetResistance( ResistanceType.Cold, 65 );
            this.SetResistance( ResistanceType.Fire, 42 );
            this.SetResistance( ResistanceType.Energy, 64 );
            this.SetResistance( ResistanceType.Poison, 63 );
            this.Fame = 35000;
            this.Karma = -35000;
            this.VirtualArmor = 25;
        }

        public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

            c.DropItem( new GoldenThread());
        }

        public ScottiesWolf(Serial serial) : base(serial)
        {
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
    }
}