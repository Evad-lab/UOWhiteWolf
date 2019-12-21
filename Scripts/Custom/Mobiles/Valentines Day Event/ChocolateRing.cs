
using System;
using Server;

namespace Server.Items
{
	public class ChocolateRing : GoldRing
	{
		
		public override int ArtifactRarity { get{ return 25; } }

		[Constructable]
		public ChocolateRing()
		{
			Weight = 1.0;
			Name = "Stained Chocolate Ring";
			Hue = 2018;

			Attributes.BonusInt = 5;
			Attributes.BonusMana = 8;
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 50;
			Attributes.Luck = 200;
			Attributes.NightSight = 1;
			Attributes.RegenMana = 2;

			SkillBonuses.SetValues( 0, SkillName.EvalInt, 5.0 );
			SkillBonuses.SetValues( 1, SkillName.Magery, 5.0 );


			LootType = LootType.Blessed; 
			
		}

		public ChocolateRing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}