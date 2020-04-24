using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Guilds;
using Server.Gumps;
using Server.Mobiles; 
using Server.Targeting;
using System.Net;
using Server;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Server.Accounting;
using Server.Multis;
using Server.Network;
using Server.Spells;
using Server.Commands;


namespace Server.Items
{
    public enum ResourceDeedType
    {
    BlackPearl,
    Bloodmoss,
    Garlic,
    Ginseng,
    MandrakeRoot,
    Nightshade,
    SulfurousAsh,
    SpidersSilk,
    BatWing,
    DaemonBlood,
    PigIron,
    NoxCrystal,
    GraveDust,
    IronIngot,
    DullCopperIngot,
    ShadowIronIngot,
    CopperIngot,
    BronzeIngot,
    GoldIngot,
    SilverIngot,
    AgapiteIngot,
    VeriteIngot,
    ValoriteIngot,
    Board,
    OakBoard,
    AshBoard,
    YewBoard,
    HeartWoodBoard,
    BloodWoodBoard,
    FrostWoodBoard,
    Clay,
    FertileDirt,
    BlankScroll,
    Bottle,
    Leather,
    SpinedLeather,
    HornedLeather,
    BarbedLeather,
    Cotton,
    Wool,
    WormSilk,
    BlackScales,
    BlueScales,
    GreenScales,
    RedScales,
    WhiteScales,
    YellowScales,
	Feather,
	Cloth
    }
    
    
    

    public class ResourceDeed : Item 
    {
    
        
        private ResourceDeedType m_Type;
        
        [CommandProperty( AccessLevel.GameMaster )]
        public ResourceDeedType Type
        {
            get{ return m_Type; }
            set
            {
                m_Type = value;
                InvalidateProperties();
            }
        }
        private int m_ResourceAmount;
        
        [CommandProperty( AccessLevel.GameMaster )]
        public int ResourceAmount 
        { 
            get { return m_ResourceAmount; } 
            set { 
                m_ResourceAmount = value;
                InvalidateProperties();
                } 
        }

        [Constructable]
        public ResourceDeed() : this ( 1000, ResourceDeedType.Garlic )
        {
        }
        [Constructable]
        public ResourceDeed(int amount, ResourceDeedType resource) : base( 0x14EF )
        {
            m_Type = resource;
            ResourceAmount = amount;
            Weight = 0;
            Hue = 1645;            
            Name = ResourceAmount + " - " + m_Type;
            LootType = LootType.Blessed;
                    }
        


        public ResourceDeed( Serial serial ) : base( serial )
        {
        }
        
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );

            writer.Write( (int) 0 ); // version
            writer.WriteEncodedInt( (int) m_Type );
            writer.WriteEncodedInt( (int) ResourceAmount );
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );

            int version = reader.ReadInt();
            m_Type = (ResourceDeedType)reader.ReadEncodedInt();
            ResourceAmount = reader.ReadEncodedInt();
        }


        public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
        {
            BankBox box = from.FindBankNoCreate();
            
            if ( box == null || !IsChildOf( box ) )
            {
                 from.SendLocalizedMessage( 1047026 ); // That must be in your bank box to use it.
            }
            else
            {
                this.Delete(); 
                from.SendMessage( "{0} {1} has been added to your bank.", ResourceAmount, m_Type);
                
                
                List<Container> packs = new List<Container>( 0 );
                Container cont = null;

                cont = ((Mobile)from).BankBox;


                if ( cont != null )
                    packs.Add( cont );
                

                
                Add.Invoke( from, from.Location, from.Location , new string[] { Convert.ToString(m_Type), Convert.ToString(ResourceAmount) }, packs  );
                
            }
        }   
    }
}