//Created By Milva

using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBPumpkinShopSellVendor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

        public SBPumpkinShopSellVendor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
                Add(new GenericBuyInfo(typeof(GlowingRoundEyePumpkin), 2000, 20, 0x4691, 0));
                Add(new GenericBuyInfo(typeof(GlowingSlantedEyePumpkin), 2000, 20, 0x4695, 0));
                Add(new GenericBuyInfo(typeof(DarkRoundEyePumpkin), 1500, 20, 0x4698, 0));
                Add(new GenericBuyInfo(typeof(DarkSlantedEyePumpkin), 1500, 20, 0x4694, 0));
                Add(new GenericBuyInfo(typeof(SlantedEyePumpkin), 1500, 20, 0x4692, 0));
                Add(new GenericBuyInfo(typeof(RoundEyePumpkin), 1500, 20, 0x4696, 0));
                
			}
		}
        
		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
		}
	 }
  }
}
