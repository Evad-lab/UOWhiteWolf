using System;

namespace Server.Items 
{ 
    public class MiscResStarterBag : Bag 
    { 

        [Constructable] 
        public MiscResStarterBag() 
        { 
			this.Name = "Miscellaneous Resources Starter Bag";
			this.Hue = 110;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Feather));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Cloth));
        }

        public MiscResStarterBag(Serial serial)
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