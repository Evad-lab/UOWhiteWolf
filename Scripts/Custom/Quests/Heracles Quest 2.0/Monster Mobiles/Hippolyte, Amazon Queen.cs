using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Hippolyte's corpse" )]
	public class Hippolyte : BaseCreature
	{
		[Constructable]
		public Hippolyte() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			
                        Name = "Hippolyte";
                        Body = 0x191;
                        Title = "An Amazon Queen";
                        Hue = 1009;
                        BaseSoundID = 333;


			SetStr( 600, 700 );
			SetDex( 200, 300 );
			SetInt( 51, 65 );

                        SetHits( 500, 700 );

			SetDamage( 30, 50 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetSkill( SkillName.Fencing, 100.0, 120.0 );
			SetSkill( SkillName.Macing, 100.0, 120.0 );
			SetSkill( SkillName.Poisoning, 100.0, 120.0 );
			SetSkill( SkillName.MagicResist, 100.0, 120.0 );
			SetSkill( SkillName.Swords, 100.0, 120.0 );
			SetSkill( SkillName.Tactics, 100.0, 120.0 );

			Fame = 1000;
			Karma = -1000;

                        VirtualArmor = 60;

			PackGold( 1500, 3000 );
			PackItem( new HippolytesGirdle() );
			PackItem( new Bandage( Utility.RandomMinMax( 15, 25 ) ) );
            //PackMagicItems( 2, 4 );
			
			AddItem( new Skirt( 1376 ) );
			AddItem( new FancyShirt( 1376 ) );
                        AddItem( new LongHair( 31 ) );
                        AddItem( new Boots( 1376 ) );
                        AddItem( new Katana() );
                        AddItem( new FlowerGarland( 24 ) );
                        

					}

		public override int Meat{ get{ return 1; } }
		public override bool AlwaysMurderer{ get{ return true; } }
                public override Poison HitPoison{ get{ return Poison.Deadly; } }
		public override bool ShowFameTitle{ get{ return false; } }
			
		

		public Hippolyte( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
