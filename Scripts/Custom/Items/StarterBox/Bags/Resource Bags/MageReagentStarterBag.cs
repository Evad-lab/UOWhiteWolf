using System;

namespace Server.Items 
{ 
    public class MageReagentStarterBag : Bag 
    { 

        [Constructable] 
        public MageReagentStarterBag() 
        { 
			this.Name = "Magery Reagent Starter Bag";
			this.Hue = 130;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.BlackPearl));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Bloodmoss));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Garlic));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.Ginseng));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.MandrakeRoot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.SulfurousAsh));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.Nightshade));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.SpidersSilk));
        }

        public MageReagentStarterBag(Serial serial)
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