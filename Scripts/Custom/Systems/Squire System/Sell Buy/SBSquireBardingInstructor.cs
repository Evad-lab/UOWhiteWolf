using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBSquireBardingInstructor : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSquireBardingInstructor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "an musicianship training contract", typeof( SMusicianshipContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an peacemaking training contract", typeof( SPeacemakingContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an discordance training contract", typeof( SDiscordanceContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an provocation training contract", typeof( SProvocationContract ), 300, 10, 0x14F0, 0 ) );
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