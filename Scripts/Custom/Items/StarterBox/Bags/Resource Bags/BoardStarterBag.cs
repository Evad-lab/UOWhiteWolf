using System;

namespace Server.Items 
{ 
    public class BoardStarterBag : Bag 
    { 

        [Constructable] 
        public BoardStarterBag() 
        { 
			this.Name = "Board Starter Bag";
			this.Hue = 50;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Board));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.OakBoard));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.AshBoard));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.YewBoard));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.HeartWoodBoard));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.BloodWoodBoard));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.FrostWoodBoard));
        }

        public BoardStarterBag(Serial serial)
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