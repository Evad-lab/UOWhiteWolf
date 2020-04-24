using System;

namespace Server.Items 
{ 
    public class StarterBox : GiftBox 
    { 

        [Constructable] 
        public StarterBox() 
        { 
			this.Name = "Welcome Pack!";
			this.Hue = 373;
			this.DropItem(new MiscItemsBag());
			this.DropItem(new ResourceStarterBag());
			this.DropItem(new RunicStarterBag());
        }

        public StarterBox(Serial serial)
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