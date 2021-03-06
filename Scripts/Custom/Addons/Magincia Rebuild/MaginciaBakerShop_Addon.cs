
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MaginciaBakerShop_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3203, 6, -2, 11}, {3203, 6, -1, 11}, {3203, 6, 0, 11}// 18	19	20	
			, {3203, 6, 1, 11}, {3203, 6, 2, 11}, {3203, 6, 3, 11}// 21	22	23	
			, {3203, 6, 4, 11}, {3203, 6, 5, 11}, {3203, 5, 6, 11}// 24	25	26	
			, {3203, 4, 6, 11}, {3203, 3, 6, 11}, {3203, 2, 6, 11}// 27	28	29	
			, {3203, 1, 6, 11}, {3203, -2, 6, 11}, {3203, -3, 6, 11}// 30	31	32	
			, {3203, -4, 6, 11}, {3203, -5, 6, 11}, {1317, 3, 7, 11}// 33	34	35	
			, {1317, 1, 7, 11}, {1317, 4, 7, 11}, {1317, -5, 7, 11}// 36	37	38	
			, {1317, -4, 7, 11}, {1317, 0, 6, 11}, {1317, -1, 6, 11}// 39	40	41	
			, {11314, 6, -1, 37}, {961, 5, -1, 30}, {961, 5, 4, 30}// 42	43	44	
			, {961, 5, 3, 30}, {961, 5, 0, 30}, {961, 5, 1, 30}// 45	46	47	
			, {961, 5, 2, 30}, {11313, 6, 3, 42}, {11313, 5, 3, 42}// 48	49	50	
			, {11313, 4, 3, 42}, {11313, 3, 3, 42}, {11313, 2, 3, 42}// 51	52	53	
			, {11313, 1, 3, 42}, {11313, 0, 3, 42}, {11313, -1, 3, 42}// 54	55	56	
			, {11313, -2, 3, 42}, {11313, -3, 3, 42}, {11313, -4, 3, 42}// 57	58	59	
			, {11313, -5, 3, 42}, {11313, 6, 4, 39}, {11313, 5, 4, 39}// 60	61	62	
			, {11313, 4, 4, 39}, {11313, 3, 4, 39}, {11313, 2, 4, 39}// 63	64	65	
			, {11313, 1, 4, 39}, {11313, 0, 4, 39}, {11313, -1, 4, 39}// 66	67	68	
			, {11313, -2, 4, 39}, {11313, -3, 4, 39}, {11313, -4, 4, 39}// 69	70	71	
			, {11313, -5, 4, 39}, {11313, 6, 5, 36}, {11313, 5, 5, 36}// 72	73	74	
			, {11313, 4, 5, 36}, {11313, 3, 5, 36}, {11313, 2, 5, 36}// 75	76	77	
			, {11313, 1, 5, 36}, {11313, 0, 5, 36}, {11313, -1, 5, 36}// 78	79	80	
			, {11313, -2, 5, 36}, {11313, -3, 5, 36}, {11313, -4, 5, 36}// 81	82	83	
			, {11313, -5, 5, 36}, {11312, 6, 2, 42}, {11312, 5, 2, 42}// 84	85	86	
			, {11312, 4, 2, 42}, {11312, 3, 2, 42}, {11312, 2, 2, 42}// 87	88	89	
			, {11312, 1, 2, 42}, {11312, 0, 2, 42}, {11312, -1, 2, 42}// 90	91	92	
			, {11312, -2, 2, 42}, {11312, -3, 2, 42}, {11312, -4, 2, 42}// 93	94	95	
			, {11312, -5, 2, 42}, {11314, 0, 0, 36}, {11314, 6, 1, 39}// 96	97	98	
			, {11314, 5, 1, 39}, {11314, 4, 1, 39}, {11314, 3, 1, 39}// 99	100	101	
			, {11314, 2, 1, 39}, {11314, 1, 1, 39}, {11314, 0, 1, 39}// 102	103	104	
			, {11314, -1, 1, 39}, {11314, -2, 1, 39}, {11314, -3, 1, 39}// 105	106	107	
			, {11314, -4, 1, 39}, {11314, -5, 1, 39}, {11313, 5, 6, 33}// 108	109	110	
			, {11313, 4, 6, 33}, {11313, 3, 6, 33}, {11313, 2, 6, 33}// 111	112	113	
			, {11313, 1, 6, 33}, {11313, 0, 6, 33}, {11313, -1, 6, 33}// 114	115	116	
			, {11313, -2, 6, 33}, {11313, -3, 6, 33}, {11313, -4, 6, 33}// 117	118	119	
			, {11313, -5, 6, 33}, {11313, 6, 6, 33}, {11314, 6, 0, 36}// 120	121	122	
			, {11314, 5, 0, 36}, {11314, 4, 0, 36}, {11314, 3, 0, 36}// 123	124	125	
			, {11314, 2, 0, 36}, {11314, 1, 0, 36}, {11314, 0, 1, 36}// 126	127	128	
			, {11314, -1, 0, 36}, {11314, -2, 0, 36}, {11314, -3, 0, 36}// 129	130	131	
			, {11314, -4, 0, 36}, {11314, -5, 0, 36}, {11314, 6, -1, 33}// 132	133	134	
			, {11314, 5, -1, 33}, {11314, 4, -1, 33}, {11314, 3, -1, 33}// 135	136	137	
			, {11314, 2, -1, 33}, {11314, 1, -1, 33}, {11314, 0, -1, 33}// 138	139	140	
			, {11314, -1, -1, 33}, {11314, -2, -1, 33}, {11314, -3, -1, 33}// 141	142	143	
			, {11314, -4, -1, 33}, {11314, -5, -1, 33}, {11314, 6, -2, 30}// 144	145	147	
			, {11314, 5, -2, 30}, {11314, 4, -2, 30}, {11314, 3, -2, 30}// 148	149	150	
			, {11314, 2, -2, 30}, {11314, 1, -2, 30}, {11314, 0, -2, 30}// 151	152	153	
			, {11314, -1, -2, 30}, {11314, -2, -2, 30}, {11314, -3, -2, 30}// 154	155	156	
			, {11314, -4, -2, 30}, {11314, -5, -2, 30}, {11314, 5, -3, 27}// 157	158	159	
			, {11314, 4, -3, 27}, {11314, 3, -3, 27}, {11314, 2, -3, 27}// 160	161	162	
			, {11314, 1, -3, 27}, {11314, 0, -3, 27}, {11314, -1, -3, 27}// 163	164	165	
			, {11314, -2, -3, 27}, {11314, -3, -3, 27}, {11314, -4, -3, 27}// 166	167	168	
			, {11314, -5, -3, 27}, {11314, 6, -3, 27}, {2978, 4, 6, 11}// 169	170	173	
			, {2978, -5, 6, 11}, {4154, -4, -2, 17}, {4157, -3, -2, 21}// 174	175	176	
			, {2518, -5, -2, 17}, {4159, 4, -2, 20}, {4163, -3, -2, 17}// 177	178	179	
			, {5354, 3, -2, 17}, {2541, 2, -2, 17}, {2539, 0, 1, 14}// 180	181	182	
			, {4161, -1, 1, 14}, {2444, 1, 1, 14}, {2444, 1, 1, 19}// 183	184	185	
			, {5644, 0, 1, 21}, {2537, -1, 1, 20}, {4154, 3, 3, 11}// 186	187	188	
			, {4154, 3, 0, 11}, {4030, -4, 1, 17}, {2903, -4, 0, 11}// 189	190	191	
			, {3645, -5, 4, 14}, {3645, -5, 4, 11}, {3712, -5, 1, 19}// 192	193	194	
			, {2880, -4, 1, 11}, {2880, -5, 1, 11}, {2720, 1, 2, 14}// 195	196	197	
			, {2720, 0, 2, 14}, {2720, -1, 2, 14}, {2722, 1, 0, 14}// 198	199	200	
			, {2722, 0, 0, 14}, {2722, -1, 0, 14}, {2719, 2, 1, 14}// 201	202	203	
			, {2836, 2, 1, 11}, {2721, -2, 1, 14}, {2724, 2, 0, 14}// 204	205	206	
			, {2840, 2, 2, 14}, {2725, -2, 2, 14}, {2723, -2, 0, 14}// 207	208	209	
			, {2833, 2, 2, 11}, {2831, 1, 1, 11}, {2831, 0, 1, 11}// 210	211	212	
			, {2831, -1, 1, 11}, {2838, -2, 1, 11}, {2837, 1, 2, 11}// 213	214	215	
			, {2837, 0, 2, 11}, {2837, -1, 2, 11}, {2834, -2, 2, 11}// 216	217	218	
			, {2835, 2, 0, 11}, {2839, 1, 0, 11}, {2839, 0, 0, 11}// 219	220	221	
			, {2839, -1, 0, 11}, {2832, -2, 0, 11}, {2880, 4, -2, 11}// 222	223	224	
			, {2880, 3, -2, 11}, {2880, 2, -2, 11}, {2880, -5, -2, 11}// 225	226	227	
			, {2880, -4, -2, 11}, {2880, -3, -2, 11}, {2353, -2, -2, 11}// 228	229	232	
			, {2355, 0, -2, 11}, {515, 1, 5, 11}, {515, -2, 5, 11}// 233	235	236	
			, {515, 4, 5, 11}, {515, -4, 5, 11}, {515, 2, -3, 11}// 237	238	239	
			, {515, 1, -3, 11}, {515, 0, -3, 11}, {515, -1, -3, 11}// 240	241	242	
			, {515, -2, -3, 11}, {515, -3, -3, 11}, {515, -4, -3, 11}// 243	244	245	
			, {515, 4, -3, 11}, {515, 3, -3, 11}, {514, -6, -3, 11}// 246	247	252	
			, {512, 5, -3, 11}, {512, 5, 5, 11}, {513, 5, 5, 11}// 253	254	255	
			, {513, -6, 5, 11}, {516, -6, 3, 11}, {516, -6, 4, 11}// 256	257	258	
			, {516, -6, 0, 11}, {516, -6, -1, 11}, {516, 5, 0, 11}// 259	260	261	
			, {516, 5, 3, 11}, {516, 5, -1, 11}, {516, 5, 4, 11}// 262	263	264	
			, {518, 5, -2, 11}, {518, -6, -2, 11}, {517, -5, 5, 11}// 267	268	269	
			, {517, -5, -3, 11}, {1181, 5, -2, 11}, {1181, 4, -2, 11}// 270	271	272	
			, {1181, 3, -2, 11}, {1181, 2, -2, 11}, {1181, 1, -2, 11}// 273	274	275	
			, {1181, 0, -2, 11}, {1181, -1, -2, 11}, {1181, -2, -2, 11}// 276	277	278	
			, {1181, -3, -2, 11}, {1181, -4, -2, 11}, {1181, -5, -2, 11}// 279	280	281	
			, {1181, 5, -1, 11}, {1181, 5, 5, 11}, {1181, 5, 4, 11}// 282	283	284	
			, {1181, 5, 3, 11}, {1181, 5, 2, 11}, {1181, 5, 1, 11}// 285	286	287	
			, {1181, 5, 0, 11}, {1181, 4, 5, 11}, {1181, 4, 4, 11}// 288	289	290	
			, {1181, 4, 3, 11}, {1181, 4, 2, 11}, {1181, 4, 1, 11}// 291	292	293	
			, {1181, 4, 0, 11}, {1181, 3, 5, 11}, {1181, 3, 4, 11}// 294	295	296	
			, {1181, 3, 3, 11}, {1181, 3, 2, 11}, {1181, 3, 1, 11}// 297	298	299	
			, {1181, 3, 0, 11}, {1181, 2, 5, 11}, {1181, 2, 4, 11}// 300	301	302	
			, {1181, 2, 3, 11}, {1181, 2, 2, 11}, {1181, 2, 1, 11}// 303	304	305	
			, {1181, 2, 0, 11}, {1181, 1, 5, 11}, {1181, 1, 4, 11}// 306	307	308	
			, {1181, 1, 3, 11}, {1181, 1, 2, 11}, {1181, 1, 1, 11}// 309	310	311	
			, {1181, 1, 0, 11}, {1181, 0, 5, 11}, {1181, 0, 4, 11}// 312	313	314	
			, {1181, 0, 3, 11}, {1181, 0, 2, 11}, {1181, 0, 1, 11}// 315	316	317	
			, {1181, 0, 0, 11}, {1181, -1, 5, 11}, {1181, -1, 4, 11}// 318	319	320	
			, {1181, -1, 3, 11}, {1181, -1, 2, 11}, {1181, -1, 1, 11}// 321	322	323	
			, {1181, -1, 0, 11}, {1181, -2, 5, 11}, {1181, -2, 4, 11}// 324	325	326	
			, {1181, -2, 3, 11}, {1181, -2, 2, 11}, {1181, -2, 1, 11}// 327	328	329	
			, {1181, -2, 0, 11}, {1181, -3, 5, 11}, {1181, -3, 4, 11}// 330	331	332	
			, {1181, -3, 3, 11}, {1181, -3, 2, 11}, {1181, -3, 1, 11}// 333	334	335	
			, {1181, -3, 0, 11}, {1181, -4, 5, 11}, {1181, -4, 4, 11}// 336	337	338	
			, {1181, -4, 3, 11}, {1181, -4, 2, 11}, {1181, -4, 1, 11}// 339	340	341	
			, {1181, -4, 0, 11}, {1181, -5, 5, 11}, {1181, -5, 4, 11}// 342	343	344	
			, {1181, -5, 3, 11}, {1181, -5, 2, 11}, {1181, -5, 1, 11}// 345	346	347	
			, {1181, -5, 0, 11}, {1181, 4, -1, 11}, {1181, 3, -1, 11}// 348	349	350	
			, {1181, 2, -1, 11}, {1181, 1, -1, 11}, {1181, 0, -1, 11}// 351	352	353	
			, {1181, -1, -1, 11}, {1181, -2, -1, 11}, {1181, -3, -1, 11}// 354	355	356	
			, {1181, -4, -1, 11}, {1181, -5, -1, 11}, {3299, 0, -5, 0}// 357	358	367	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MaginciaBakerShop_AddonDeed();
			}
		}

		[ Constructable ]
		public MaginciaBakerShop_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6093, 6, -2, 11, 0, -1, "flowers", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6093, 6, -1, 11, 0, -1, "flowers", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6093, 6, 0, 11, 0, -1, "flowers", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6093, 6, 1, 11, 0, -1, "flowers", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6093, 6, 2, 11, 0, -1, "flowers", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6093, 6, 3, 11, 0, -1, "flowers", 1);// 6
			AddComplexComponent( (BaseAddon) this, 6093, 6, 4, 11, 0, -1, "flowers", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6093, 6, 5, 11, 0, -1, "flowers", 1);// 8
			AddComplexComponent( (BaseAddon) this, 6093, 5, 6, 11, 0, -1, "flowers", 1);// 9
			AddComplexComponent( (BaseAddon) this, 6093, 4, 6, 11, 0, -1, "flowers", 1);// 10
			AddComplexComponent( (BaseAddon) this, 6093, 3, 6, 11, 0, -1, "flowers", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6093, 2, 6, 11, 0, -1, "flowers", 1);// 12
			AddComplexComponent( (BaseAddon) this, 6093, 1, 6, 11, 0, -1, "flowers", 1);// 13
			AddComplexComponent( (BaseAddon) this, 6093, -2, 6, 11, 0, -1, "flowers", 1);// 14
			AddComplexComponent( (BaseAddon) this, 6093, -3, 6, 11, 0, -1, "flowers", 1);// 15
			AddComplexComponent( (BaseAddon) this, 6093, -4, 6, 11, 0, -1, "flowers", 1);// 16
			AddComplexComponent( (BaseAddon) this, 6093, -5, 6, 11, 0, -1, "flowers", 1);// 17
			AddComplexComponent( (BaseAddon) this, 41188, 0, -3, 25, 66, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 2980, -5, 6, 11, 0, -1, "The New Baker's Dozen", 1);// 171
			AddComplexComponent( (BaseAddon) this, 2594, 4, 6, 24, 0, 29, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 2352, -1, -2, 11, 0, 47, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 2352, 1, -2, 11, 0, 47, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 519, 2, 5, 11, 0, 26, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 522, 5, 2, 11, 0, 27, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 522, 5, 1, 11, 0, 27, "", 1);// 249
			AddComplexComponent( (BaseAddon) this, 522, -6, 2, 11, 0, 27, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 522, -6, 1, 11, 0, 27, "", 1);// 251
			AddComplexComponent( (BaseAddon) this, 519, 3, 5, 11, 0, 26, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 519, -3, 5, 11, 0, 26, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 6093, 6, -3, 11, 0, -1, "flowers", 1);// 359
			AddComplexComponent( (BaseAddon) this, 41188, 0, -4, 34, 66, -1, "", 1);// 360
			AddComplexComponent( (BaseAddon) this, 41188, 1, -4, 30, 66, -1, "", 1);// 361
			AddComplexComponent( (BaseAddon) this, 41188, 0, -4, 27, 66, -1, "", 1);// 362
			AddComplexComponent( (BaseAddon) this, 41188, -1, -4, 10, 66, -1, "", 1);// 363
			AddComplexComponent( (BaseAddon) this, 41188, 2, -5, 26, 66, -1, "", 1);// 364
			AddComplexComponent( (BaseAddon) this, 41188, 1, -5, 33, 66, -1, "", 1);// 365
			AddComplexComponent( (BaseAddon) this, 41188, 1, -5, 16, 66, -1, "", 1);// 366
			AddComplexComponent( (BaseAddon) this, 41188, 1, -6, 22, 66, -1, "", 1);// 368
			AddComplexComponent( (BaseAddon) this, 6093, 6, -4, 11, 0, -1, "flowers", 1);// 369
			AddComplexComponent( (BaseAddon) this, 6093, 6, -5, 11, 0, -1, "flowers", 1);// 370

		}

		public MaginciaBakerShop_Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class MaginciaBakerShop_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MaginciaBakerShop_Addon();
			}
		}

		[Constructable]
		public MaginciaBakerShop_AddonDeed()
		{
			Name = "MaginciaBakerShop_";
		}

		public MaginciaBakerShop_AddonDeed( Serial serial ) : base( serial )
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