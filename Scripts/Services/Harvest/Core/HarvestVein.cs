using System;

namespace Server.Engines.Harvest
{
    public class HarvestVein
    {
        public HarvestVein(double veinChance, double chanceToFallback, HarvestResource primaryResource, HarvestResource fallbackResource)
        {
            VeinChance = veinChance;
            ChanceToFallback = chanceToFallback;
            PrimaryResource = primaryResource;
            FallbackResource = fallbackResource;
        }

        public double VeinChance { get; set; }
        public double ChanceToFallback { get; set; }
        public HarvestResource PrimaryResource { get; set; }
        public HarvestResource FallbackResource { get; set; }
        
        //daat99 OWLTR start - custom harvesting
        private bool b_IsProspected = false;
        public bool IsProspected { get { return b_IsProspected; } set { b_IsProspected = value; } }
        //daat99 OWLTR end - custom harvesting
    }
}
