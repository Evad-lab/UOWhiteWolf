using System;

namespace Server.Items
{
    public abstract class BaseIngot : Item, ICommodity, IResource
    {
        protected virtual CraftResource DefaultResource { get { return CraftResource.Iron; } }

        private CraftResource m_Resource;
        public BaseIngot(CraftResource resource)
            : this(resource, 1)
        {
        }

        public BaseIngot(CraftResource resource, int amount)
            : base(0x1BF2)
        {
            Stackable = true;
            Amount = amount;
            Hue = CraftResources.GetHue(resource);

            m_Resource = resource;
        }

        public BaseIngot(Serial serial)
            : base(serial)
        {
        }

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
                return 0.1;
            }
        }
        public override int LabelNumber
        {
            get
            {
                if (m_Resource >= CraftResource.DullCopper && m_Resource <= CraftResource.Valorite)
                    return 1042684 + (int)(m_Resource - CraftResource.DullCopper);

                return 1042692;
            }
        }
        TextDefinition ICommodity.Description
        {
            get
            {
                return LabelNumber;
            }
        }
        bool ICommodity.IsDeedable
        {
            get
            {
                return true;
            }
        }
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
                case 2: // Reset from Resource System
                    m_Resource = DefaultResource;
                    reader.ReadString();
                    break;
                case 1:
                    {
                        m_Resource = (CraftResource)reader.ReadInt();
                        break;
                    }
                case 0:
                    {
                        OreInfo info;

                        switch ( reader.ReadInt() )
                        {
                            case 0:
                                info = OreInfo.Iron;
                                break;
                            case 1:
                                info = OreInfo.DullCopper;
                                break;
                            case 2:
                                info = OreInfo.ShadowIron;
                                break;
                            case 3:
                                info = OreInfo.Copper;
                                break;
                            case 4:
                                info = OreInfo.Bronze;
                                break;
                            case 5:
                                info = OreInfo.Gold;
                                break;
                            case 6:
                                info = OreInfo.Agapite;
                                break;
                            case 7:
                                info = OreInfo.Verite;
                                break;
                            case 8:
                                info = OreInfo.Valorite;
                                break;
							//daat99 OWLTR start - custom ores
                            case 9: info = OreInfo.Blaze; break;
                            case 10: info = OreInfo.Ice; break;
                            case 11: info = OreInfo.Toxic; break;
                            case 12: info = OreInfo.Electrum; break;
                            case 13: info = OreInfo.Platinum; break;
                            //daat99 OWLTR end - custom ores
                            default:
                                info = null;
                                break;
                        }

                        m_Resource = CraftResources.GetFromOreInfo(info);
                        break;
                    }
            }
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (Amount > 1)
                list.Add(1050039, "{0}\t#{1}", Amount, 1027154); // ~1_NUMBER~ ~2_ITEMNAME~
            else
                list.Add(1027154); // ingots
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class IronIngot : BaseIngot
    {
        [Constructable]
        public IronIngot()
            : this(1)
        {
        }

        [Constructable]
        public IronIngot(int amount)
            : base(CraftResource.Iron, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Iron Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public IronIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class DullCopperIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.DullCopper; } }

        [Constructable]
        public DullCopperIngot()
            : this(1)
        {
        }

        [Constructable]
        public DullCopperIngot(int amount)
            : base(CraftResource.DullCopper, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Dull Copper Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public DullCopperIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ShadowIronIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.ShadowIron; } }

        [Constructable]
        public ShadowIronIngot()
            : this(1)
        {
        }

        [Constructable]
        public ShadowIronIngot(int amount)
            : base(CraftResource.ShadowIron, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Shadow Iron Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public ShadowIronIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class CopperIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Copper; } }

        [Constructable]
        public CopperIngot()
            : this(1)
        {
        }

        [Constructable]
        public CopperIngot(int amount)
            : base(CraftResource.Copper, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Copper Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public CopperIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class BronzeIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Bronze; } }

        [Constructable]
        public BronzeIngot()
            : this(1)
        {
        }

        [Constructable]
        public BronzeIngot(int amount)
            : base(CraftResource.Bronze, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Bronze Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public BronzeIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class GoldIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Gold; } }

        [Constructable]
        public GoldIngot()
            : this(1)
        {
        }

        [Constructable]
        public GoldIngot(int amount)
            : base(CraftResource.Gold, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Golden Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public GoldIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class AgapiteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Agapite; } }

        [Constructable]
        public AgapiteIngot()
            : this(1)
        {
        }

        [Constructable]
        public AgapiteIngot(int amount)
            : base(CraftResource.Agapite, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Agapite Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public AgapiteIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class VeriteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Verite; } }

        [Constructable]
        public VeriteIngot()
            : this(1)
        {
        }

        [Constructable]
        public VeriteIngot(int amount)
            : base(CraftResource.Verite, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Verite Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public VeriteIngot(Serial serial)
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

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ValoriteIngot : BaseIngot
    {
        protected override CraftResource DefaultResource { get { return CraftResource.Valorite; } }

        [Constructable]
        public ValoriteIngot()
            : this(1)
        {
        }

        [Constructable]
        public ValoriteIngot(int amount)
            : base(CraftResource.Valorite, amount)
        {
			//daat99 OWLTR - resource name - start
			Name = "Valorite Ingots"; 
			//daat99 OWLTR - resource name - end
        }

        public ValoriteIngot(Serial serial)
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
	
	//daat99 - additional ingots - start
	[FlipableAttribute(0x1BF2, 0x1BEF)]
    public class BlazeIngot : BaseIngot
    {
        [Constructable]
        public BlazeIngot()
            : this(1)
        {
        }

        [Constructable]
        public BlazeIngot(int amount)
            : base(CraftResource.Blaze, amount)
        {
            Name = "Blaze Ingots"; //daat99 OWLTR - resource name
        }

        public BlazeIngot(Serial serial)
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
    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class IceIngot : BaseIngot
    {
        [Constructable]
        public IceIngot()
            : this(1)
        {
        }

        [Constructable]
        public IceIngot(int amount)
            : base(CraftResource.Ice, amount)
        {
            Name = "Ice Ingots"; //daat99 OWLTR - resource name
        }

        public IceIngot(Serial serial)
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
    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ToxicIngot : BaseIngot
    {
        [Constructable]
        public ToxicIngot()
            : this(1)
        {
        }

        [Constructable]
        public ToxicIngot(int amount)
            : base(CraftResource.Toxic, amount)
        {
            Name = "Toxic Ingots"; //daat99 OWLTR - resource name
        }

        public ToxicIngot(Serial serial)
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
    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class ElectrumIngot : BaseIngot
    {
        [Constructable]
        public ElectrumIngot()
            : this(1)
        {
        }

        [Constructable]
        public ElectrumIngot(int amount)
            : base(CraftResource.Electrum, amount)
        {
            Name = "Electrum Ingots"; //daat99 OWLTR - resource name
        }

        public ElectrumIngot(Serial serial)
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
    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class PlatinumIngot : BaseIngot
    {
        [Constructable]
        public PlatinumIngot()
            : this(1)
        {
        }

        [Constructable]
        public PlatinumIngot(int amount)
            : base(CraftResource.Platinum, amount)
        {
            Name = "Platinum Ingots"; //daat99 OWLTR - resource name
        }

        public PlatinumIngot(Serial serial)
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
	//daat99 - additional ingots - end
}