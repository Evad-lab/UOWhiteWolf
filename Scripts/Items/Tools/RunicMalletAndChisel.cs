using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	public class RunicMalletAndChisel : BaseRunicTool
	{
		public override CraftSystem CraftSystem{ get{ return DefMasonry.CraftSystem; } }

        public override int LabelNumber
        {
            get
            {
                int index = CraftResources.GetIndex(Resource);

                if (index >= 1 && index <= 8)
                    return 1111795 + index;

                return 1045128; // mallet and chisel
            }
        }

		[Constructable]
		public RunicMalletAndChisel( CraftResource resource ) : base( resource, 4787 )
		{
			Weight = 2.0;
			Hue = CraftResources.GetHue( resource );
		}

		[Constructable]
		public RunicMalletAndChisel( CraftResource resource, int uses ) : base( resource, uses, 4787 )
		{
			Weight = 2.0;
			Hue = CraftResources.GetHue( resource );
		}

        public RunicMalletAndChisel(Serial serial)
            : base(serial)
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
		//daat99 OWTLR start - runic storage
		public override Type GetCraftableType()
		{
			switch (Resource)
			{
				case CraftResource.DullCopper:
					return typeof(DullCopperRunicHammer);
				case CraftResource.ShadowIron:
					return typeof(ShadowIronRunicHammer);
				case CraftResource.Copper:
					return typeof(CopperRunicHammer);
				case CraftResource.Bronze:
					return typeof(BronzeRunicHammer);
				case CraftResource.Gold:
					return typeof(GoldRunicHammer);
				case CraftResource.Agapite:
					return typeof(AgapiteRunicHammer);
				case CraftResource.Verite:
					return typeof(VeriteRunicHammer);
				case CraftResource.Valorite:
					return typeof(ValoriteRunicHammer);
				case CraftResource.Blaze:
					return typeof(BlazeRunicHammer);
				case CraftResource.Ice:
					return typeof(IceRunicHammer);
				case CraftResource.Toxic:
					return typeof(ToxicRunicHammer);
				case CraftResource.Electrum:
					return typeof(ElectrumRunicHammer);
				case CraftResource.Platinum:
					return typeof(PlatinumRunicHammer);
				default:
					return null;
			}
		} 
		//daat99 OWLTR end - runic storage
	}
}