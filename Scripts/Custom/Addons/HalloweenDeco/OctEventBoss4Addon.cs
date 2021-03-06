
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
	public class OctEventBoss4Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1339, 9, 11, 0}, {3792, 16, 12, 0}, {1339, 11, 9, 0}// 7	8	9	
			, {1339, 8, 11, 0}, {1339, 16, 10, 0}, {1339, 10, 8, 0}// 10	11	12	
			, {4654, 3, 4, 1}, {1339, 11, 8, 0}, {4520, 5, 5, 0}// 13	14	15	
			, {1339, 15, 10, 0}, {1339, 14, 7, 0}, {6659, 13, 2, 0}// 16	18	19	
			, {1339, 10, 10, 0}, {1339, 14, 9, 0}, {12788, 3, 2, 0}// 20	21	22	
			, {577, 7, 7, 0}, {12788, 5, 2, 0}, {12788, 7, 4, 0}// 23	24	25	
			, {578, 12, 2, 0}, {1339, 8, 8, 0}, {1339, 16, 5, 0}// 26	27	28	
			, {577, 5, 11, 0}, {1339, 18, 5, 0}, {577, 6, 11, 0}// 29	30	31	
			, {12788, 7, 2, 0}, {1339, 17, 6, 0}, {577, 9, 7, 0}// 32	33	34	
			, {4717, 3, 4, 0}, {12788, 8, 3, 0}, {6934, 6, 3, 0}// 35	36	37	
			, {1339, 13, 3, 0}, {578, 12, 5, 0}, {580, 6, 7, 0}// 38	39	40	
			, {6883, 3, 3, 0}, {12788, 4, 7, 0}, {1339, 13, 9, 0}// 41	43	44	
			, {578, 12, 3, 0}, {6939, 8, 3, 0}, {12791, 6, 2, 0}// 45	46	47	
			, {12788, 5, 3, 0}, {1339, 18, 3, 0}, {12792, 9, 3, 0}// 48	49	50	
			, {12788, 7, 5, 0}, {12788, 3, 3, 0}, {1339, 7, 9, 0}// 51	52	53	
			, {1339, 11, 11, 0}, {1339, 7, 11, 0}, {1339, 9, 8, 0}// 54	55	56	
			, {12788, 10, 3, 0}, {12788, 4, 9, 0}, {1339, 11, 10, 0}// 57	58	59	
			, {12788, 4, 6, 0}, {1339, 12, 9, 0}, {1339, 3, 12, 0}// 60	61	62	
			, {1339, 13, 10, 0}, {12788, 5, 5, 0}, {1339, 17, 3, 0}// 63	64	65	
			, {12788, 3, 4, 0}, {1339, 15, 5, 0}, {577, 4, 11, 0}// 66	67	68	
			, {1339, 15, 9, 0}, {1339, 14, 2, 0}, {1339, 15, 4, 0}// 69	70	71	
			, {1339, 17, 2, 0}, {1339, 15, 2, 0}, {1339, 15, 8, 0}// 72	73	74	
			, {1339, 13, 2, 0}, {1339, 14, 4, 0}, {1339, 18, 2, 0}// 75	76	77	
			, {1339, 15, 11, 0}, {1339, 15, 3, 0}, {1339, 14, 11, 0}// 78	79	80	
			, {1339, 13, 5, 0}, {1339, 17, 9, 0}, {1339, 14, 5, 0}// 81	82	83	
			, {1339, 13, 6, 0}, {1339, 15, 6, 0}, {1339, 16, 9, 0}// 84	85	86	
			, {1339, 16, 7, 0}, {1339, 17, 8, 0}, {1339, 16, 11, 0}// 87	88	89	
			, {1339, 16, 3, 0}, {1339, 18, 9, 0}, {1339, 18, 7, 0}// 90	91	92	
			, {1339, 17, 10, 0}, {1339, 16, 8, 0}, {1339, 18, 11, 0}// 93	94	95	
			, {12788, 10, 5, 0}, {1339, 18, 6, 0}, {1339, 18, 8, 0}// 96	97	98	
			, {1339, 14, 8, 0}, {1339, 13, 7, 0}, {1339, 7, 10, 0}// 99	100	101	
			, {1304, 12, 7, 0}, {1304, 12, 6, 0}, {1304, 12, 5, 0}// 102	103	104	
			, {1304, 12, 4, 0}, {1304, 12, 3, 0}, {1304, 12, 2, 0}// 105	106	107	
			, {1304, 11, 7, 0}, {1304, 11, 6, 0}, {1304, 11, 5, 0}// 108	109	110	
			, {1304, 11, 4, 0}, {1304, 11, 3, 0}, {1304, 11, 2, 0}// 111	112	113	
			, {12791, 8, 7, 0}, {1339, 15, 7, 0}, {1304, 10, 7, 0}// 114	115	116	
			, {1304, 10, 6, 0}, {12788, 10, 4, 0}, {12788, 9, 5, 0}// 117	118	119	
			, {1339, 10, 11, 0}, {1339, 12, 8, 0}, {1304, 9, 7, 0}// 120	121	122	
			, {1304, 9, 6, 0}, {12788, 9, 2, 0}, {1339, 17, 7, 0}// 123	124	125	
			, {1304, 8, 6, 0}, {1339, 13, 11, 0}, {1339, 14, 6, 0}// 126	127	128	
			, {12788, 8, 2, 0}, {12788, 7, 3, 0}, {1304, 6, 11, 0}// 129	130	131	
			, {1304, 6, 10, 0}, {1304, 6, 9, 0}, {1304, 6, 8, 0}// 132	133	134	
			, {1304, 6, 7, 0}, {12788, 8, 5, 0}, {12788, 8, 4, 0}// 135	136	137	
			, {1304, 5, 11, 0}, {1304, 5, 10, 0}, {1304, 5, 9, 0}// 138	139	140	
			, {1304, 5, 8, 0}, {1304, 5, 7, 0}, {1304, 5, 6, 0}// 141	142	143	
			, {1304, 4, 11, 0}, {1304, 4, 10, 0}, {1304, 3, 11, 0}// 144	145	146	
			, {1304, 3, 10, 0}, {1339, 17, 11, 0}, {1339, 18, 4, 0}// 147	148	149	
			, {1339, 9, 10, 0}, {1339, 13, 4, 0}, {4310, 13, 14, 0}// 150	151	152	
			, {577, 12, 7, 0}, {12788, 4, 2, 0}, {578, 12, 4, 0}// 153	154	155	
			, {1339, 8, 10, 0}, {12791, 7, 6, 0}, {1339, 16, 2, 0}// 156	157	158	
			, {1339, 16, 4, 0}, {578, 6, 8, 0}, {12788, 3, 8, 0}// 159	160	162	
			, {1339, 18, 10, 0}, {578, 6, 9, 0}, {12788, 4, 4, 0}// 163	164	165	
			, {578, 6, 10, 0}, {12788, 6, 3, 0}, {6939, 18, 2, 0}// 166	167	168	
			, {12791, 6, 5, 0}, {1339, 17, 5, 0}, {2274, 8, 9, 0}// 169	170	171	
			, {1339, 8, 9, 0}, {578, 6, 11, 0}, {577, 11, 7, 0}// 172	173	174	
			, {12788, 6, 4, 0}, {4308, 7, 17, 0}, {577, 8, 7, 0}// 175	177	178	
			, {12791, 6, 6, 0}, {2272, 10, 9, 0}, {12788, 3, 5, 0}// 179	180	181	
			, {12788, 10, 2, 0}, {1339, 17, 4, 0}, {12788, 4, 5, 0}// 182	183	184	
			, {12788, 3, 9, 0}, {1339, 12, 10, 0}, {1339, 14, 3, 0}// 185	186	187	
			, {2282, 13, 3, 0}, {12791, 7, 7, 0}, {1339, 14, 10, 0}// 188	189	190	
			, {4335, 9, 3, 0}, {1339, 16, 6, 0}, {12788, 4, 8, 0}// 191	192	193	
			, {12788, 4, 3, 0}, {12788, 9, 4, 0}, {578, 12, 7, 0}// 194	195	196	
			, {12788, 3, 6, 0}, {577, 3, 11, 0}, {1339, 10, 9, 0}// 197	198	199	
			, {6880, 9, 10, 0}, {12788, 5, 4, 0}, {4715, 3, 6, 0}// 200	201	202	
			, {12791, 8, 6, 0}, {578, 12, 6, 0}, {1339, 12, 11, 0}// 203	204	205	
			, {2278, 15, 10, 0}, {4655, 7, 4, 1}, {12788, 3, 7, 0}// 206	207	208	
			, {577, 10, 7, 0}, {4716, 3, 5, 0}, {1339, 9, 9, 0}// 209	210	211	
			, {1339, 13, 8, 0}, {1339, 7, 8, 0}, {1339, 15, 1, 0}// 212	213	214	
			, {1304, 16, -9, 0}, {3791, 4, -8, 0}, {3813, 9, -13, 0}// 215	216	217	
			, {6012, 13, -5, 0}, {1339, 11, -11, 0}, {12788, 3, -2, 0}// 218	219	220	
			, {7573, 4, -7, 22}, {7395, 6, -2, 1}, {1040, 13, 1, 0}// 221	222	223	
			, {1339, 16, 0, 0}, {6939, 4, -13, 0}, {1339, 11, -12, 0}// 224	225	226	
			, {12788, 3, 0, 0}, {1035, 16, -4, 0}, {1339, 13, -10, 0}// 227	228	229	
			, {1339, 13, -7, 0}, {1339, 12, -10, 0}, {1339, 16, 1, 0}// 231	232	233	
			, {1041, 14, -8, 0}, {1339, 16, -2, 0}, {12788, 7, -6, 0}// 234	235	236	
			, {1339, 14, -5, 0}, {1041, 15, -4, 0}, {1339, 13, -6, 0}// 237	239	240	
			, {1339, 16, -1, 0}, {1041, 15, -7, 0}, {1035, 12, 1, 0}// 241	242	243	
			, {1339, 18, 0, 0}, {3792, 8, -2, 0}, {1046, 12, -13, 0}// 244	245	246	
			, {4653, 9, 0, 1}, {4651, 3, 0, 0}, {586, 12, 1, 0}// 247	249	250	
			, {12792, 15, -10, 0}, {6940, 8, 1, 0}, {578, 12, -5, 0}// 251	252	254	
			, {578, 7, -9, 0}, {12788, 4, -3, 0}, {1037, 13, -1, 0}// 255	256	257	
			, {12788, 11, 0, 0}, {577, 9, -6, 0}, {12788, 7, 1, 0}// 258	259	260	
			, {1339, 13, -8, 0}, {1339, 10, -11, 0}, {12788, 3, -3, 0}// 261	262	263	
			, {12788, 4, -2, 0}, {12792, 17, -7, 0}, {12788, 4, -6, 0}// 264	265	266	
			, {12788, 7, -4, 0}, {1339, 12, -9, 0}, {578, 7, -8, 0}// 267	268	269	
			, {1039, 15, -6, 0}, {12788, 3, -7, 0}, {577, 10, -6, 0}// 270	271	272	
			, {584, 12, -1, 0}, {12788, 9, -1, 0}, {12788, 4, -7, 0}// 273	274	275	
			, {12788, 3, -4, 0}, {6937, 3, -2, 0}, {12788, 4, 0, 0}// 276	277	278	
			, {12788, 6, -5, 0}, {1339, 14, -7, 0}, {12788, 12, -3, 0}// 279	280	281	
			, {12791, 5, -3, 0}, {578, 12, -4, 0}, {12788, 11, -1, 0}// 282	284	285	
			, {577, 8, -6, 0}, {1339, 17, 1, 0}, {4655, 5, -3, 1}// 286	287	288	
			, {584, 12, -1, 0}, {12792, 9, -3, 0}, {12788, 9, -5, 0}// 289	290	291	
			, {12792, 11, -3, 0}, {12788, 10, -3, 0}, {1035, 13, -11, 0}// 292	293	294	
			, {1036, 12, -12, 0}, {12788, 7, -1, 0}, {1339, 14, -4, 0}// 295	296	297	
			, {1339, 16, -3, 0}, {12788, 3, -1, 0}, {12788, 4, -1, 0}// 298	299	300	
			, {1037, 13, -2, 0}, {577, 5, -10, 0}, {3791, 11, -9, 0}// 301	303	304	
			, {12788, 4, 1, 0}, {12788, 5, -2, 0}, {12788, 12, -2, 0}// 305	306	307	
			, {577, 6, -10, 0}, {1339, 11, -7, 0}, {577, 12, -6, 0}// 308	309	310	
			, {6659, 3, -9, 0}, {2282, 10, -9, 0}, {1339, 14, -3, 0}// 311	312	313	
			, {1339, 17, -3, 0}, {1339, 8, -8, 0}, {1040, 17, -4, 0}// 314	315	316	
			, {1339, 13, -5, 0}, {1041, 18, -4, 0}, {1339, 12, -8, 0}// 317	318	319	
			, {1304, 17, -6, 0}, {1036, 15, -5, 0}, {1339, 13, -4, 0}// 320	321	322	
			, {1339, 9, -8, 0}, {1304, 16, -5, 0}, {1046, 18, -5, 0}// 323	324	325	
			, {1339, 10, -8, 0}, {1339, 14, -2, 0}, {12788, 5, -5, 0}// 326	327	328	
			, {12788, 6, -3, 0}, {12788, 7, 0, 0}, {1037, 13, 0, 0}// 329	330	331	
			, {1041, 18, -1, 0}, {1304, 12, -4, 0}, {1304, 12, -5, 0}// 332	333	334	
			, {1339, 15, -2, 0}, {1304, 11, 1, 0}, {12788, 6, -1, 0}// 335	336	337	
			, {12788, 8, -4, 0}, {1304, 11, -4, 0}, {1304, 11, -5, 0}// 338	339	340	
			, {1304, 11, -6, 0}, {12788, 9, -4, 0}, {12788, 9, -2, 0}// 341	342	343	
			, {12788, 10, 0, 0}, {1304, 10, -6, 0}, {12788, 8, 1, 0}// 344	345	346	
			, {12788, 9, 0, 0}, {12788, 9, 1, 0}, {12788, 5, -1, 0}// 347	348	349	
			, {12788, 10, -2, 0}, {1304, 9, -6, 0}, {1339, 8, -10, 0}// 350	351	352	
			, {12788, 8, -5, 0}, {12788, 8, -1, 0}, {12788, 7, -3, 0}// 353	354	355	
			, {12788, 7, -2, 0}, {12788, 6, -4, 0}, {12788, 6, 0, 0}// 356	357	358	
			, {12788, 6, 1, 0}, {1304, 7, -7, 0}, {1304, 7, -8, 0}// 359	360	361	
			, {1304, 7, -9, 0}, {12788, 7, -5, 0}, {12788, 5, 1, 0}// 362	363	364	
			, {12788, 8, -3, 0}, {1304, 6, -8, 0}, {1304, 6, -9, 0}// 365	366	367	
			, {1304, 6, -10, 0}, {12788, 5, -4, 0}, {12788, 8, 0, 0}// 368	369	370	
			, {12788, 5, -6, 0}, {1046, 15, -8, 0}, {12788, 5, -8, 0}// 371	372	373	
			, {12788, 6, -8, 0}, {12788, 5, -7, 0}, {12788, 4, -8, 0}// 374	375	376	
			, {12788, 3, -9, 0}, {1046, 16, -7, 0}, {1304, 8, -7, 0}// 377	378	379	
			, {12788, 6, -7, 0}, {12788, 6, -9, 0}, {1339, 12, -7, 0}// 380	381	382	
			, {577, 7, -10, 0}, {4687, 3, -8, 0}, {4686, 3, -7, 0}// 383	384	385	
			, {7403, 5, -6, 0}, {1304, 8, -6, 0}, {1339, 17, -1, 0}// 386	387	388	
			, {12788, 3, -8, 0}, {4348, 8, -5, 0}, {6931, 4, -5, 0}// 389	390	391	
			, {12788, 3, -6, 0}, {1339, 11, -10, 0}, {12788, 4, -4, 0}// 392	393	394	
			, {12788, 12, -1, 0}, {12788, 4, -5, 0}, {1304, 16, -12, 0}// 395	396	397	
			, {1304, 16, -14, 0}, {1304, 18, -12, 0}, {1339, 15, 0, 0}// 398	399	400	
			, {1339, 12, -6, 0}, {1304, 18, -14, 0}, {1339, 15, -1, 0}// 401	402	403	
			, {1304, 15, -9, 0}, {1304, 15, -12, 0}, {1339, 11, -8, 0}// 404	405	406	
			, {1304, 16, -8, 0}, {1339, 9, -10, 0}, {7391, 3, -7, 7}// 407	408	409	
			, {1304, 15, -13, 0}, {1304, 17, -13, 0}, {12788, 10, -5, 0}// 410	411	412	
			, {1304, 17, -9, 0}, {1304, 15, -14, 0}, {1304, 13, -12, 0}// 413	414	415	
			, {1304, 17, -12, 0}, {1304, 18, -9, 0}, {1304, 12, -14, 0}// 416	417	418	
			, {1339, 9, -9, 0}, {1304, 18, -10, 0}, {2282, 13, -4, 0}// 419	420	421	
			, {1304, 15, -11, 0}, {12792, 3, 1, 0}, {1339, 10, -10, 0}// 422	423	424	
			, {12788, 12, 0, 0}, {1039, 18, -3, 0}, {1304, 17, -11, 0}// 425	426	427	
			, {1304, 18, -7, 0}, {6936, 5, 0, 0}, {1339, 17, -2, 0}// 428	429	430	
			, {12788, 5, 0, 0}, {12788, 8, -2, 0}, {1043, 16, -6, 0}// 431	432	433	
			, {1339, 14, -1, 0}, {1304, 16, -13, 0}, {1339, 15, -3, 0}// 434	435	436	
			, {6659, 13, -3, 0}, {1304, 14, -13, 0}, {578, 7, -6, 0}// 437	438	439	
			, {1339, 17, 0, 0}, {1339, 13, -9, 0}, {584, 12, 0, 0}// 440	441	442	
			, {12788, 5, -9, 0}, {12788, 6, -2, 0}, {1339, 8, -9, 0}// 443	444	445	
			, {1041, 12, -11, 0}, {1304, 16, -11, 0}, {1304, 18, -11, 0}// 446	447	448	
			, {1304, 18, -13, 0}, {1339, 11, -9, 0}, {1044, 17, -5, 0}// 449	450	451	
			, {582, 12, -2, 0}, {12788, 6, -6, 0}, {1304, 10, -7, 0}// 452	453	454	
			, {1339, 14, 0, 0}, {1339, 9, -11, 0}, {1339, 10, -9, 0}// 455	456	457	
			, {1036, 14, -9, 0}, {577, 4, -10, 0}, {1304, 13, -14, 0}// 459	460	461	
			, {2274, 8, -9, 0}, {2272, 9, -11, 0}, {1339, 14, 1, 0}// 462	463	464	
			, {577, 11, -6, 0}, {578, 12, -3, 0}, {1304, 17, -10, 0}// 465	466	467	
			, {1036, 18, -2, 0}, {12792, 18, -6, 0}, {1042, 13, -3, 0}// 468	469	470	
			, {577, 3, -10, 0}, {4654, 7, -5, 1}, {12788, 10, 1, 0}// 471	472	473	
			, {12788, 10, -4, 0}, {1304, 18, -8, 0}, {1304, 13, -13, 0}// 474	475	476	
			, {1304, 9, -7, 0}, {1304, 14, -12, 0}, {12792, 11, -2, 0}// 477	478	479	
			, {12788, 3, -5, 0}, {4655, 4, -7, 1}, {1036, 14, -10, 0}// 480	481	482	
			, {1339, 14, -6, 0}, {12792, 17, -8, 0}, {12792, 10, -1, 0}// 483	484	485	
			, {1046, 14, -11, 0}, {578, 7, -7, 0}, {1304, 16, -10, 0}// 486	487	488	
			, {12788, 4, -9, 0}, {1304, 17, -14, 0}, {1304, 14, -14, 0}// 489	490	491	
			, {6883, 9, -5, 0}, {1339, 18, 1, 0}, {2278, 11, -12, 0}// 492	493	495	
			, {3813, 3, -15, 0}, {1304, 17, -15, 0}, {1304, 16, -16, 0}// 496	499	500	
			, {1304, 16, -15, 0}, {1304, 18, -15, 0}, {1304, 13, -16, 0}// 501	502	503	
			, {6880, 9, -15, 0}, {1304, 14, -15, 0}, {1304, 15, -16, 0}// 504	505	506	
			, {1304, 14, -16, 0}, {1304, 13, -15, 0}, {1304, 12, -16, 0}// 507	508	509	
			, {1304, 15, -15, 0}, {1304, 18, -16, 0}, {1304, 12, -15, 0}// 510	511	512	
			, {1304, 17, -16, 0}, {577, -7, 7, 0}, {578, -7, 9, 0}// 514	515	516	
			, {577, -6, 11, 0}, {577, -5, 11, 0}, {12792, -9, 2, 0}// 517	518	519	
			, {578, -7, 10, 0}, {6938, 1, 16, 20}, {3791, 2, 13, 0}// 520	521	522	
			, {578, -11, 4, 0}, {12788, 0, 9, 0}, {6932, -2, 4, 0}// 523	524	526	
			, {6934, -4, 4, 0}, {7572, -10, 4, 0}, {6938, -3, 7, 0}// 527	528	529	
			, {12788, 2, 3, 0}, {4653, -1, 7, 1}, {2879, -3, 2, 0}// 530	531	532	
			, {7395, -6, 4, 1}, {577, -1, 11, 0}, {7403, -6, 2, 0}// 533	534	535	
			, {4651, 1, 7, 0}, {4651, 1, 2, 1}, {12788, 0, 7, 0}// 536	537	538	
			, {12788, 0, 2, 0}, {577, -2, 11, 0}, {12788, 2, 8, 0}// 539	540	541	
			, {12788, 2, 4, 0}, {1342, -1, 13, 0}, {578, -11, 5, 0}// 542	543	544	
			, {1342, -3, 13, 0}, {577, -3, 11, 0}, {12788, -4, 7, 0}// 545	546	547	
			, {12788, 0, 8, 0}, {12788, -5, 6, 0}, {2879, 0, 2, 0}// 548	549	550	
			, {4651, -1, 4, 1}, {6660, -10, 2, 0}, {4718, 2, 4, 0}// 551	552	553	
			, {12788, -10, 3, 0}, {4655, -4, 5, 1}, {1304, -10, 6, 0}// 554	555	556	
			, {1342, 2, 12, 0}, {12788, -4, 9, 0}, {12788, 1, 3, 0}// 557	558	559	
			, {1342, 1, 13, 0}, {12788, 1, 6, 0}, {12788, 1, 4, 0}// 560	561	562	
			, {12788, -3, 5, 0}, {4652, -1, 2, 6}, {12788, -4, 5, 0}// 563	564	565	
			, {12788, -7, 3, 0}, {12788, 1, 9, 0}, {1342, 1, 12, 0}// 566	567	568	
			, {4651, -7, 4, 0}, {578, -11, 6, 0}, {12788, 1, 7, 0}// 569	570	571	
			, {1342, -1, 12, 0}, {12788, -9, 3, 0}, {5696, -8, 4, 0}// 572	573	574	
			, {577, 1, 11, 0}, {12788, -3, 4, 0}, {12788, 2, 9, 0}// 575	576	577	
			, {1342, -3, 12, 0}, {1342, -2, 13, 0}, {12788, -3, 7, 0}// 578	579	580	
			, {4653, -2, 2, 6}, {6935, -6, 4, 0}, {4306, -6, 9, 0}// 581	582	583	
			, {2277, -3, 12, 0}, {6657, -10, 4, 0}, {4650, -3, 2, 6}// 584	585	587	
			, {12788, 0, 5, 0}, {12788, -2, 4, 0}, {12788, -3, 6, 0}// 588	589	590	
			, {12788, 0, 4, 0}, {2879, -2, 2, 0}, {12788, -2, 6, 0}// 591	592	593	
			, {12788, -2, 3, 0}, {12788, -2, 7, 0}, {12788, -4, 6, 0}// 594	595	596	
			, {12788, -7, 5, 0}, {578, -11, 3, 0}, {12788, -7, 6, 0}// 597	598	599	
			, {1342, -2, 12, 0}, {1304, 2, 11, 0}, {1304, 1, 11, 0}// 600	601	602	
			, {1304, 0, 11, 0}, {1304, -1, 11, 0}, {1304, -2, 11, 0}// 603	604	605	
			, {1304, -3, 11, 0}, {1304, -4, 11, 0}, {1304, -5, 11, 0}// 606	607	608	
			, {12788, -3, 8, 0}, {1304, 1, 10, 0}, {12788, -9, 7, 0}// 609	610	611	
			, {1304, 0, 10, 0}, {578, -11, 7, 0}, {12788, -6, 9, 0}// 612	613	614	
			, {12788, -9, 6, 0}, {12788, -6, 6, 0}, {1304, -1, 10, 0}// 615	616	617	
			, {12788, -6, 8, 0}, {1304, -2, 10, 0}, {12788, -8, 6, 0}// 618	619	620	
			, {1304, -3, 10, 0}, {12788, -7, 2, 0}, {12788, -9, 5, 0}// 621	622	623	
			, {12788, -9, 4, 0}, {12788, -3, 3, 0}, {12788, -6, 5, 0}// 624	625	626	
			, {577, -9, 7, 0}, {12788, -5, 9, 0}, {12788, -5, 5, 0}// 627	628	629	
			, {12788, -6, 7, 0}, {12788, -5, 3, 0}, {12788, -5, 8, 0}// 630	631	632	
			, {578, -11, 2, 0}, {12788, -7, 4, 0}, {12788, -4, 2, 0}// 633	634	635	
			, {12788, -7, 7, 0}, {12788, -8, 4, 0}, {1304, -5, 10, 0}// 636	637	638	
			, {1304, -6, 11, 0}, {1304, -6, 10, 0}, {12788, -8, 3, 0}// 640	641	642	
			, {12792, 0, 6, 0}, {12788, -10, 6, 0}, {1304, -8, 7, 0}// 643	644	645	
			, {12788, -8, 7, 0}, {12788, -10, 5, 0}, {12788, -10, 7, 0}// 646	647	648	
			, {1342, -4, 13, 0}, {1304, -9, 7, 0}, {1304, -9, 6, 0}// 649	650	651	
			, {12788, -10, 2, 0}, {12792, -2, 5, 0}, {12788, -3, 9, 0}// 652	653	654	
			, {12788, -8, 5, 0}, {4720, 2, 6, 0}, {12788, 0, 3, 0}// 655	656	657	
			, {577, 2, 11, 0}, {577, 0, 11, 0}, {12788, -5, 4, 0}// 658	659	660	
			, {4719, 2, 5, 0}, {12788, -10, 4, 0}, {12788, -2, 2, 0}// 661	662	663	
			, {3792, 2, 8, 0}, {2879, -1, 2, 0}, {577, -10, 7, 0}// 664	665	666	
			, {12788, 1, 5, 0}, {4721, 1, 6, 0}, {12788, 2, 7, 0}// 667	669	670	
			, {12788, -1, 2, 0}, {12788, -1, 3, 0}, {578, -7, 11, 0}// 671	672	673	
			, {577, -4, 11, 0}, {12788, -4, 8, 0}, {12788, -4, 3, 0}// 674	675	676	
			, {1304, -10, 7, 0}, {577, -8, 7, 0}, {12788, -5, 7, 0}// 677	678	679	
			, {12788, -8, 2, 0}, {4723, 1, 4, 0}, {1342, -4, 12, 0}// 680	681	682	
			, {12788, -5, 2, 0}, {12788, -1, 4, 0}, {4651, -3, 8, 1}// 683	684	685	
			, {12788, 1, 2, 0}, {12788, -3, 2, 0}, {12788, -1, 5, 0}// 686	687	688	
			, {12788, -2, 8, 0}, {12788, -1, 6, 0}, {12788, 2, 6, 0}// 689	690	692	
			, {12788, -2, 9, 0}, {12788, -1, 7, 0}, {578, -7, 8, 0}// 693	694	695	
			, {12788, -1, 8, 0}, {12788, -1, 9, 0}, {4722, 1, 5, 0}// 696	697	698	
			, {1304, 2, 10, 0}, {1342, 0, 12, 0}, {12788, -4, 4, 0}// 699	700	701	
			, {12788, 1, 8, 0}, {1342, -5, 12, 0}, {1304, -4, 10, 0}// 702	703	704	
			, {1342, 0, 13, 0}, {12788, -6, 2, 0}, {4681, -5, 8, 0}// 705	706	707	
			, {12788, 2, 5, 0}, {12788, -6, 3, 0}, {2282, 1, 12, 0}// 708	709	710	
			, {1342, 2, 13, 0}, {12788, -6, 4, 0}, {12788, 2, 2, 0}// 711	712	713	
			, {7400, -1, 0, 6}, {4310, -11, -9, 0}, {7395, -5, -8, 5}// 714	715	716	
			, {12788, -5, -8, 0}, {7405, -3, 0, 6}, {577, 1, -10, 0}// 717	718	720	
			, {2879, -1, 0, 0}, {12788, -4, -8, 0}, {4744, -5, -9, 0}// 721	722	723	
			, {12788, 1, -6, 0}, {6940, -2, -7, 0}, {12788, 1, -4, 0}// 725	726	727	
			, {4148, -3, 1, 6}, {4651, -7, -4, 0}, {4735, -5, -6, 0}// 728	730	731	
			, {577, 0, -10, 0}, {12788, 2, -5, 0}, {6659, -1, -9, 0}// 732	733	734	
			, {6941, -10, -2, 0}, {2879, -1, 1, 0}, {4740, -4, -7, 0}// 735	736	738	
			, {2879, -3, 0, 0}, {12788, 2, 0, 0}, {4677, -8, -3, 0}// 739	740	741	
			, {4655, -5, -7, 5}, {12788, 1, -3, 0}, {12788, -3, -6, 0}// 742	743	744	
			, {12788, -5, -1, 0}, {12788, 1, 0, 0}, {2879, -3, 1, 0}// 745	746	747	
			, {12788, 1, -2, 0}, {2879, 0, 1, 0}, {578, -7, -6, 0}// 748	749	750	
			, {3619, -3, -1, 6}, {12788, -3, 0, 0}, {12788, -2, -1, 0}// 751	752	753	
			, {12788, -10, 1, 0}, {12788, 2, -6, 0}, {2879, 0, -1, 0}// 754	755	756	
			, {12788, -1, -7, 0}, {578, -7, -7, 0}, {4739, -4, -8, 0}// 757	758	759	
			, {3792, -9, 0, 0}, {12788, 2, 1, 0}, {2879, -1, -1, 0}// 760	761	762	
			, {12788, -1, -8, 0}, {12788, -4, 1, 0}, {2448, -8, -2, 0}// 763	764	765	
			, {6937, -6, -4, 0}, {12788, -1, -2, 0}, {4655, -1, 0, 6}// 766	767	768	
			, {12788, 1, -1, 0}, {12788, -7, -3, 0}, {12788, -2, -2, 0}// 769	770	771	
			, {12788, -6, -7, 0}, {577, -3, -10, 0}, {4706, -10, 0, 16}// 772	773	774	
			, {12792, -9, -2, 0}, {12788, -1, -4, 0}, {12788, -3, -1, 0}// 775	777	778	
			, {578, -11, -3, 0}, {12788, 0, 1, 0}, {12788, -1, -5, 0}// 779	780	781	
			, {578, -7, -9, 0}, {577, -7, -6, 0}, {12788, -2, 1, 0}// 782	783	784	
			, {7403, -8, -4, 0}, {4653, -3, -8, 1}, {4651, -7, 0, 1}// 785	786	787	
			, {12788, -1, -3, 0}, {12788, 0, -4, 0}, {12788, -4, 0, 0}// 788	789	790	
			, {578, -11, 1, 0}, {12788, 0, -3, 0}, {4737, -6, -7, 0}// 791	792	793	
			, {12788, 0, -1, 0}, {12788, -3, -3, 0}, {12788, -2, -5, 0}// 794	795	796	
			, {4736, -6, -6, 0}, {12788, 0, -7, 0}, {12788, -8, -1, 0}// 797	798	799	
			, {12792, 2, -4, 0}, {12788, -5, -9, 0}, {578, -11, 0, 0}// 800	801	802	
			, {12788, -2, -3, 0}, {12788, 0, -8, 0}, {12788, -8, -5, 0}// 803	804	805	
			, {12788, 1, -7, 0}, {12788, -4, -2, 0}, {12788, -5, -3, 0}// 806	807	808	
			, {12788, -5, -2, 0}, {4742, -6, -8, 0}, {12788, -3, -7, 0}// 809	810	811	
			, {12788, 1, -9, 0}, {12788, -5, -5, 0}, {12788, -5, -6, 0}// 812	813	814	
			, {4693, 0, -7, 0}, {4692, 0, -8, 0}, {12788, -5, 0, 0}// 815	816	817	
			, {577, -10, -6, 0}, {4691, 1, -8, 0}, {4690, 1, -7, 0}// 818	819	820	
			, {12788, -4, -3, 0}, {12788, -3, -8, 0}, {12788, -7, 1, 0}// 821	822	823	
			, {4689, 2, -7, 0}, {12788, -7, -2, 0}, {12788, -4, -1, 0}// 824	825	826	
			, {12788, -4, -5, 0}, {4743, -6, -9, 0}, {578, -11, -4, 0}// 827	828	829	
			, {578, -11, -5, 0}, {12788, -4, -6, 0}, {12788, -7, -1, 0}// 830	831	832	
			, {12788, 2, -7, 0}, {4688, 2, -8, 0}, {12788, -4, -9, 0}// 833	834	835	
			, {12788, -2, -6, 0}, {12788, -8, -3, 0}, {577, -6, -10, 0}// 836	837	838	
			, {2879, -2, 0, 0}, {4734, -4, -6, 0}, {12788, -5, 1, 0}// 839	840	841	
			, {12788, -8, -4, 0}, {2879, -2, -1, 0}, {12788, -10, -2, 0}// 842	843	844	
			, {12788, -6, -8, 0}, {12792, -3, -4, 0}, {12788, -5, -7, 0}// 845	846	847	
			, {12792, -8, -2, 0}, {12788, -9, 0, 0}, {577, -4, -10, 0}// 848	849	850	
			, {4745, -4, -9, 0}, {12788, 2, -9, 0}, {4654, -2, -1, 6}// 851	852	853	
			, {1304, -7, -7, 0}, {1304, -7, -8, 0}, {1304, -7, -9, 0}// 854	855	856	
			, {4652, -7, 1, 1}, {12788, -6, -9, 0}, {12788, -10, -3, 0}// 857	858	859	
			, {12788, -9, -3, 0}, {12788, -7, -4, 0}, {12788, -7, -5, 0}// 860	861	862	
			, {12788, -10, -1, 0}, {4650, -8, -2, 1}, {12788, -9, -5, 0}// 863	864	865	
			, {6933, 0, -6, 0}, {12788, -10, -5, 0}, {12788, -4, -7, 0}// 866	867	868	
			, {12788, -1, -9, 0}, {12788, -2, -9, 0}, {2879, -3, -1, 0}// 869	870	871	
			, {12788, -5, -4, 0}, {6931, -9, 1, 0}, {577, -5, -10, 0}// 872	873	874	
			, {578, -11, -2, 0}, {12788, -10, -4, 0}, {12788, -6, -6, 0}// 875	876	877	
			, {6934, -5, -2, 0}, {12792, -2, -8, 0}, {2879, 0, 0, 0}// 878	879	880	
			, {578, -11, -1, 0}, {12788, -1, -6, 0}, {12788, 0, 0, 0}// 881	882	883	
			, {7398, -8, -4, 1}, {12792, -8, 1, 0}, {12788, -1, -1, 0}// 884	885	886	
			, {12788, -1, 0, 0}, {2879, -2, 1, 0}, {12788, 2, -2, 0}// 887	888	889	
			, {12788, -6, -5, 0}, {7411, 2, -6, 1}, {12788, -1, 1, 0}// 890	891	892	
			, {577, -2, -10, 0}, {4653, -8, -5, 1}, {12788, -6, -4, 0}// 893	895	896	
			, {12788, -2, -4, 0}, {7401, 2, -1, 0}, {12788, -3, -2, 0}// 897	898	899	
			, {4738, -5, -7, 0}, {12788, -6, -3, 0}, {12788, -3, -9, 0}// 900	901	902	
			, {577, -9, -6, 0}, {7390, 2, -7, 7}, {578, -7, -8, 0}// 903	905	906	
			, {12788, -9, -4, 0}, {12788, -3, -5, 0}, {6883, -5, -5, 0}// 907	908	909	
			, {4651, -1, -8, 1}, {12788, -8, 0, 0}, {4653, 0, -1, 6}// 910	911	912	
			, {577, 2, -10, 0}, {577, -1, -10, 0}, {12788, -6, -2, 0}// 913	914	915	
			, {12788, 1, -5, 0}, {7410, -2, -6, 1}, {12788, -6, -1, 0}// 916	917	918	
			, {12788, -6, 0, 0}, {580, -7, -10, 0}, {12788, -10, 0, 0}// 919	920	921	
			, {12788, -3, 1, 0}, {4738, -5, -8, 0}, {6935, 1, -2, 0}// 922	923	924	
			, {4650, 0, -4, 1}, {12788, 0, -2, 0}, {12788, -6, 1, 0}// 925	926	927	
			, {4652, -5, -6, 5}, {12788, 2, -3, 0}, {12788, 1, -8, 0}// 928	929	930	
			, {12788, -9, -1, 0}, {12788, 0, -6, 0}, {577, -8, -6, 0}// 931	932	933	
			, {12788, 0, -9, 0}, {6939, -5, 0, 0}, {12788, 2, -1, 0}// 934	936	937	
			, {12788, -4, -4, 0}, {12788, 1, 1, 0}, {12788, -9, 1, 0}// 938	939	940	
			, {12788, 2, -8, 0}, {580, -11, -6, 0}, {12788, -2, -7, 0}// 941	942	943	
			, {12788, -7, 0, 0}, {12788, 0, -5, 0}, {12792, -2, 0, 0}// 944	945	946	
			, {3813, -17, 4, 20}, {3813, -15, 12, 0}, {6880, -14, 3, 0}// 950	951	952	
			, {3791, -14, 5, 0}, {4308, -16, 17, 0}, {4308, -15, 10, 0}// 958	960	961	
			, {6939, -14, 13, 0}, {18076, -17, 1, 0}, {4308, -17, -4, 0}// 972	973	974	
			, {3813, -14, 0, 0}, {3813, -15, -8, 0}, {6880, -17, -10, 20}// 975	979	980	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OctEventBoss4AddonDeed();
			}
		}

		[ Constructable ]
		public OctEventBoss4Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7964, 10, 12, 0, 0, -1, "Spawner", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3326, 8, 13, 0, 1106, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3326, 18, 17, 0, 1106, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3326, 13, 13, 0, 1106, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3320, 7, 16, 0, 1106, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3391, 14, 13, 0, 1105, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3326, 11, 16, 0, 1109, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3326, 5, 13, 0, 1109, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 3326, 6, 17, 0, 1109, -1, "", 1);// 161
			AddComplexComponent( (BaseAddon) this, 3391, 8, 16, 0, 1105, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 9272, 13, -1, 0, 0, -1, "Restrict Creatures", 1);// 230
			AddComplexComponent( (BaseAddon) this, 9272, 13, -2, 0, 0, -1, "Restrict Creatures", 1);// 238
			AddComplexComponent( (BaseAddon) this, 3320, 4, -12, 0, 1106, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 9272, 13, 0, 0, 0, -1, "Restrict Creatures", 1);// 253
			AddComplexComponent( (BaseAddon) this, 9272, 13, 1, 0, 0, -1, "Restrict Creatures", 1);// 283
			AddComplexComponent( (BaseAddon) this, 9272, 13, -3, 0, 0, -1, "Restrict Creatures", 1);// 302
			AddComplexComponent( (BaseAddon) this, 3320, 9, -12, 0, 1106, -1, "", 1);// 458
			AddComplexComponent( (BaseAddon) this, 3391, 10, -14, 0, 1105, -1, "", 1);// 494
			AddComplexComponent( (BaseAddon) this, 3326, 7, -15, 0, 1109, -1, "", 1);// 497
			AddComplexComponent( (BaseAddon) this, 3320, 10, -15, 0, 1106, -1, "", 1);// 498
			AddComplexComponent( (BaseAddon) this, 3326, 3, -15, 0, 1106, -1, "", 1);// 513
			AddComplexComponent( (BaseAddon) this, 3326, -5, 13, 0, 1109, -1, "", 1);// 525
			AddComplexComponent( (BaseAddon) this, 3326, 1, 16, 0, 1109, -1, "", 1);// 586
			AddComplexComponent( (BaseAddon) this, 3326, -6, 16, 0, 1109, -1, "", 1);// 639
			AddComplexComponent( (BaseAddon) this, 3320, -3, 16, 0, 1109, -1, "", 1);// 668
			AddComplexComponent( (BaseAddon) this, 3391, 1, 14, 0, 1105, -1, "", 1);// 691
			AddComplexComponent( (BaseAddon) this, 3326, -10, -14, 0, 1106, -1, "", 1);// 719
			AddComplexComponent( (BaseAddon) this, 3326, 0, -14, 0, 1106, -1, "", 1);// 724
			AddComplexComponent( (BaseAddon) this, 3320, -2, -12, 0, 1106, -1, "", 1);// 729
			AddComplexComponent( (BaseAddon) this, 3326, -10, -10, 0, 1106, -1, "", 1);// 737
			AddComplexComponent( (BaseAddon) this, 3326, -12, -14, 0, 1109, -1, "", 1);// 776
			AddComplexComponent( (BaseAddon) this, 3391, -2, -14, 0, 1105, -1, "", 1);// 894
			AddComplexComponent( (BaseAddon) this, 3320, -9, -12, 0, 1106, -1, "", 1);// 904
			AddComplexComponent( (BaseAddon) this, 3326, -5, -13, 0, 1106, -1, "", 1);// 935
			AddComplexComponent( (BaseAddon) this, 3320, -3, -15, 0, 1106, -1, "", 1);// 947
			AddComplexComponent( (BaseAddon) this, 3326, -6, -15, 0, 1106, -1, "", 1);// 948
			AddComplexComponent( (BaseAddon) this, 3320, -8, -16, 0, 1106, -1, "", 1);// 949
			AddComplexComponent( (BaseAddon) this, 3320, -17, 16, 0, 1109, -1, "", 1);// 953
			AddComplexComponent( (BaseAddon) this, 3320, -16, 10, 0, 1109, -1, "", 1);// 954
			AddComplexComponent( (BaseAddon) this, 3320, -15, 5, 0, 1109, -1, "", 1);// 955
			AddComplexComponent( (BaseAddon) this, 3326, -17, 14, 0, 1109, -1, "", 1);// 956
			AddComplexComponent( (BaseAddon) this, 3326, -15, 16, 0, 1106, -1, "", 1);// 957
			AddComplexComponent( (BaseAddon) this, 3320, -17, 10, 0, 1109, -1, "", 1);// 959
			AddComplexComponent( (BaseAddon) this, 3391, -17, 11, 0, 1105, -1, "", 1);// 962
			AddComplexComponent( (BaseAddon) this, 3391, -15, 2, 0, 1105, -1, "", 1);// 963
			AddComplexComponent( (BaseAddon) this, 3326, -17, 17, 0, 1106, -1, "", 1);// 964
			AddComplexComponent( (BaseAddon) this, 3320, -15, 9, 0, 1109, -1, "", 1);// 965
			AddComplexComponent( (BaseAddon) this, 3320, -16, 7, 0, 1106, -1, "", 1);// 966
			AddComplexComponent( (BaseAddon) this, 3391, -15, 7, 0, 1105, -1, "", 1);// 967
			AddComplexComponent( (BaseAddon) this, 3326, -15, 12, 0, 1106, -1, "", 1);// 968
			AddComplexComponent( (BaseAddon) this, 3326, -17, 4, 0, 1106, -1, "", 1);// 969
			AddComplexComponent( (BaseAddon) this, 3391, -16, 16, 0, 1105, -1, "", 1);// 970
			AddComplexComponent( (BaseAddon) this, 3326, -17, 6, 0, 1106, -1, "", 1);// 971
			AddComplexComponent( (BaseAddon) this, 3320, -16, 1, 0, 1109, -1, "", 1);// 976
			AddComplexComponent( (BaseAddon) this, 3391, -14, -13, 0, 1105, -1, "", 1);// 977
			AddComplexComponent( (BaseAddon) this, 3326, -16, -2, 0, 1106, -1, "", 1);// 978
			AddComplexComponent( (BaseAddon) this, 3391, -14, -9, 0, 1105, -1, "", 1);// 981
			AddComplexComponent( (BaseAddon) this, 3329, -15, -13, 0, 1106, -1, "", 1);// 982
			AddComplexComponent( (BaseAddon) this, 3320, -17, -10, 0, 1109, -1, "", 1);// 983
			AddComplexComponent( (BaseAddon) this, 3320, -14, 0, 0, 1106, -1, "", 1);// 984
			AddComplexComponent( (BaseAddon) this, 3326, -15, -9, 0, 1109, -1, "", 1);// 985
			AddComplexComponent( (BaseAddon) this, 3320, -17, -13, 0, 1109, -1, "", 1);// 986
			AddComplexComponent( (BaseAddon) this, 3326, -15, -5, 0, 1109, -1, "", 1);// 987
			AddComplexComponent( (BaseAddon) this, 3320, -17, -16, 0, 1106, -1, "", 1);// 988

		}

		public OctEventBoss4Addon( Serial serial ) : base( serial )
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

	public class OctEventBoss4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OctEventBoss4Addon();
			}
		}

		[Constructable]
		public OctEventBoss4AddonDeed()
		{
			Name = "OctEventBoss4";
		}

		public OctEventBoss4AddonDeed( Serial serial ) : base( serial )
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