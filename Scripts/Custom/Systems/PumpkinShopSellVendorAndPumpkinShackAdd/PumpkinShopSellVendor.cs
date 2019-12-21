//Created By Milva

using System;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class PumpkinShopSellVendor : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }


		[Constructable]
		public PumpkinShopSellVendor() : base( "Pumpkin Shop Sell Vendor" )
		{
                                        Body = 401;
                                        Hue =  1866;
			SetSkill( SkillName.ItemID, 64.0, 100.0 );
                                     
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBPumpkinShopSellVendor () );
                              }
		public override void InitOutfit()
		{
			base.InitOutfit();
                                                AddItem( new Server.Items.Skirt(1106) );
                                                AddItem( new Server.Items.FullApron(1258) );
                                                AddItem( new Server.Items.WizardsHat(1258) );
                                                AddItem( new Server.Items.Shirt(1258) );
                                                AddItem( new Server.Items.Shoes(1258) );
                                                
                                }
        public PumpkinShopSellVendor(Serial serial)
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
	}
}
