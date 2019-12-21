using System;
using System.Collections.Generic;
using Server.Engines.Craft;

namespace Server.Engines.BulkOrders
{
    public class SmallCarpentryBOD : SmallBOD
    {
        public static double[] m_CarpentryMaterialChances = new double[]
        {
			//daat99 OWLTR - start
			0.140, // None
			0.130, // OakWood
			0.120, // AshWood
			0.110, // YewWood
			0.100, // Heartwood
			0.090, // Bloodwood
			0.080, // Frostwood
			0.070, // Ebony
			0.060, // Bamboo
			0.050, // PurpleHeart
			0.030, // Redwood
			0.020  // Petrified
			//daat99 OWLTR - end
			//
			//original code below
			//
			/*
            0.513718750, // None
            0.292968750, // Oak
            0.117187500, // Ash
            0.046875000, // Yew
            0.018750000, // Heartwood
            0.007500000, // Bloodwood
            0.003000000 // Frostwood
			*/
        };

        public override BODType BODType { get { return BODType.Carpentry; } }

        [Constructable]
        public SmallCarpentryBOD()
        {
            SmallBulkEntry[] entries;
            bool useMaterials = Utility.RandomBool();

            entries = SmallBulkEntry.CarpentrySmalls;

            if (entries.Length > 0)
            {
                int amountMax = Utility.RandomList(10, 15, 20);

                BulkMaterialType material = BulkMaterialType.None;
                
                if(useMaterials)
                    material = GetRandomMaterial(BulkMaterialType.OakWood, m_CarpentryMaterialChances);

                bool reqExceptional = Utility.RandomBool() || (material == BulkMaterialType.None);

                SmallBulkEntry entry = entries[Utility.Random(entries.Length)];

                this.Hue = 1512;
                this.AmountMax = amountMax;
                this.Type = entry.Type;
                this.Number = entry.Number;
                this.Graphic = entry.Graphic;
                this.RequireExceptional = reqExceptional;
                this.Material = material;
                this.GraphicHue = entry.Hue;
            }
        }

        public SmallCarpentryBOD(int amountCur, int amountMax, Type type, int number, int graphic, bool reqExceptional, BulkMaterialType mat, int hue)
        {
            this.Hue = 1512;
            this.AmountMax = amountMax;
            this.AmountCur = amountCur;
            this.Type = type;
            this.Number = number;
            this.Graphic = graphic;
            this.RequireExceptional = reqExceptional;
            this.Material = mat;
            this.GraphicHue = hue;
        }

        public SmallCarpentryBOD(Serial serial)
            : base(serial)
        {
        }

        private SmallCarpentryBOD(SmallBulkEntry entry, BulkMaterialType material, int amountMax, bool reqExceptional)
        {
            this.Hue = 1512;
            this.AmountMax = amountMax;
            this.Type = entry.Type;
            this.Number = entry.Number;
            this.Graphic = entry.Graphic;
            this.RequireExceptional = reqExceptional;
            this.Material = material;
        }

