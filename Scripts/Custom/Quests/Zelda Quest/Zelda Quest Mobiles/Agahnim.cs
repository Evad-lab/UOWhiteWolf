using System;
using System.Collections;
using System.Collections.Generic;

using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Agahnim's corpse" )]
	public class Agahnim : BaseCreature
	{
		[Constructable]
		public Agahnim () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Agahnim";
			Body = 0x92;
			BaseSoundID = 362;

			SetStr( 796, 825 );
			SetDex( 786, 1105 );
			SetInt( 1436, 1475 );

			SetHits( 3478, 5495 );

			SetDamage( 25, 40 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 75, 85 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 55, 65 );
			SetResistance( ResistanceType.Energy, 45, 65 );

			SetSkill( SkillName.EvalInt, 160.1, 170.0 );
			SetSkill( SkillName.Magery, 120.1, 140.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 100.1, 110.5 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 60;

									
			PackItem( new Mirror() );
			
			SetSpecialAbility(SpecialAbility.LifeDrain);
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}

        //UOWW: commented out ofr compatibility with the new Core
		//
		//public override bool DrainsLife { get { return true; } }
	    
		public override bool BardImmune{ get{ return true; } }
        public override bool AlwaysMurderer { get { return true; }}
		public override bool AutoDispel{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 4; } }


		public Agahnim( Serial serial ) : base( serial )
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