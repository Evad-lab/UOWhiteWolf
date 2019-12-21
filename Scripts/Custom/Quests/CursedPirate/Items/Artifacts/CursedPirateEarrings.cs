using System;
using Server;

namespace Server.Items
{
	public class CursedPirateEarrings : GoldEarrings
	{
        public override int ArtifactRarity{ get{ return 20; } }
	
		[Constructable]
		public CursedPirateEarrings()
		{
			
			Weight = 0.5; 
            Name = "Cursed Pirate Earrings";
            Hue = 0x35;

            SkillBonuses.SetValues(0, SkillName.Snooping, (Utility.Random(4) == 0 ? 15.0 : 10.0));
            SkillBonuses.SetValues(0, SkillName.Stealing, (Utility.Random(4) == 0 ? 15.0 : 10.0));

            Attributes.AttackChance = 10;
			Attributes.RegenHits = 2;
			Attributes.BonusStr = 10;
            Attributes.BonusHits = 5;
			Attributes.WeaponSpeed = 5;
			Attributes.Luck = 100;
		}

		public CursedPirateEarrings ( Serial serial ) : base( serial )
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