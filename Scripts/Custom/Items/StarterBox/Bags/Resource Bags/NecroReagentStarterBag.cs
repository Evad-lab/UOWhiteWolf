using System;

namespace Server.Items 
{ 
    public class NecroReagentStarterBag : Bag 
    { 
        [Constructable] 
        public NecroReagentStarterBag() 
        { 
			this.Name = "Necromancy Reagent Starter Bag";
			this.Hue = 90;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.BatWing));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.DaemonBlood));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.GraveDust));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.NoxCrystal));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.PigIron));
        }

        public NecroReagentStarterBag(Serial serial)
            : base(serial)
        { 
        }

        public override void Serialize(GenericWriter writer) 
        { 
            base.Serialize(writer); 

            writer.Write((int)0); // version 
        }

        public override void Deserialize(GenericReader reader) 
        { 
            base.Deserialize(reader); 

            int version = reader.ReadInt(); 
        }
    }
}