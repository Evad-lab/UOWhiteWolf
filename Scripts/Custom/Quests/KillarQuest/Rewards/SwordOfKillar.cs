using System;
using Server;
using Server.Spells;

namespace Server.Items
{
public class SwordOfKillar : PaladinSword
{
public override int ArtifactRarity{ get{ return 20; } }

public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
public override float MlSpeed{ get{ return 3.50f; } }

[Constructable]
public SwordOfKillar()
{
Hue = 1161;
Name = "Sword Of Killar";
Attributes.Luck = 30;
Attributes.AttackChance = 15;
//Attributes.SpellChanneling = 1;
Attributes.WeaponSpeed = 20;
Attributes.WeaponDamage= 40;
Attributes.ReflectPhysical = 20;
//Attributes.CastRecovery = 2;
Attributes.CastSpeed = 1;
Attributes.RegenMana = 2;
Attributes.RegenStam = 2;
WeaponAttributes.ResistFireBonus = 10;
WeaponAttributes.UseBestSkill = 1;
WeaponAttributes.HitFireball = 50;


Slayer = SlayerName.Silver;

LootType = LootType.Blessed;
DurabilityLevel = WeaponDurabilityLevel.Indestructible;

}

public override void GetDamageTypes( Mobile weilder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
{
phys = nrgy = cold = pois = chaos = direct = 0;
fire = 100;
}

public virtual void OnHit( Mobile attacker, Mobile defender )
{
double damage = 0.0;

PlaySwingAnimation( attacker );
PlayHurtAnimation( defender );

attacker.PlaySound( GetHitAttackSound( attacker, defender ) );
defender.PlaySound( GetHitDefendSound( attacker, defender ) );

switch ( Utility.Random( 5 ) )
                        { 
                          case 0: defender.Damage( 50, attacker );
				  defender.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.Waist ); //FlameStrike Effect
				  defender.PlaySound( 0x208 );
				  attacker.Say( "Ancestors of Killar...Aide Me!!!" ); break;
                          	  break;
                        }

SpellHelper.Damage( TimeSpan.Zero, defender, attacker, damage, 0, 5, 0, 0, 0 );

//defender.BoltEffect( 0 ); //Lightning Effect
//defender.Kill();

base.OnHit( attacker, defender );
}

public SwordOfKillar( Serial serial ) : base( serial )
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