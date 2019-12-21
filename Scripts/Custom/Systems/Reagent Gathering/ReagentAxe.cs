//Created by Lord Greywolf

using System;
using Server.Items;
using Server.Network;
using Server.Engines.Harvest;

namespace Server.Items
{
   [FlipableAttribute(0x13E4, 0x13E3)]
   public class ReagentAxe : BaseAxe
   {
     public override HarvestSystem HarvestSystem { get { return ReagentGathering.System; } }

     public override int AosStrengthReq{ get{ return 50; } }
     public override int AosMinDamage{ get{ return 8; } }
     public override int AosMaxDamage{ get{ return 12; } }
     public override int AosSpeed{ get{ return 35; } }

     public override int OldStrengthReq{ get{ return 25; } }
     public override int OldMinDamage{ get{ return 1; } }
     public override int OldMaxDamage{ get{ return 15; } }
     public override int OldSpeed{ get{ return 35; } }

     public override int InitMinHits{ get{ return 31; } }
     public override int InitMaxHits{ get{ return 60; } }

     public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Slash1H; } }

     [Constructable]
     public ReagentAxe() : base(0x13E4)
     {
       Name = "Reagent Gathering Axe";
       Hue = 64;
       Weight = 3.0;
       UsesRemaining = 100;
       ShowUsesRemaining = true;
     }

     public ReagentAxe(Serial serial) : base(serial)
     {
     }

     public override void Serialize( GenericWriter writer )
     {
       base.Serialize( writer );
       writer.Write( (int) 0 ); // version
     }

     public override void Deserialize( GenericReader reader )
     {
       base.Deserialize( reader );
       int version = reader.ReadInt();
       ShowUsesRemaining = true;
     }
   }
}

