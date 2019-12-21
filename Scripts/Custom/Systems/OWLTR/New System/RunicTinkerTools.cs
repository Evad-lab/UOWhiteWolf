/*
 created by:
     /\            888                   888     .d8888b.   .d8888b.  
____/_ \____       888                   888    d88P  Y88b d88P  Y88b 
\  ___\ \  /       888                   888    888    888 888    888 
 \/ /  \/ /    .d88888  8888b.   8888b.  888888 Y88b. d888 Y88b. d888 
 / /\__/_/\   d88" 888     "88b     "88b 888     "Y888P888  "Y888P888 
/__\ \_____\  888  888 .d888888 .d888888 888           888        888 
    \  /      Y88b 888 888  888 888  888 Y88b.  Y88b  d88P Y88b  d88P 
     \/        "Y88888 "Y888888 "Y888888  "Y888  "Y8888P"   "Y8888P"  
*/
using System;
using Server.Engines.Craft;

namespace Server.Items
{
	[Flipable( 0x1EB8, 0x1EB9 )]
	public class RunicTinkerTools : BaseRunicTool
	{
		public override CraftSystem CraftSystem{ get{ return DefTinkering.CraftSystem; } }

		public override int LabelNumber { get { return 1044164; } }

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );

			if ( !CraftResources.IsStandard( Resource ) )
				list.Add( 1060662, "{0}\t{1}", "Resource"	, CraftResources.GetName( Resource ) );
		}

		[Constructable]
		public RunicTinkerTools( CraftResource resource ) : this( resource, 50 )
		{
		}

		[Constructable]
		public RunicTinkerTools( CraftResource resource, int uses ) : base( resource, uses, 0x1EB8 )
		{
			Name = "Runic Tinker's Tools";
			Weight = 1.0;
			Hue = CraftResources.GetHue( resource );
		}

		public RunicTinkerTools( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override Type GetCraftableType()
		{
			switch (Resource)
			{
				case CraftResource.DullCopper:
					return typeof(DullCopperRunicTinkerTools);
				case CraftResource.ShadowIron:
					return typeof(ShadowIronRunicTinkerTools);
				case CraftResource.Copper:
					return typeof(CopperRunicTinkerTools);
				case CraftResource.Bronze:
					return typeof(BronzeRunicTinkerTools);
				case CraftResource.Gold:
					return typeof(GoldRunicTinkerTools);
				case CraftResource.Agapite:
					return typeof(AgapiteRunicTinkerTools);
				case CraftResource.Verite:
					return typeof(VeriteRunicTinkerTools);
				case CraftResource.Valorite:
					return typeof(ValoriteRunicTinkerTools);
				case CraftResource.Blaze: 
					return typeof(BlazeRunicTinkerTools);
				case CraftResource.Ice:
					return typeof(IceRunicTinkerTools);
				case CraftResource.Toxic:
					return typeof(ToxicRunicTinkerTools);
				case CraftResource.Electrum:
					return typeof(ElectrumRunicTinkerTools);
				case CraftResource.Platinum:
					return typeof(PlatinumRunicTinkerTools);
				default:
					return null;
			}
		}
	}
	
	public class DullCopperRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public DullCopperRunicTinkerTools()
            : base(CraftResource.DullCopper)
        {
            Name = "DullCopper Runic Tinker's Tools";
        }
        public DullCopperRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class ShadowIronRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public ShadowIronRunicTinkerTools()
            : base(CraftResource.ShadowIron)
        {
            Name = "ShadowIron Runic Tinker's Tools";
        }
        public ShadowIronRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class CopperRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public CopperRunicTinkerTools()
            : base(CraftResource.Copper)
        {
            Name = "Copper Runic Tinker's Tools";
        }
        public CopperRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class BronzeRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public BronzeRunicTinkerTools()
            : base(CraftResource.Bronze)
        {
            Name = "Bronze Runic Tinker's Tools";
        }
        public BronzeRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class GoldRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public GoldRunicTinkerTools()
            : base(CraftResource.Gold)
        {
            Name = "Gold Runic Tinker's Tools";
        }
        public GoldRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class AgapiteRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public AgapiteRunicTinkerTools()
            : base(CraftResource.Agapite)
        {
            Name = "Agapite Runic Tinker's Tools";
        }
        public AgapiteRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class VeriteRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public VeriteRunicTinkerTools()
            : base(CraftResource.Verite)
        {
            Name = "Verite Runic Tinker's Tools";
        }
        public VeriteRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class ValoriteRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public ValoriteRunicTinkerTools()
            : base(CraftResource.Valorite)
        {
            Name = "Valorite Runic Tinker's Tools";
        }
        public ValoriteRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class BlazeRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public BlazeRunicTinkerTools()
            : base(CraftResource.Blaze)
        {
            Name = "Blaze Runic Tinker's Tools";
        }
        public BlazeRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class IceRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public IceRunicTinkerTools()
            : base(CraftResource.Ice)
        {
            Name = "Ice Runic Tinker's Tools";
        }
        public IceRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class ToxicRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public ToxicRunicTinkerTools()
            : base(CraftResource.Toxic)
        {
            Name = "Toxic Runic Tinker's Tools";
        }
        public ToxicRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class ElectrumRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public ElectrumRunicTinkerTools()
            : base(CraftResource.Electrum)
        {
            Name = "Electrum Runic Tinker's Tools";
        }
        public ElectrumRunicTinkerTools(Serial serial) : base(serial) { }

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
    public class PlatinumRunicTinkerTools : RunicTinkerTools
    {
        public override CraftSystem CraftSystem { get { return DefTinkering.CraftSystem; } }
        [Constructable]
        public PlatinumRunicTinkerTools()
            : base(CraftResource.Platinum)
        {
            Name = "Platinum Runic Tinker's Tools";
        }
        public PlatinumRunicTinkerTools(Serial serial) : base(serial) { }

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