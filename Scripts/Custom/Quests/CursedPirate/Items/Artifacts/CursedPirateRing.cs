using System;
using Server;

namespace Server.Items
{
	public class CursedPirateRing : GoldRing
	{
        public override int ArtifactRarity{ get{ return 20; } }
		[Constructable]
		public CursedPirateRing()
		{
			Weight = 0.5;
			Name = "Cursed Pirate Ring";
            Hue = 0x35; 
            SkillBonuses.SetValues(0, SkillName.Hiding, (Utility.Random(4) == 0 ? 10.0 : 5.0));

			Attributes.AttackChance = 15;
            Attributes.DefendChance = 10;
            Attributes.BonusStam = 5;
			Attributes.Luck = 100;
            Attributes.RegenStam = 1;			
		}

		public CursedPirateRing( Serial serial ) : base( serial )
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