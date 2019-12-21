/////////////////////////////////////////////////
//                                             //
//                  LIACS                      //
//              Market Place                   //
//               11/24/2006                    //
//                                             // 
/////////////////////////////////////////////////

using System;
using Server;
using Server.Items;
using Server.Mobiles;
using System.Collections;
using Server.Network;
using Server.Targeting;
using System.IO;
using System.Collections.Generic;

namespace Server.Items
{
	public class MarketAddon : BaseAddon
	{
        private ArrayList m_market;
        int marketCount = 4;

        private ArrayList m_marketmob;
        int marketmobCount = 4; 

		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketAddonDeed();
			}
		}

		[ Constructable ]
		public MarketAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3024 );
			ac.Name = "MARKET EVERY DAY FROM 6 TO 6.";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4758 );
			AddComponent( ac, 0, 0, 0 );

            m_market = new ArrayList();
            m_marketmob = new ArrayList();

		}
        public override bool HandlesOnMovement { get { return true; } }

        public override void OnMovement(Mobile m, Point3D oldLocation)
        {
            base.OnMovement(m, oldLocation);


            int hours, minutes, uoDay, totalUoDays, totalMinutes;

            Server.Items.Clock.GetTime(m.Map, m.X, m.Y, out hours, out minutes, out totalMinutes);

            totalUoDays = (int)Math.Ceiling((double)totalMinutes / (60 * 24));

            Math.DivRem(totalUoDays, 30, out uoDay);

            //if (uoDay== 1 || uoDay == 7 || uoDay == 15 || uoDay== 23) 
            // {
            if (hours >= 6 && hours <= 18)
            {
                int marketplace = m_market.Count;
                int marketplacemob = m_marketmob.Count;

                if (marketplace >= marketCount && marketplacemob >= marketCount)
                    return;

                bool validLocation = false;
                Map map = this.Map;

                for (int i = marketplace; i < marketCount; ++i)
                {
                    if (i == 0)
                    {
                        Point3D marketloc = this.Location;//
                        AG_MarketStandMercerEastAddon market = new AG_MarketStandMercerEastAddon();

                        for (int k = 0; !validLocation && k < 10; ++k)
                        {
                            int ax = X;
                            int ay = Y + 3;
                            int az = map.GetAverageZ(ax, ay);

                            if (validLocation = map.CanFit(ax, ay, this.Z, 16, false, false))
                                marketloc = new Point3D(ax, ay, Z);
                            else if (validLocation = map.CanFit(ax, ay, az, 16, false, false))
                                marketloc = new Point3D(ax, ay, az);
                        }
                        market.MoveToWorld(marketloc, this.Map);
                        m_market.Add(market);
                    }

                    if (i == 1)
                    {
                        Point3D marketloc1 = this.Location;//
                        AG_MarketStandCheeseSouthAddon market = new AG_MarketStandCheeseSouthAddon();

                        int bx = X - 3;
                        int by = Y;
                        int bz = map.GetAverageZ(bx, by);

                        if (validLocation = map.CanFit(bx, by, this.Z, 16, false, false))
                            marketloc1 = new Point3D(bx, by, Z);
                        else if (validLocation = map.CanFit(bx, by, bz, 16, false, false))
                            marketloc1 = new Point3D(bx, by, bz);
                       
                        market.MoveToWorld(marketloc1, this.Map);
                        m_market.Add(market);
                    }

                    if (i == 2)
                    {
                        Point3D marketloc2 = this.Location;//
                        MarketStandVegetablesSouthAddon market = new MarketStandVegetablesSouthAddon();
 
                        int cx = X + 3;
                        int cy = Y;
                        int cz = map.GetAverageZ(cx, cy);

                        if (validLocation = map.CanFit(cx, cy, this.Z, 16, false, false))
                            marketloc2 = new Point3D(cx, cy, Z);
                        else if (validLocation = map.CanFit(cx, cy, cz, 16, false, false))
                            marketloc2 = new Point3D(cx, cy, cz);
                       
                        market.MoveToWorld(marketloc2, this.Map);
                        m_market.Add(market);
                    }

                    if (i == 3)
                    {
                        Point3D marketloc3 = this.Location;//
                        AG_MarketStandFishEastAddon market = new AG_MarketStandFishEastAddon();

                        int dx = X;
                        int dy = Y - 3;
                        int dz = map.GetAverageZ(dx, dy);

                        if (validLocation = map.CanFit(dx, dy, this.Z, 16, false, false))
                            marketloc3 = new Point3D(dx, dy, Z);
                        else if (validLocation = map.CanFit(dx, dy, dz, 16, false, false))
                            marketloc3 = new Point3D(dx, dy, dz);
                        
                        market.MoveToWorld(marketloc3, this.Map);
                        m_market.Add(market);
                    }
                }

                for (int i = marketplacemob; i < marketmobCount; ++i)
                {
                    if (i == 0)
                    {
                        Point3D marketloc5 = this.Location;//
                        VegetableFarmer marketmob0 = new VegetableFarmer();

                        int fx = X + 3;
                        int fy = Y;
                        int fz = map.GetAverageZ(fx, fy);

                        if (validLocation = map.CanFit(fx, fy, this.Z, 16, false, false))
                            marketloc5 = new Point3D(fx, fy, Z);
                        else if (validLocation = map.CanFit(fx, fy, fz, 16, false, false))
                            marketloc5 = new Point3D(fx, fy, fz);
                        
                        marketmob0.Home = marketloc5;
                        marketmob0.RangeHome = 0;
                        marketmob0.MoveToWorld(marketloc5, this.Map);
                        m_marketmob.Add(marketmob0);
                    }
                    if (i == 1)
                    {
                        Point3D marketloc6 = this.Location;//
                        Mercer marketmob1 = new Mercer();

                        int gx = X - 2;
                        int gy = Y + 3;
                        int gz = map.GetAverageZ(gx, gy);

                        if (validLocation = map.CanFit(gx, gy, this.Z, 16, false, false))
                            marketloc6 = new Point3D(gx, gy, Z);
                        else if (validLocation = map.CanFit(gx, gy, gz, 16, false, false))
                            marketloc6 = new Point3D(gx, gy, gz);
                       
                        marketmob1.Home = marketloc6;
                        marketmob1.RangeHome = 0;
                        marketmob1.MoveToWorld(marketloc6, this.Map);
                        m_marketmob.Add(marketmob1);
                    }
                    if (i == 2)
                    {
                        Point3D marketloc7 = this.Location; //
                        Fisherman marketmob2 = new Fisherman();

                        int hx = X + 3;
                        int hy = Y - 3;
                        int hz = map.GetAverageZ(hx, hy);

                        if (validLocation = map.CanFit(hx, hy, this.Z, 16, false, false))
                            marketloc7 = new Point3D(hx, hy, Z);
                        else if (validLocation = map.CanFit(hx, hy, hz, 16, false, false))
                            marketloc7 = new Point3D(hx, hy, hz);
                        
                        marketmob2.Home = marketloc7;
                        marketmob2.RangeHome = 0;
                        marketmob2.MoveToWorld(marketloc7, this.Map);
                        m_marketmob.Add(marketmob2);
                    }
                    if (i == 3)
                    {
                        Point3D marketloc8 = this.Location; //
                        CheeseMonger marketmob3 = new CheeseMonger();

                        int ix = X - 3;
                        int iy = Y - 2;
                        int iz = map.GetAverageZ(ix, iy);

                        if (validLocation = map.CanFit(ix, iy, this.Z, 16, false, false))
                            marketloc8 = new Point3D(ix, iy, Z);
                        else if (validLocation = map.CanFit(ix, iy, iz, 16, false, false))
                            marketloc8 = new Point3D(ix, iy, iz);
                        
                        marketmob3.Home = marketloc8;
                        marketmob3.RangeHome = 0;
                        marketmob3.MoveToWorld(marketloc8, this.Map);
                        m_marketmob.Add(marketmob3);
                    }

                }

            }
            //}

            else
            {
                foreach (Item that in m_market)
                    that.Delete();

                foreach (Mobile thats in m_marketmob)
                    thats.Delete();
            }
        }

		public MarketAddon( Serial serial ) : base( serial )
		{

		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 1 ); // Version
            writer.WriteItemList(m_market, true);
            writer.WriteMobileList(m_marketmob, true);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            m_market = reader.ReadItemList();
            m_marketmob = reader.ReadMobileList();
		}
	}

	public class MarketAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketAddon();
			}
		}

		[Constructable]
		public MarketAddonDeed()
		{
			Name = "Market Deed";
		}

		public MarketAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}