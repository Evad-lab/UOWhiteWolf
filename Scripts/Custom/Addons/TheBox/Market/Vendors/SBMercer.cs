using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBMercer: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMercer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{

				Add( new GenericBuyInfo( typeof( SewingKit ), 3, 20, 0xF9D, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Scissors ), 11, 20, 0xF9F, 0 ) );
				Add( new GenericBuyInfo( typeof( DyeTub ), 8, 20, 0xFAB, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Dyes ), 8, 20, 0xFA9, 0 ) ); 

				Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, 20, 0xf95, Utility.RandomDyedHue() ) ); 

				Add( new GenericBuyInfo( typeof( Cloth ), 2, 20, 0x1766, Utility.RandomDyedHue() ) ); 
				Add( new GenericBuyInfo( typeof( UncutCloth ), 2, 20, 0x1767, Utility.RandomDyedHue() ) ); 

				Add( new GenericBuyInfo( typeof( Cotton ), 102, 20, 0xDF9, 0 ) );
				Add( new GenericBuyInfo( typeof( SpoolOfThread ), 18, 20, 0xFA0, 0 ) );
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
