
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
	public class SummerEvent3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12578, 38, 27, 0}, {3480, 50, 25, 3}, {12580, 50, 25, 3}// 1	2	3	
			, {9966, 38, 27, 0}, {12580, 49, 15, 3}, {3480, 49, 15, 3}// 4	6	7	
			, {9966, 53, 19, 3}, {12578, 53, 19, 3}, {9966, 42, 19, 3}// 8	9	10	
			, {12578, 42, 19, 3}, {3480, 35, 25, 3}, {12580, 35, 25, 3}// 11	22	23	
			, {2750, 26, 4, 3}, {2750, 22, 4, 3}, {2750, 23, 4, 3}// 24	25	26	
			, {2808, 27, 4, 3}, {2750, 25, 4, 3}, {2750, 24, 4, 3}// 27	28	29	
			, {2750, 22, 7, 3}, {2809, 22, 8, 3}, {2750, 22, 5, 3}// 30	31	32	
			, {2750, 22, 6, 3}, {2808, 27, 7, 3}, {2750, 23, 7, 3}// 33	34	35	
			, {2754, 27, 8, 3}, {2750, 24, 7, 3}, {2809, 23, 8, 3}// 36	37	38	
			, {2809, 26, 8, 3}, {2750, 25, 7, 3}, {2750, 26, 7, 3}// 39	40	41	
			, {2809, 24, 8, 3}, {2809, 25, 8, 3}, {2750, 23, 5, 3}// 42	43	44	
			, {2808, 27, 5, 3}, {2808, 27, 6, 3}, {2750, 23, 6, 3}// 45	46	47	
			, {2750, 25, 6, 3}, {2750, 24, 6, 3}, {2750, 26, 5, 3}// 48	49	50	
			, {2750, 24, 5, 3}, {2750, 26, 6, 3}, {2750, 25, 5, 3}// 51	52	53	
			, {12580, 34, 18, 3}, {3480, 34, 18, 3}, {11535, 34, 13, 3}// 55	56	57	
			, {7107, 29, 11, 3}, {2749, 26, -1, 3}, {2749, 25, -1, 3}// 58	60	61	
			, {2749, 24, -1, 3}, {2749, 23, -1, 3}, {2749, 22, -1, 3}// 62	63	64	
			, {2808, 27, -1, 3}, {2754, 27, 0, 3}, {2809, 22, 0, 3}// 65	66	67	
			, {2809, 23, 0, 3}, {2809, 26, 0, 3}, {2809, 24, 0, 3}// 68	69	70	
			, {2809, 25, 0, 3}, {2749, 26, -2, 3}, {2749, 26, -3, 3}// 71	72	73	
			, {2749, 26, -4, 3}, {2749, 26, -5, 3}, {2749, 25, -2, 3}// 74	75	76	
			, {2749, 25, -3, 3}, {2749, 25, -4, 3}, {2749, 25, -5, 3}// 77	78	79	
			, {2749, 24, -2, 3}, {2749, 24, -3, 3}, {2749, 24, -4, 3}// 80	81	82	
			, {2749, 24, -5, 3}, {2749, 23, -2, 3}, {2749, 23, -3, 3}// 83	84	85	
			, {2749, 23, -4, 3}, {2749, 23, -5, 3}, {2749, 22, -2, 3}// 86	87	88	
			, {2749, 22, -3, 3}, {2749, 22, -4, 3}, {2749, 22, -5, 3}// 89	90	91	
			, {2757, 27, -6, 3}, {2807, 23, -6, 3}, {2808, 27, -5, 3}// 92	93	94	
			, {2808, 27, -3, 3}, {2807, 25, -6, 3}, {2808, 27, -2, 3}// 95	96	97	
			, {2808, 27, -4, 3}, {2807, 26, -6, 3}, {2807, 22, -6, 3}// 98	99	100	
			, {2807, 24, -6, 3}, {2750, 22, 3, 3}, {2750, 25, 3, 3}// 101	102	103	
			, {2808, 27, 3, 3}, {2750, 23, 3, 3}, {2750, 24, 3, 3}// 104	105	106	
			, {2750, 26, 3, 3}, {2757, 27, 2, 3}, {2807, 23, 2, 3}// 107	108	109	
			, {2807, 25, 2, 3}, {2807, 26, 2, 3}, {2807, 22, 2, 3}// 110	111	112	
			, {2807, 24, 2, 3}, {5, 36, -1, 9}, {4, 35, -1, 9}// 113	118	120	
			, {2809, 25, -8, 3}, {2808, 37, -7, 9}, {2750, 26, -10, 3}// 123	124	125	
			, {2750, 26, -11, 3}, {2750, 22, -10, 3}, {2750, 23, -10, 3}// 126	127	128	
			, {2750, 23, -12, 3}, {2750, 26, -12, 3}, {2750, 22, -12, 3}// 129	130	131	
			, {2809, 26, -8, 3}, {2750, 24, -9, 3}, {2809, 36, -4, 9}// 132	133	134	
			, {2750, 25, -10, 3}, {2808, 27, -12, 3}, {2750, 34, -7, 9}// 135	136	137	
			, {2807, 35, -8, 9}, {2808, 37, -5, 9}, {2750, 36, -5, 9}// 138	139	140	
			, {2750, 36, -6, 9}, {2750, 36, -7, 9}, {2809, 35, -4, 9}// 141	142	143	
			, {2750, 35, -7, 9}, {2754, 37, -4, 9}, {2807, 34, -8, 9}// 144	145	146	
			, {2807, 36, -8, 9}, {2750, 35, -5, 9}, {2806, 33, -6, 9}// 147	148	149	
			, {2757, 37, -8, 9}, {2806, 33, -7, 9}, {2756, 33, -4, 9}// 150	151	152	
			, {2755, 33, -8, 9}, {2750, 34, -5, 9}, {2750, 22, -9, 3}// 153	154	155	
			, {2750, 24, -11, 3}, {2754, 27, -8, 3}, {2809, 23, -8, 3}// 156	157	158	
			, {2750, 34, -6, 9}, {2808, 27, -9, 3}, {2750, 35, -6, 9}// 159	160	161	
			, {2750, 25, -9, 3}, {2750, 23, -9, 3}, {2750, 22, -11, 3}// 162	163	164	
			, {2750, 23, -11, 3}, {2750, 24, -12, 3}, {2806, 33, -5, 9}// 165	166	167	
			, {2750, 25, -11, 3}, {2809, 22, -8, 3}, {2809, 34, -4, 9}// 168	169	170	
			, {2750, 26, -9, 3}, {2808, 27, -10, 3}, {2808, 27, -11, 3}// 171	172	173	
			, {39871, 24, -7, 3}, {2809, 24, -8, 3}, {2750, 24, -10, 3}// 175	177	181	
			, {2808, 37, -6, 9}, {2750, 25, -12, 3}, {2750, 26, -13, 3}// 184	185	194	
			, {2750, 24, -13, 3}, {2750, 22, -13, 3}, {2807, 23, -14, 3}// 195	196	197	
			, {2807, 22, -14, 3}, {2807, 26, -14, 3}, {2808, 27, -13, 3}// 198	199	200	
			, {2750, 25, -13, 3}, {2807, 24, -14, 3}, {2757, 27, -14, 3}// 201	202	203	
			, {2807, 25, -14, 3}, {2750, 23, -13, 3}, {12412, 25, -17, 8}// 204	205	206	
			, {12417, 26, -19, 8}, {12420, 22, -21, 8}, {12418, 25, -19, 8}// 207	208	209	
			, {12413, 24, -17, 8}, {11535, 29, -15, 8}, {12414, 26, -18, 8}// 210	212	214	
			, {12419, 24, -19, 8}, {12411, 26, -17, 8}, {12421, 26, -21, 8}// 216	218	219	
			, {12420, 27, -21, 8}, {12420, 25, -21, 8}, {12421, 24, -21, 8}// 221	223	224	
			, {12416, 24, -18, 8}, {12415, 25, -18, 8}, {9966, 19, 25, 3}// 226	227	228	
			, {3480, 15, 27, 6}, {12580, 15, 27, 6}, {12578, 13, 21, 3}// 229	230	231	
			, {9966, 13, 21, 3}, {12578, 19, 25, 3}, {3480, 7, 21, 3}// 232	233	234	
			, {12580, 7, 21, 3}, {2806, 21, 4, 3}, {2806, 21, 7, 3}// 235	236	237	
			, {2756, 21, 8, 3}, {2806, 21, 6, 3}, {2806, 21, 5, 3}// 238	239	240	
			, {3480, 17, 18, 3}, {11535, 14, 13, 3}, {12580, 17, 18, 3}// 242	243	245	
			, {2806, 21, -1, 3}, {2756, 21, 0, 3}, {2755, 21, -6, 3}// 246	247	248	
			, {2806, 21, -2, 3}, {2806, 21, -5, 3}, {2806, 21, -4, 3}// 249	250	251	
			, {2806, 21, -3, 3}, {2806, 21, 3, 3}, {2755, 21, 2, 3}// 252	253	254	
			, {4072, 10, 1, 3}, {4077, 11, 3, 3}, {4074, 10, 2, 3}// 255	256	257	
			, {4071, 9, 1, 3}, {4075, 11, 1, 3}, {4078, 11, 2, 3}// 258	259	260	
			, {4070, 9, 2, 3}, {4070, 9, 2, 3}, {4073, 9, 3, 3}// 261	262	263	
			, {4073, 9, 3, 3}, {4078, 11, 2, 3}, {4071, 9, 1, 3}// 264	265	266	
			, {4076, 10, 3, 3}, {2754, 16, -4, 9}, {2756, 21, -8, 3}// 267	268	269	
			, {2757, 16, -8, 9}, {2750, 15, -5, 9}, {2809, 15, -4, 9}// 270	271	272	
			, {2750, 14, -7, 9}, {2750, 15, -7, 9}, {4076, 10, 3, 3}// 273	274	275	
			, {2808, 16, -5, 9}, {2807, 14, -8, 9}, {2750, 13, -7, 9}// 276	277	278	
			, {2808, 16, -6, 9}, {2806, 12, -5, 9}, {2750, 14, -6, 9}// 279	280	281	
			, {2750, 13, -6, 9}, {2750, 13, -5, 9}, {2808, 16, -7, 9}// 282	283	284	
			, {2809, 13, -4, 9}, {2806, 12, -7, 9}, {2750, 15, -6, 9}// 285	286	287	
			, {2806, 12, -6, 9}, {2806, 21, -9, 3}, {2806, 21, -12, 3}// 288	289	290	
			, {2750, 14, -5, 9}, {2807, 15, -8, 9}, {2806, 21, -11, 3}// 291	292	293	
			, {2806, 21, -10, 3}, {2807, 13, -8, 9}, {4075, 11, 1, 3}// 294	295	296	
			, {2755, 12, -8, 9}, {2756, 12, -4, 9}, {2809, 14, -4, 9}// 300	301	302	
			, {4074, 10, 2, 3}, {4072, 10, 1, 3}, {4077, 11, 3, 3}// 303	304	305	
			, {2750, 15, -23, 3}, {2750, 12, -20, 3}, {2806, 10, -19, 3}// 310	311	312	
			, {2807, 12, -24, 3}, {2806, 10, -20, 3}, {2809, 15, -18, 3}// 313	314	315	
			, {2750, 15, -21, 3}, {2750, 13, -23, 3}, {2756, 10, -18, 3}// 316	317	318	
			, {2808, 16, -21, 3}, {2809, 12, -18, 3}, {2750, 13, -19, 3}// 319	320	321	
			, {2750, 12, -19, 3}, {2754, 16, -18, 3}, {2750, 14, -22, 3}// 322	323	324	
			, {2750, 13, -21, 3}, {2757, 16, -24, 3}, {2750, 11, -22, 3}// 325	326	327	
			, {2809, 13, -18, 3}, {2750, 14, -19, 3}, {2750, 15, -22, 3}// 328	329	330	
			, {2750, 11, -21, 3}, {2809, 11, -18, 3}, {2755, 10, -24, 3}// 331	332	333	
			, {2808, 16, -19, 3}, {2808, 16, -23, 3}, {2750, 11, -19, 3}// 334	335	336	
			, {2750, 14, -20, 3}, {2750, 12, -22, 3}, {2806, 21, -13, 3}// 337	338	339	
			, {2806, 10, -21, 3}, {2807, 15, -24, 3}, {2750, 13, -20, 3}// 340	341	342	
			, {2808, 16, -20, 3}, {2750, 12, -23, 3}, {2750, 15, -19, 3}// 343	344	345	
			, {2807, 14, -24, 3}, {2750, 12, -21, 3}, {2750, 11, -23, 3}// 346	347	348	
			, {2750, 14, -21, 3}, {12421, 21, -21, 8}, {2750, 15, -20, 3}// 349	352	353	
			, {11535, 20, -15, 7}, {2755, 21, -14, 3}, {2750, 14, -23, 3}// 354	355	356	
			, {2808, 16, -22, 3}, {2806, 10, -22, 3}, {2807, 13, -24, 3}// 357	360	361	
			, {2750, 11, -20, 3}, {2806, 10, -23, 3}, {2750, 13, -22, 3}// 364	365	366	
			, {2807, 11, -24, 3}, {2809, 14, -18, 3}, {9966, -9, 27, 3}// 367	368	370	
			, {3480, -9, 21, 3}, {12580, -9, 21, 3}, {12578, -9, 27, 3}// 371	372	373	
			, {12580, -2, 13, 3}, {3480, -2, 13, 3}, {9966, -6, 15, 3}// 374	375	376	
			, {9966, 1, 19, 3}, {12578, 1, 19, 3}, {12578, -6, 15, 3}// 377	378	379	
			, {12578, -9, 5, 3}, {9966, -9, 5, 3}, {7045, -10, -2, 3}// 380	381	382	
			, {12795, -9, -3, 3}, {3221, -10, -10, 3}, {7065, -8, -4, 3}// 383	384	385	
			, {7054, -10, -3, 3}, {7054, -9, -4, 3}, {7054, -9, -2, 3}// 386	387	388	
			, {7046, -10, -4, 3}, {7054, -8, -3, 3}, {7042, -8, -2, 3}// 389	390	391	
			, {3231, -21, 20, 4}, {3235, -21, 21, 4}, {3232, -21, 21, 4}// 392	393	394	
			, {9966, -14, 21, 3}, {12578, -14, 21, 3}, {3236, -20, 21, 4}// 395	396	397	
			, {3232, -20, 20, 4}, {3231, -24, 9, 4}, {3232, -23, 9, 4}// 398	399	400	
			, {7054, -18, 9, 3}, {7046, -20, 8, 3}, {7054, -20, 9, 3}// 401	402	403	
			, {7054, -19, 8, 3}, {7054, -19, 10, 3}, {7065, -18, 8, 3}// 404	405	406	
			, {9966, -25, 18, 3}, {12578, -25, 18, 3}, {3236, -16, 4, 4}// 407	408	409	
			, {3235, -24, 10, 4}, {3232, -17, 4, 4}, {3235, -17, 4, 4}// 410	411	412	
			, {3221, -26, 4, 3}, {12795, -19, 9, 3}, {7045, -20, 10, 3}// 413	414	415	
			, {3480, -17, 16, 3}, {12580, -17, 16, 3}, {7042, -18, 10, 3}// 416	417	418	
			, {3221, -21, 13, 3}, {3232, -24, 10, 4}, {3236, -23, 10, 4}// 419	420	421	
			, {12578, -17, -5, 3}, {9966, -17, -5, 3}, {3221, -19, -1, 3}// 422	424	425	
			, {3231, -17, 3, 4}, {3232, -16, 3, 4}, {7054, -29, 21, 3}// 426	427	428	
			, {7045, -29, 22, 3}, {7054, -27, 21, 3}, {12795, -28, 21, 3}// 429	430	431	
			, {7065, -27, 20, 3}, {7054, -28, 22, 3}, {7054, -28, 20, 3}// 432	433	434	
			, {7046, -29, 20, 3}, {7042, -27, 22, 3}, {3231, -36, 22, 3}// 435	436	437	
			, {3232, -35, 22, 3}, {3236, -35, 23, 3}, {3232, -36, 23, 3}// 438	439	440	
			, {3235, -36, 23, 3}, {3221, -37, 24, 3}, {3235, -38, 16, 3}// 441	442	443	
			, {12578, -33, 13, 3}, {7054, -38, 4, 3}, {3236, -37, 16, 3}// 444	445	447	
			, {12578, -31, 6, 4}, {9966, -31, 6, 4}, {3231, -38, 15, 3}// 450	451	453	
			, {3232, -37, 15, 3}, {3231, -31, 8, 4}, {3232, -30, 8, 4}// 454	455	456	
			, {3236, -30, 9, 4}, {3232, -31, 9, 4}, {3235, -31, 9, 4}// 457	458	459	
			, {7045, -39, 4, 3}, {7042, -37, 4, 3}, {9966, -33, 13, 3}// 460	461	462	
			, {3232, -38, 16, 3}, {3232, -41, 1, 4}, {3231, -42, 1, 4}// 463	464	465	
			, {12795, -38, 3, 3}, {3235, -42, 2, 4}, {9966, -28, -2, 3}// 466	467	468	
			, {3232, -42, 2, 4}, {3236, -41, 2, 4}, {12578, -28, -2, 3}// 469	470	471	
			, {7046, -39, 2, 3}, {7054, -39, 3, 3}, {7054, -37, 3, 3}// 472	474	475	
			, {7054, -38, 2, 3}, {7065, -37, 2, 3}, {12795, -48, 20, 3}// 476	477	478	
			, {7054, -49, 20, 3}, {7054, -48, 21, 3}, {7045, -49, 21, 3}// 479	480	481	
			, {7042, -47, 21, 3}, {7054, -47, 20, 3}, {7046, -49, 19, 3}// 484	485	486	
			, {7054, -48, 19, 3}, {3232, -47, 17, 3}, {3236, -47, 18, 3}// 487	488	489	
			, {12578, -45, 15, 3}, {3232, -48, 18, 3}, {7065, -47, 19, 3}// 490	491	492	
			, {9966, -45, 15, 3}, {3231, -48, 17, 3}, {3235, -48, 18, 3}// 493	495	496	
			, {3221, -52, 18, 3}// 497	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SummerEvent3AddonDeed();
			}
		}

		[ Constructable ]
		public SummerEvent3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8734, 45, 18, 3, 2498, -1, "Enchanted Crystal", 1);// 5
			AddComplexComponent( (BaseAddon) this, 14678, 38, -10, 8, 0, 0, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 14678, 38, -5, 8, 0, 0, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 14678, 38, -4, 8, 0, 0, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 14678, 38, -3, 8, 0, 0, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 14678, 38, -8, 8, 0, 0, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 14678, 38, -9, 8, 0, 0, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 6571, 38, -2, 29, 0, 0, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 6571, 38, -11, 29, 0, 0, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 39879, 40, -25, 3, 0, -1, "Vase", 1);// 20
			AddComplexComponent( (BaseAddon) this, 39879, 40, -18, 3, 0, -1, "Vase", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3049, 31, 13, 3, 0, -1, "Hill of Aine, Sanctuary", 1);// 54
			AddComplexComponent( (BaseAddon) this, 8610, 30, 12, 3, 0, -1, "no line of sight", 1);// 59
			AddComplexComponent( (BaseAddon) this, 14662, 33, -11, 8, 0, 0, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 14662, 36, -2, 8, 0, 0, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 14662, 33, -2, 8, 0, 0, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 14662, 34, -2, 8, 0, 0, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 14662, 36, -11, 8, 0, 0, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 14662, 37, -2, 8, 0, 0, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 14662, 37, -11, 8, 0, 0, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 6571, 34, -9, 14, 0, 0, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 39879, 32, -10, 8, 0, -1, "Vase", 1);// 176
			AddComplexComponent( (BaseAddon) this, 6571, 32, -11, 29, 0, 0, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 14662, 34, -11, 8, 0, 0, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 6571, 34, -4, 14, 0, 0, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 6571, 32, -2, 29, 0, 0, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 39879, 32, -3, 8, 0, -1, "Vase", 1);// 183
			AddComplexComponent( (BaseAddon) this, 14678, 29, -21, 8, 0, 0, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 14662, 22, -22, 8, 0, 0, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 14678, 29, -20, 8, 0, 0, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 14662, 26, -22, 8, 0, 0, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 14678, 29, -17, 8, 0, 0, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 14662, 28, -22, 8, 0, 0, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 14662, 23, -22, 8, 0, 0, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 14662, 27, -22, 8, 0, 0, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 39879, 33, -25, 3, 0, -1, "Vase", 1);// 211
			AddComplexComponent( (BaseAddon) this, 6571, 24, -22, 30, 0, 0, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 6571, 29, -22, 30, 0, 0, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 6571, 25, -22, 30, 0, 0, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 6571, 22, -18, 14, 0, 0, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 6571, 27, -18, 14, 0, 0, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 14678, 29, -18, 8, 0, 0, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 3049, 19, 13, 3, 0, -1, "Hill of Aine, Sanctuary", 1);// 241
			AddComplexComponent( (BaseAddon) this, 8610, 19, 12, 3, 0, -1, "no line of sight", 1);// 244
			AddComplexComponent( (BaseAddon) this, 39879, 11, -10, 8, 0, -1, "Vase", 1);// 297
			AddComplexComponent( (BaseAddon) this, 6571, 15, -9, 14, 0, 0, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 6571, 15, -4, 14, 0, 0, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 39879, 17, -3, 8, 0, -1, "Vase", 1);// 306
			AddComplexComponent( (BaseAddon) this, 14662, 21, -22, 8, 0, 0, "", 1);// 307
			AddComplexComponent( (BaseAddon) this, 14678, 20, -17, 8, 0, 0, "", 1);// 308
			AddComplexComponent( (BaseAddon) this, 14678, 20, -18, 8, 0, 0, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 39879, 9, -25, 3, 0, -1, "Vase", 1);// 350
			AddComplexComponent( (BaseAddon) this, 39879, 17, -27, 3, 0, -1, "Vase", 1);// 351
			AddComplexComponent( (BaseAddon) this, 14678, 20, -20, 8, 0, 0, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 39879, 7, -17, 3, 0, -1, "Vase", 1);// 359
			AddComplexComponent( (BaseAddon) this, 6571, 20, -22, 30, 0, 0, "", 1);// 362
			AddComplexComponent( (BaseAddon) this, 14678, 20, -21, 8, 0, 0, "", 1);// 363
			AddComplexComponent( (BaseAddon) this, 8734, -7, 26, 3, 2498, -1, "Enchanted Crystal", 1);// 369
			AddComplexComponent( (BaseAddon) this, 6868, -23, 0, 4, 2415, -1, "", 1);// 423
			AddComplexComponent( (BaseAddon) this, 6868, -40, 14, 4, 2415, -1, "", 1);// 446
			AddComplexComponent( (BaseAddon) this, 6868, -30, 9, 5, 2415, -1, "", 1);// 448
			AddComplexComponent( (BaseAddon) this, 6868, -40, 8, 15, 2415, -1, "", 1);// 449
			AddComplexComponent( (BaseAddon) this, 6868, -38, 11, 19, 2415, -1, "", 1);// 452
			AddComplexComponent( (BaseAddon) this, 6868, -42, 2, 4, 2415, -1, "", 1);// 473
			AddComplexComponent( (BaseAddon) this, 6868, -50, 23, 4, 2415, -1, "", 1);// 482
			AddComplexComponent( (BaseAddon) this, 6868, -45, 27, 3, 2415, -1, "", 1);// 483
			AddComplexComponent( (BaseAddon) this, 6868, -48, 12, 4, 2415, -1, "", 1);// 494

		}

		public SummerEvent3Addon( Serial serial ) : base( serial )
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

	public class SummerEvent3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SummerEvent3Addon();
			}
		}

		[Constructable]
		public SummerEvent3AddonDeed()
		{
			Name = "SummerEvent3";
		}

		public SummerEvent3AddonDeed( Serial serial ) : base( serial )
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