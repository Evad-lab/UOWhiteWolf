
//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class VampBracelet : GoldBracelet
	{
		public override int ArtifactRarity{ get{ return 66; } }

		[Constructable]
		public VampBracelet()
		{
			Hue = 37;
			Name = "Draculas Bracchium ";
			Attributes.WeaponDamage = 10;
			Attributes.ReflectPhysical = 15;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			Attributes.RegenStam = 5;
			Attributes.RegenMana= 5;
			Attributes.RegenHits = 5;
			LootType = LootType.Blessed;
		}

		public VampBracelet( Serial serial ) : base( serial )
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