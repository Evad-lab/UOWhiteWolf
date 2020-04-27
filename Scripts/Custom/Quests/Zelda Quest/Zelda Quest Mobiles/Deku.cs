using System;
using System.Collections;
using System.Collections.Generic;

using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Deku's corpse" )]
	public class Deku : BaseCreature
	{
		[Constructable]
		public Deku() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a Deku";
			Body = 271;
			BaseSoundID = 451;

			SetStr( 416, 505 );
			SetDex( 1246, 1365 );
			SetInt( 1566, 1655 );

			SetHits( 3550, 5603 );

			SetDamage( 25, 40 );
			
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Physical, 40 );

			SetResistance( ResistanceType.Physical, 70, 80 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 50, 60 );

			SetSkill( SkillName.Musicianship, 120.1, 130.0 );
			SetSkill( SkillName.Peacemaking, 120.1, 130.0 );
			SetSkill( SkillName.Discordance, 150.5, 200.0 );
			SetSkill( SkillName.EvalInt, 120.1, 130.0 );
			SetSkill( SkillName.Magery, 120.1, 130.0 );
			SetSkill( SkillName.MagicResist, 150.5, 200.0 );
			SetSkill( SkillName.Tactics, 100.1, 120.0 );
			SetSkill( SkillName.Wrestling, 110.1, 140.0 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 50;

			PackItem( new DekuShield() );
			PackNecroReg( 50, 80 );
			
			SetSpecialAbility(SpecialAbility.LifeDrain);
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

        //UOWW: commented out for compatilibity with the new Core
		//
		//public override bool DrainsLife { get { return true; } }
        public override bool AutoDispel{ get{ return true; } }
	    public override bool BardImmune{ get{ return true; } }
        public override bool AlwaysMurderer { get { return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 4; } }

		public Deku( Serial serial ) : base( serial )
		{
		}
		
		//UOWW: DrainsLife compatibility with the new Core
		//
		public override void OnDrainLife(Mobile victim)
        {
            if (Map == null)
                return;

            ArrayList list = new ArrayList();
            int count = 0;
            IPooledEnumerable eable = GetMobilesInRange(20);

            foreach (Mobile m in eable)
            {
                if (m == this || !CanBeHarmful(m))
                {
                    if (m is DarkWisp) { count++; }
                    continue;
                }

                if (m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != Team))
                    list.Add(m);
                else if (m.Player)
                    list.Add(m);
            }

            eable.Free();

            foreach (Mobile m in list)
            {
                (new DarkWisp()).MoveToWorld(new Point3D(Location), Map);
                int teleportchance = Hits / HitsMax;

                if (teleportchance < Utility.RandomDouble() && m.Alive)
                {
                    switch (Utility.Random(6))
                    {
                        case 0: m.MoveToWorld(new Point3D(6431, 1664, 0), Map); break;
                        case 1: m.MoveToWorld(new Point3D(6432, 1634, 0), Map); break;
                        case 2: m.MoveToWorld(new Point3D(6401, 1657, 0), Map); break;
                        case 3: m.MoveToWorld(new Point3D(6401, 1637, 0), Map); break;
                        default: m.MoveToWorld(new Point3D(Location), Map); break;
                    }
                }
            }
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