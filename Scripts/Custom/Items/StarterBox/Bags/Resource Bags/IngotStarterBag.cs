using System;

namespace Server.Items 
{ 
    public class IngotStarterBag : Bag 
    { 

        [Constructable] 
        public IngotStarterBag() 
        { 
			this.Name = "Ingot Starter Bag";
			this.Hue = 18;
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.IronIngot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.DullCopperIngot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.ShadowIronIngot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.CopperIngot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.BronzeIngot));
			this.DropItem(new ResourceDeed(5000, ResourceDeedType.GoldIngot));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.AgapiteIngot));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.VeriteIngot));
			this.DropItem(new ResourceDeed(2500, ResourceDeedType.ValoriteIngot));
        }

        public IngotStarterBag(Serial serial)
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