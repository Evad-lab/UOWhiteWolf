using System;
using Server;
using Server.Mobiles;
using Server.Targeting;
using Server.Engines.Quests;

namespace Server.Engines.Quests.TheGraveDigger
{
	public class RiceFlavorSticks : QuestItem
	{
		[Constructable]
		public RiceFlavorSticks() : base( 0x1025 )
		{
			LootType = LootType.Blessed;
			Name = "rice flavor sticks";
			Weight = 1.0;
		}

		public RiceFlavorSticks( Serial serial ) : base( serial )
		{
		}

		public override bool CanDrop( PlayerMobile player )
		{
			TheGraveDiggerQuest qs = player.Quest as TheGraveDiggerQuest;

			if ( qs == null )
				return true;

			return !( qs.IsObjectiveInProgress( typeof( FindRiceFlavorSticksObjective ) )
				|| qs.IsObjectiveInProgress( typeof( FindRiceFlavorSticksObjective ) )
				|| qs.IsObjectiveInProgress( typeof( FindRiceFlavorSticksObjective ) )
				|| qs.IsObjectiveInProgress( typeof( FindPureGrainAlcoholObjective ) )
				|| qs.IsObjectiveInProgress( typeof( FindVincentObjective ) ) );
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