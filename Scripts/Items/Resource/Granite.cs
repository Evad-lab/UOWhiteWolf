using System;

namespace Server.Items
{
    public abstract class BaseGranite : Item, ICommodity
    {
        private CraftResource m_Resource;
        public BaseGranite(CraftResource resource)
            : base(0x1779)
        {
            Hue = CraftResources.GetHue(resource);
            Stackable = Core.ML;

            m_Resource = resource;
        }

        public BaseGranite(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }

        [CommandProperty(AccessLevel.GameMaster)]
        public CraftResource Resource
        {
            get
            {
                return m_Resource;
            }
            set
            {
                m_Resource = value;
                InvalidateProperties();
            }
        }
        public override double DefaultWeight
        {
            get
            {
                return Core.ML ? 1.0 : 10.0;
            }// Pub 57
        }
        public override int LabelNumber
        {
            get
            {
                return 1044607;
            }
        }// high quality granite
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            writer.Write((int)m_Resource);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 1:
                case 0:
                    {
                        m_Resource = (CraftResource)reader.ReadInt();
                        break;
                    }
            }
			
            if (version < 1)
                Stackable = Core.ML;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (!CraftResources.IsStandard(m_Resource))
            {
                int num = CraftResources.GetLocalizationNumber(m_Resource);

                if (num > 0)
                    list.Add(num);
                else
                    list.Add(CraftResources.GetName(m_Resource));
            }
        }
    }

    public class Granite : BaseGranite
    {
        [Constructable]
        public Granite()
            : this(1)
        {
        }

        [Constructable]
        public Granite(int amount)
            : base(CraftResource.Iron)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Granite";
			//daat99 OWLTR - granite name
        }

        public Granite(Serial serial)
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

    public class DullCopperGranite : BaseGranite
    {
        [Constructable]
        public DullCopperGranite()
            : this(1)
        {
        }

        [Constructable]
        public DullCopperGranite(int amount)
            : base(CraftResource.DullCopper)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Dull Copper Granite";
			//daat99 OWLTR - granite name
        }

        public DullCopperGranite(Serial serial)
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

    public class ShadowIronGranite : BaseGranite
    {
        [Constructable]
        public ShadowIronGranite()
            : this(1)
        {
        }

        [Constructable]
        public ShadowIronGranite(int amount)
            : base(CraftResource.ShadowIron)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Shadow Iron Granite";
			//daat99 OWLTR - granite name
        }

        public ShadowIronGranite(Serial serial)
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

    public class CopperGranite : BaseGranite
    {
        [Constructable]
        public CopperGranite()
            : this(1)
        {
        }

        [Constructable]
        public CopperGranite(int amount)
            : base(CraftResource.Copper)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Copper Granite";
			//daat99 OWLTR - granite name
        }

        public CopperGranite(Serial serial)
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

    public class BronzeGranite : BaseGranite
    {
        [Constructable]
        public BronzeGranite()
            : this(1)
        {
        }

        [Constructable]
        public BronzeGranite(int amount)
            : base(CraftResource.Bronze)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Bronze Granite";
			//daat99 OWLTR - granite name
        }

        public BronzeGranite(Serial serial)
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

    public class GoldGranite : BaseGranite
    {
        [Constructable]
        public GoldGranite()
            : this(1)
        {
        }

        [Constructable]
        public GoldGranite(int amount)
            : base(CraftResource.Gold)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Gold Granite";
			//daat99 OWLTR - granite name
        }

        public GoldGranite(Serial serial)
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

    public class AgapiteGranite : BaseGranite
    {
        [Constructable]
        public AgapiteGranite()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteGranite(int amount)
            : base(CraftResource.Agapite)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Agapite Granite";
			//daat99 OWLTR - granite name
        }

        public AgapiteGranite(Serial serial)
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

    public class VeriteGranite : BaseGranite
    {
        [Constructable]
        public VeriteGranite()
            : this(1)
        {
        }

        [Constructable]
        public VeriteGranite(int amount)
            : base(CraftResource.Verite)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Verite Granite";
			//daat99 OWLTR - granite name
        }

        public VeriteGranite(Serial serial)
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

    public class ValoriteGranite : BaseGranite
    {
        [Constructable]
        public ValoriteGranite()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteGranite(int amount)
            : base(CraftResource.Valorite)
        {
            if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
			//daat99 OWLTR - granite name
			Name = "Valorite Granite";
			//daat99 OWLTR - granite name
        }

        public ValoriteGranite(Serial serial)
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
	
	//daat99 OWLTR - start
	public class BlazeGranite : BaseGranite
    {
		[Constructable]
        public BlazeGranite()
            : this(1)
        {
        }
		
        [Constructable]
        public BlazeGranite(int amount)
            : base(CraftResource.Blaze)
        {
			if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
            Name = "Blaze Granite"; //daat99 OWLTR - granite name
        }

        public BlazeGranite(Serial serial)
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

    public class IceGranite : BaseGranite
    {
		[Constructable]
        public IceGranite()
            : this(1)
        {
        }
		
        [Constructable]
        public IceGranite(int amount)
            : base(CraftResource.Ice)
        {
			if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
            Name = "Ice Granite"; //daat99 OWLTR - granite name
        }

        public IceGranite(Serial serial)
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

    public class ToxicGranite : BaseGranite
    {
		[Constructable]
        public ToxicGranite()
            : this(1)
        {
        }
		
        [Constructable]
        public ToxicGranite(int amount)
            : base(CraftResource.Toxic)
        {
			if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
            Name = "Toxic Granite"; //daat99 OWLTR - granite name
        }

        public ToxicGranite(Serial serial)
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

    public class ElectrumGranite : BaseGranite
    {
		[Constructable]
        public ElectrumGranite()
            : this(1)
        {
        }
		
        [Constructable]
        public ElectrumGranite(int amount)
            : base(CraftResource.Electrum)
        {
			if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
            Name = "Electrum Granite"; //daat99 OWLTR - granite name
        }

        public ElectrumGranite(Serial serial)
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

    public class PlatinumGranite : BaseGranite
    {
		[Constructable]
        public PlatinumGranite()
            : this(1)
        {
        }
		
        [Constructable]
        public PlatinumGranite(int amount)
            : base(CraftResource.Platinum)
        {
			if (Stackable)
                Amount = amount;
            else
                Amount = 1;
			
            Name = "Platinum Granite"; //daat99 OWLTR - granite name
        }

        public PlatinumGranite(Serial serial)
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
	//daat99 OWLTR - end
}
