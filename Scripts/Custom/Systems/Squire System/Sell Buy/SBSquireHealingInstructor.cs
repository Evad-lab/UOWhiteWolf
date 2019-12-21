using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBSquireHealingInstructor : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSquireHealingInstructor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "an healing training contract", typeof( SHealingContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an veterinary training contract", typeof( SVeterinaryContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an animal lore training contract", typeof( SAnimalLoreContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an anatomy training contract", typeof( SAnatomyContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an spirit speak training contract", typeof( SSpiritSpeakContract ), 300, 10, 0x14F0, 0 ) ); // Added 1.9.2
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