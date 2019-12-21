//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class MinionLordsAxe : ExecutionersAxe
	{
	 	public override int ArtifactRarity{ get{ return 35; } }
	 	public override int InitMinHits{ get{ return 250; } }
	 	public override int InitMaxHits{ get{ return 255; } }
	 	[Constructable]
	 	public MinionLordsAxe()
	 	{
	 	 	Name = "a Minion Lords axe";
	 	 	Hue = 1157;
	 	 	Attributes.SpellChanneling = 1;
	 	 	Attributes.BonusStr = 10;
	 	 	Attributes.BonusHits = 5;
	 	 	Attributes.BonusMana = 5;
	 	 	Attributes.RegenHits = 5;
	 	 	Attributes.RegenMana = 5;
	 	 	Attributes.AttackChance = 10;
	 	 	Attributes.WeaponDamage = 25;
	 	 	Attributes.WeaponSpeed = 25;
	 	 	WeaponAttributes.HitFireArea = 50;
	 	 	WeaponAttributes.SelfRepair = 5;
	 	 	Attributes.CastSpeed = 2;
	 	 	Attributes.CastRecovery = 2;
	 	 	WeaponAttributes.HitFireball = 50;
			LootType = LootType.Blessed;
	 	}

	 	public MinionLordsAxe(Serial serial) : base( serial )
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