        public static SmallCarpentryBOD CreateRandomFor(Mobile m)
        {
            SmallBulkEntry[] entries;
            bool useMaterials = Utility.RandomBool();

            double theirSkill = BulkOrderSystem.GetBODSkill(m, SkillName.Carpentry);

            entries = SmallBulkEntry.CarpentrySmalls;

            if (entries.Length > 0)
            {
                int amountMax;

                if (theirSkill >= 70.1)
                    amountMax = Utility.RandomList(10, 15, 20, 20);
                else if (theirSkill >= 50.1)
                    amountMax = Utility.RandomList(10, 15, 15, 20);
                else
                    amountMax = Utility.RandomList(10, 10, 15, 20);

                BulkMaterialType material = BulkMaterialType.None;

                if (useMaterials && theirSkill >= 70.1)
                {
                    for (int i = 0; i < 20; ++i)
                    {
                        BulkMaterialType check = GetRandomMaterial(BulkMaterialType.OakWood, m_CarpentryMaterialChances);
                        double skillReq = GetRequiredSkill(check);

						//daat99 OWLTR - start
						switch ( check )
						{
							case BulkMaterialType.DullCopper:	skillReq = 52.0; break;
							case BulkMaterialType.ShadowIron:	skillReq = 56.0; break;
							case BulkMaterialType.Copper:		skillReq = 60.0; break;
							case BulkMaterialType.Bronze:		skillReq = 64.0; break;
							case BulkMaterialType.Gold:			skillReq = 68.0; break;
							case BulkMaterialType.Agapite:		skillReq = 72.0; break;
							case BulkMaterialType.Verite:		skillReq = 76.0; break;
							case BulkMaterialType.Valorite:		skillReq = 80.0; break;
							case BulkMaterialType.Blaze:		skillReq = 84.0; break;
							case BulkMaterialType.Ice:			skillReq = 88.0; break;
							case BulkMaterialType.Toxic:		skillReq = 92.0; break;
							case BulkMaterialType.Electrum:		skillReq = 96.0; break;
							case BulkMaterialType.Platinum:		skillReq = 100.0; break;
							case BulkMaterialType.Spined:		skillReq = 64.0; break;
							case BulkMaterialType.Horned:		skillReq = 68.0; break;
							case BulkMaterialType.Barbed:		skillReq = 72.0; break;
							case BulkMaterialType.Polar:		skillReq = 76.0; break;
							case BulkMaterialType.Synthetic:	skillReq = 80.0; break;
							case BulkMaterialType.BlazeL:		skillReq = 84.0; break;
							case BulkMaterialType.Daemonic:		skillReq = 88.0; break;
							case BulkMaterialType.Shadow:		skillReq = 92.0; break;
							case BulkMaterialType.Frost:		skillReq = 96.0; break;
							case BulkMaterialType.Ethereal:		skillReq = 100.0; break;
							case BulkMaterialType.OakWood:			skillReq = 60.0; break;
							case BulkMaterialType.AshWood:			skillReq = 64.0; break;
							case BulkMaterialType.YewWood:		skillReq = 68.0; break;
							case BulkMaterialType.Heartwood:			skillReq = 72.0; break;
							case BulkMaterialType.Bloodwood:			skillReq = 76.0; break;
							case BulkMaterialType.Frostwood:		skillReq = 80.0; break;
							case BulkMaterialType.Ebony:		skillReq = 84.0; break;
							case BulkMaterialType.Bamboo:		skillReq = 88.0; break;
							case BulkMaterialType.PurpleHeart:	skillReq = 92.0; break;
							case BulkMaterialType.Redwood:		skillReq = 96.0; break;
							case BulkMaterialType.Petrified:	skillReq = 100.0; break;
						}
						//daat99 OWLTR - end
						
                        if (theirSkill >= skillReq)
                        {
                            material = check;
                            break;
                        }
                    }
                }

                double excChance = 0.0;

                if (theirSkill >= 70.1)
                    excChance = (theirSkill + 80.0) / 200.0;

                bool reqExceptional = (excChance > Utility.RandomDouble());

                CraftSystem system = DefCarpentry.CraftSystem;

                List<SmallBulkEntry> validEntries = new List<SmallBulkEntry>();

                for (int i = 0; i < entries.Length; ++i)
                {
                    CraftItem item = system.CraftItems.SearchFor(entries[i].Type);

                    if (item != null)
                    {
                        bool allRequiredSkills = true;
                        double chance = item.GetSuccessChance(m, null, system, false, ref allRequiredSkills);

                        if (allRequiredSkills && chance >= 0.0)
                        {
                            if (reqExceptional)
                                chance = item.GetExceptionalChance(system, chance, m);

                            if (chance > 0.0)
                                validEntries.Add(entries[i]);
                        }
                    }
                }

                if (validEntries.Count > 0)
                {
                    SmallBulkEntry entry = validEntries[Utility.Random(validEntries.Count)];
                    return new SmallCarpentryBOD(entry, material, amountMax, reqExceptional);
                }
            }

            return null;
        }

        public override int ComputeFame()
        {
            return CarpentryRewardCalculator.Instance.ComputeFame(this);
        }

        public override int ComputeGold()
        {
            return CarpentryRewardCalculator.Instance.ComputeGold(this);
        }

        public override List<Item> ComputeRewards(bool full)
        {
            return null;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}