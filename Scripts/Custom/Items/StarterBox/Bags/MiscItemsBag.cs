using System;
using Xanthos.Evo;
using Xanthos.ShrinkSystem;

namespace Server.Items 
{ 
    public class MiscItemsBag : Bag 
    { 

        [Constructable] 
        public MiscItemsBag() 
        { 
			Name = "Miscellaneous Items Starter Bag";
			Hue = 150;
			//this.DropItem(new HousePlacementTool());
			//this.DropItem(new BankCheck(100000));
			DropItem(new SquireContract());
			DropItem(new PetLeash());
			DropItem(new PetSlotDeed());
			DropItem(new StarterSash());
			//this.DropItem(new SkillBall5x100());
			//this.DropItem(new StatBall());
			DropItem(new TentDeed());
	
        }

        public MiscItemsBag(Serial serial)
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