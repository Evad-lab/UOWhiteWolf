using System;

namespace Server.Items 
{ 
    public class RunicStarterBag : Bag 
    { 
        [Constructable] 
        public RunicStarterBag() 
        { 
			this.Name = "Runic Tools Starter Bag";
			this.Hue = 170;
			this.DropItem(new RunicHammer(CraftResource.DullCopper, 75));
			this.DropItem(new RunicSewingKit(CraftResource.SpinedLeather, 50));
        }

        public RunicStarterBag(Serial serial)
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