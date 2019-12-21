using System;
using Server.Misc;

namespace Server.Items
{
	[Flipable (0x1F04, 0x1F03)] 
	public class StevesShirt : BaseShirt 
	{ 
		private SkillMod m_SkillMod0; 
		private SkillMod m_SkillMod1; 
		private SkillMod m_SkillMod2;
        private SkillMod m_SkillMod3; 
		//private StatMod m_StatMod0; 
		
		[Constructable] 
		public StevesShirt() : base( 0x1EFD ) 
		{ 
			Name = "Steve Irwins Shirt Of Nature";
            Weight = 1.0; 
            Layer = Layer.Shirt;
			Hue = 67; 
			DefineMods();
		} 

		private void DefineMods()
		{
			m_SkillMod0 = new DefaultSkillMod( SkillName.AnimalTaming, true, 10 ); 
			m_SkillMod1 = new DefaultSkillMod( SkillName.AnimalLore, true, 10 ); 
			m_SkillMod2 = new DefaultSkillMod( SkillName.Healing, true, 10 );
            m_SkillMod3 = new DefaultSkillMod( SkillName.Veterinary, true, 10 ); 
			//m_StatMod0 = new StatMod( StatType.Int, "StevesShirt", 15, TimeSpan.Zero ); 
		}

		private void SetMods( Mobile wearer )
		{			
			wearer.AddSkillMod( m_SkillMod0 ); 
			wearer.AddSkillMod( m_SkillMod1 ); 
			wearer.AddSkillMod( m_SkillMod2 );
            wearer.AddSkillMod( m_SkillMod3 ); 
			//wearer.AddStatMod( m_StatMod0 ); 
		}

		public override bool OnEquip( Mobile from ) 
		{ 
			SetMods( from );
			return true;  
		} 

		public override bool Dye( Mobile from, DyeTub sender )
		{
			from.SendLocalizedMessage( 1042083 ); // You cannot dye that.
			return false;
		}

		public override void OnRemoved( object parent ) 
		{ 
			if ( parent is Mobile ) 
			{ 
				//Mobile m = (Mobile)parent;
				//m.RemoveStatMod( "StevesShirt" ); 

				//if ( m.Hits > m.HitsMax )
					//m.Hits = m.HitsMax; 

				if ( m_SkillMod0 != null ) 
					m_SkillMod0.Remove(); 

				if ( m_SkillMod1 != null ) 
					m_SkillMod1.Remove(); 

				if ( m_SkillMod2 != null ) 
					m_SkillMod2.Remove(); 
			
			    if ( m_SkillMod3 != null ) 
					m_SkillMod3.Remove();
			
			} 
		} 

		public override void OnSingleClick( Mobile from ) 
		{ 
			this.LabelTo( from, Name ); 
		} 

		public StevesShirt( Serial serial ) : base( serial ) 
		{ 
			DefineMods();
			
			if ( Parent != null && this.Parent is Mobile ) 
				SetMods( (Mobile)Parent );
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
