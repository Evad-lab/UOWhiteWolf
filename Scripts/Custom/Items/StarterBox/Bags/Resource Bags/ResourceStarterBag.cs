using System;

namespace Server.Items 
{ 
    public class ResourceStarterBag : Bag 
    { 

        [Constructable] 
        public ResourceStarterBag() 
        { 
			this.Name = "Resource Starter Bag";
			this.Hue = 70;
			this.DropItem(new BoardStarterBag());
			this.DropItem(new IngotStarterBag());
			this.DropItem(new LeatherStarterBag());
			this.DropItem(new MageReagentStarterBag());
			this.DropItem(new MiscResStarterBag());
			this.DropItem(new NecroReagentStarterBag());

        }

        public ResourceStarterBag(Serial serial)
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