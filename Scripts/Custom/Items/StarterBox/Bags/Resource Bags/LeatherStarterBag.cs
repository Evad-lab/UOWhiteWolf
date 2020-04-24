using System;

namespace Server.Items 
{ 
    public class LeatherStarterBag : Bag 
    { 

        [Constructable] 
        public LeatherStarterBag() 
        { 
			this.Name = "Leather Starter Bag";
			this.Hue = 8;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Leather));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.SpinedLeather));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.HornedLeather));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.BarbedLeather));
        }

        public LeatherStarterBag(Serial serial)
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