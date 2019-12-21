using System;
using Server;

namespace Server.Items
{
	public class CursedPirateTricorne : TricorneHat
	{
        public override int ArtifactRarity{ get{ return 20; } }  

        [Constructable]
		public CursedPirateTricorne()
		{
			Name = "Cursed Pirate Tricorne Hat";
			Hue = 0x497;

			Resistances.Cold = 8;
			Resistances.Poison = 10;
			Resistances.Physical = 12;
			Resistances.Fire = 6;
			Resistances.Energy = 8;

            SkillBonuses.SetValues(0, SkillName.Hiding, (Utility.Random(4) == 0 ? 15.0 : 10.0));

			Attributes.BonusInt = 5;
			Attributes.AttackChance = 10;
			Attributes.NightSight = 1;
            //Attributes.BonusHits = 12;
       		Attributes.Luck = 100;
       		//Attributes.ReflectPhysical = 15;
		}

		public CursedPirateTricorne( Serial serial ) : base( serial )
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