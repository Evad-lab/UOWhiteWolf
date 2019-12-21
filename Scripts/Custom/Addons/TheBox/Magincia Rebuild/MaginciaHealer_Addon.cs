
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
	public class MaginciaHealer_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4553, 6, 8, 0}, {361, -2, 9, 20}, {361, -2, 8, 20}// 1	2	3	
			, {361, 7, 9, 20}, {361, 7, 8, 20}, {362, 7, 9, 20}// 4	5	6	
			, {362, 6, 9, 20}, {362, 5, 9, 20}, {362, 4, 9, 20}// 7	8	9	
			, {362, 3, 9, 20}, {362, 2, 9, 20}, {362, 1, 9, 20}// 10	11	12	
			, {362, 0, 9, 20}, {362, -1, 9, 20}, {1375, 7, 9, 20}// 13	14	15	
			, {1375, 7, 8, 20}, {1375, 6, 9, 20}, {1375, 6, 8, 20}// 16	17	18	
			, {1375, 5, 9, 20}, {1375, 5, 8, 20}, {1375, 4, 9, 20}// 19	20	21	
			, {1375, 4, 8, 20}, {1375, 3, 9, 20}, {1375, 3, 8, 20}// 22	23	24	
			, {1375, 2, 9, 20}, {1375, 2, 8, 20}, {1375, 1, 9, 20}// 25	26	27	
			, {1375, 1, 8, 20}, {1375, 0, 9, 20}, {1375, 0, 8, 20}// 28	29	30	
			, {1375, -1, 9, 20}, {1375, -1, 8, 20}, {352, 7, 9, 0}// 31	32	37	
			, {352, 5, 9, 0}, {352, 3, 9, 0}, {352, 1, 9, 0}// 38	39	40	
			, {352, -1, 9, 0}, {351, 7, 9, 0}, {351, 7, 8, 0}// 41	42	43	
			, {351, -2, 9, 0}, {351, -2, 8, 0}, {1194, 5, 8, 0}// 44	45	46	
			, {1194, 2, 8, 0}, {1194, 0, 8, 0}, {1196, 7, 9, 0}// 47	48	49	
			, {1196, 7, 8, 0}, {1196, 6, 9, 0}, {1196, 6, 8, 0}// 50	51	52	
			, {1196, 5, 9, 0}, {1196, 4, 9, 0}, {1196, 4, 8, 0}// 53	54	55	
			, {1196, 3, 9, 0}, {1196, 3, 8, 0}, {1196, 2, 9, 0}// 56	57	58	
			, {1196, 1, 9, 0}, {1196, 1, 8, 0}, {1196, 0, 9, 0}// 59	60	61	
			, {1196, -1, 9, 0}, {1196, -1, 8, 0}, {4031, 3, 4, 10}// 62	63	64	
			, {3619, 4, 4, 6}, {4651, -4, -6, 0}, {3712, -1, 4, 8}// 65	66	67	
			, {2900, 2, 5, 0}, {4030, 2, 4, 6}, {2877, 2, 4, 0}// 69	70	71	
			, {2877, 1, 4, 0}, {2879, 4, 4, 0}, {2879, 3, 4, 0}// 72	73	74	
			, {2879, 0, 4, 0}, {2879, -1, 4, 0}, {4653, 1, 2, 0}// 75	76	77	
			, {3817, -4, -2, 3}, {3817, -4, -3, 8}, {3852, -4, -1, 6}// 79	80	81	
			, {3851, -4, -3, 3}, {2840, -3, 0, 3}, {2720, -4, 0, 3}// 82	83	84	
			, {2725, -5, 0, 3}, {2719, -3, -1, 3}, {2719, -3, -2, 3}// 85	86	87	
			, {2719, -3, -3, 3}, {2724, -3, -4, 3}, {2722, -4, -4, 3}// 88	89	90	
			, {2723, -5, -4, 3}, {2721, -5, -1, 3}, {2721, -5, -2, 3}// 91	92	93	
			, {2721, -5, -3, 3}, {2831, -4, -1, 0}, {2831, -4, -2, 0}// 94	95	96	
			, {2831, -4, -3, 0}, {2836, -3, -3, 0}, {2836, -3, -2, 0}// 97	98	99	
			, {2836, -3, -1, 0}, {2833, -3, 0, 0}, {2837, -4, 0, 0}// 100	101	102	
			, {2834, -5, 0, 0}, {2838, -5, -1, 0}, {2838, -5, -2, 0}// 103	104	105	
			, {2838, -5, -3, 0}, {2839, -4, -4, 0}, {2835, -3, -4, 0}// 106	107	108	
			, {2832, -5, -4, 0}, {2739, -1, 0, 0}, {2739, 0, 0, 0}// 109	110	111	
			, {2739, 1, 0, 0}, {2739, 2, 0, 0}, {2739, 3, 0, 0}// 112	113	114	
			, {2739, 3, -1, 0}, {2739, 2, -1, 0}, {2739, 1, -1, 0}// 115	116	117	
			, {2739, 0, -1, 0}, {2739, -1, -1, 0}, {2739, -1, -2, 0}// 118	119	120	
			, {2739, 0, -2, 0}, {2739, 1, -2, 0}, {2739, 2, -2, 0}// 121	122	123	
			, {2739, 3, -2, 0}, {2739, 3, -3, 0}, {2739, 2, -3, 0}// 124	125	126	
			, {2739, 1, -3, 0}, {2739, 0, -3, 0}, {2739, -1, -3, 0}// 127	128	129	
			, {2740, 3, -4, 0}, {2740, 2, -4, 0}, {2740, 1, -4, 0}// 130	131	132	
			, {2740, 0, -4, 0}, {2740, -1, -4, 0}, {2741, 4, -3, 0}// 133	134	135	
			, {2741, 4, -2, 0}, {2741, 4, -1, 0}, {2741, 4, 0, 0}// 136	137	138	
			, {2746, 4, 1, 0}, {2745, 4, -4, 0}, {2747, -2, 1, 0}// 139	140	141	
			, {2742, 3, 1, 0}, {2742, 2, 1, 0}, {2742, 1, 1, 0}// 142	143	144	
			, {2742, 0, 1, 0}, {2742, -1, 1, 0}, {2743, -2, 0, 0}// 145	146	147	
			, {2743, -2, -1, 0}, {2743, -2, -2, 0}, {2743, -2, -3, 0}// 148	149	150	
			, {2744, -2, -4, 0}, {3619, 0, -8, 0}, {3619, 4, -8, 0}// 151	152	153	
			, {4650, 1, -6, 0}, {2652, -3, -7, 0}, {2659, -3, -8, 0}// 154	155	156	
			, {2652, 5, -7, 0}, {2659, 5, -8, 0}, {2652, 3, -7, 0}// 157	158	159	
			, {2659, 3, -8, 0}, {2652, 1, -7, 0}, {2659, 1, -8, 0}// 160	161	162	
			, {2652, -1, -7, 0}, {2659, -1, -8, 0}, {2977, 8, 4, 0}// 163	164	166	
			, {2977, 8, -8, 0}, {361, -2, 7, 20}, {361, -2, 6, 20}// 168	169	170	
			, {361, -2, 5, 20}, {361, -2, 4, 20}, {361, 7, 7, 20}// 171	172	173	
			, {361, 7, 6, 20}, {361, 7, 5, 20}, {361, 7, 4, 20}// 174	175	176	
			, {361, 7, 3, 20}, {361, 7, 2, 20}, {361, 7, 1, 20}// 177	178	179	
			, {361, 7, 0, 20}, {361, 7, -1, 20}, {361, 7, -2, 20}// 180	181	182	
			, {361, 7, -3, 20}, {361, 7, -4, 20}, {361, 7, -5, 20}// 183	184	185	
			, {361, 7, -6, 20}, {361, 7, -7, 20}, {361, 7, -8, 20}// 186	187	188	
			, {362, -2, 3, 20}, {362, -3, 3, 20}, {362, -4, 3, 20}// 189	190	191	
			, {362, -5, 3, 20}, {1375, 7, 7, 20}, {1375, 7, 6, 20}// 192	193	194	
			, {1375, 7, 5, 20}, {1375, 7, 4, 20}, {1375, 6, 7, 20}// 195	196	197	
			, {1375, 6, 6, 20}, {1375, 6, 5, 20}, {1375, 6, 4, 20}// 198	199	200	
			, {1375, 5, 7, 20}, {1375, 5, 6, 20}, {1375, 5, 5, 20}// 201	202	203	
			, {1375, 5, 4, 20}, {1375, 4, 7, 20}, {1375, 4, 6, 20}// 204	205	206	
			, {1375, 4, 5, 20}, {1375, 4, 4, 20}, {1375, 3, 7, 20}// 207	208	209	
			, {1375, 3, 6, 20}, {1375, 3, 5, 20}, {1375, 3, 4, 20}// 210	211	212	
			, {1375, 2, 7, 20}, {1375, 2, 6, 20}, {1375, 2, 5, 20}// 213	214	215	
			, {1375, 2, 4, 20}, {1375, 1, 7, 20}, {1375, 1, 6, 20}// 216	217	218	
			, {1375, 1, 5, 20}, {1375, 1, 4, 20}, {1375, 0, 7, 20}// 219	220	221	
			, {1375, 0, 6, 20}, {1375, 0, 5, 20}, {1375, 0, 4, 20}// 222	223	224	
			, {1375, -1, 7, 20}, {1375, -1, 6, 20}, {1375, -1, 5, 20}// 225	226	227	
			, {1375, -1, 4, 20}, {1375, 7, 3, 20}, {1375, 6, 3, 20}// 228	229	230	
			, {1375, 5, 3, 20}, {1375, 4, 3, 20}, {1375, 3, 3, 20}// 231	232	233	
			, {1375, 2, 3, 20}, {1375, 1, 3, 20}, {1375, 0, 3, 20}// 234	235	236	
			, {1375, -1, 3, 20}, {1375, -2, 3, 20}, {1375, -3, 3, 20}// 237	238	239	
			, {1375, -4, 3, 20}, {1375, -5, 3, 20}, {1375, 7, 2, 20}// 240	241	242	
			, {1375, 7, 1, 20}, {1375, 7, 0, 20}, {1375, 7, -1, 20}// 243	244	245	
			, {1375, 7, -2, 20}, {1375, 7, -3, 20}, {1375, 7, -4, 20}// 246	247	248	
			, {1375, 7, -5, 20}, {1375, 7, -6, 20}, {1375, 7, -7, 20}// 249	250	251	
			, {1375, 7, -8, 20}, {1375, 6, 2, 20}, {1375, 6, 1, 20}// 252	253	254	
			, {1375, 6, 0, 20}, {1375, 6, -1, 20}, {1375, 6, -2, 20}// 255	256	257	
			, {1375, 6, -3, 20}, {1375, 6, -4, 20}, {1375, 6, -5, 20}// 258	259	260	
			, {1375, 6, -6, 20}, {1375, 6, -7, 20}, {1375, 6, -8, 20}// 261	262	263	
			, {1375, 5, 2, 20}, {1375, 5, 1, 20}, {1375, 5, 0, 20}// 264	265	266	
			, {1375, 5, -1, 20}, {1375, 5, -2, 20}, {1375, 5, -3, 20}// 267	268	269	
			, {1375, 5, -4, 20}, {1375, 5, -5, 20}, {1375, 5, -6, 20}// 270	271	272	
			, {1375, 5, -7, 20}, {1375, 5, -8, 20}, {1375, 4, 2, 20}// 273	274	275	
			, {1375, 4, 1, 20}, {1375, 4, 0, 20}, {1375, 4, -1, 20}// 276	277	278	
			, {1375, 4, -2, 20}, {1375, 4, -3, 20}, {1375, 4, -4, 20}// 279	280	281	
			, {1375, 4, -5, 20}, {1375, 4, -6, 20}, {1375, 4, -7, 20}// 282	283	284	
			, {1375, 4, -8, 20}, {1375, 3, 2, 20}, {1375, 3, 1, 20}// 285	286	287	
			, {1375, 3, 0, 20}, {1375, 3, -1, 20}, {1375, 3, -2, 20}// 288	289	290	
			, {1375, 3, -3, 20}, {1375, 3, -4, 20}, {1375, 3, -5, 20}// 291	292	293	
			, {1375, 3, -6, 20}, {1375, 3, -7, 20}, {1375, 3, -8, 20}// 294	295	296	
			, {1375, 2, 2, 20}, {1375, 2, 1, 20}, {1375, 2, 0, 20}// 297	298	299	
			, {1375, 2, -1, 20}, {1375, 2, -2, 20}, {1375, 2, -3, 20}// 300	301	302	
			, {1375, 2, -4, 20}, {1375, 2, -5, 20}, {1375, 2, -6, 20}// 303	304	305	
			, {1375, 2, -7, 20}, {1375, 2, -8, 20}, {1375, 1, 2, 20}// 306	307	308	
			, {1375, 1, 1, 20}, {1375, 1, 0, 20}, {1375, 1, -1, 20}// 309	310	311	
			, {1375, 1, -2, 20}, {1375, 1, -3, 20}, {1375, 1, -4, 20}// 312	313	314	
			, {1375, 1, -5, 20}, {1375, 1, -6, 20}, {1375, 1, -7, 20}// 315	316	317	
			, {1375, 1, -8, 20}, {1375, 0, 2, 20}, {1375, 0, 1, 20}// 318	319	320	
			, {1375, 0, 0, 20}, {1375, 0, -1, 20}, {1375, 0, -2, 20}// 321	322	323	
			, {1375, 0, -3, 20}, {1375, 0, -4, 20}, {1375, 0, -5, 20}// 324	325	326	
			, {1375, 0, -6, 20}, {1375, 0, -7, 20}, {1375, 0, -8, 20}// 327	328	329	
			, {1375, -1, 2, 20}, {1375, -1, 1, 20}, {1375, -1, 0, 20}// 330	331	332	
			, {1375, -1, -1, 20}, {1375, -1, -2, 20}, {1375, -1, -3, 20}// 333	334	335	
			, {1375, -1, -4, 20}, {1375, -1, -5, 20}, {1375, -1, -6, 20}// 336	337	338	
			, {1375, -1, -7, 20}, {1375, -1, -8, 20}, {1375, -2, 2, 20}// 339	340	341	
			, {1375, -2, 1, 20}, {1375, -2, 0, 20}, {1375, -2, -1, 20}// 342	343	344	
			, {1375, -2, -2, 20}, {1375, -2, -3, 20}, {1375, -2, -4, 20}// 345	346	347	
			, {1375, -2, -5, 20}, {1375, -2, -6, 20}, {1375, -2, -7, 20}// 348	349	350	
			, {1375, -2, -8, 20}, {1375, -3, 2, 20}, {1375, -3, 1, 20}// 351	352	353	
			, {1375, -3, 0, 20}, {1375, -3, -1, 20}, {1375, -3, -2, 20}// 354	355	356	
			, {1375, -3, -3, 20}, {1375, -3, -4, 20}, {1375, -3, -5, 20}// 357	358	359	
			, {1375, -3, -6, 20}, {1375, -3, -7, 20}, {1375, -3, -8, 20}// 360	361	362	
			, {1375, -4, 2, 20}, {1375, -4, 1, 20}, {1375, -4, 0, 20}// 363	364	365	
			, {1375, -4, -1, 20}, {1375, -4, -2, 20}, {1375, -4, -3, 20}// 366	367	368	
			, {1375, -4, -4, 20}, {1375, -4, -5, 20}, {1375, -4, -6, 20}// 369	370	371	
			, {1375, -4, -7, 20}, {1375, -4, -8, 20}, {1375, -5, 2, 20}// 372	373	374	
			, {1375, -5, 1, 20}, {1375, -5, 0, 20}, {1375, -5, -1, 20}// 375	376	377	
			, {1375, -5, -2, 20}, {1375, -5, -3, 20}, {1375, -5, -4, 20}// 378	379	380	
			, {1375, -5, -5, 20}, {1375, -5, -6, 20}, {1375, -5, -7, 20}// 381	382	383	
			, {1375, -5, -8, 20}, {352, -4, 3, 0}, {352, -2, 3, 0}// 384	387	388	
			, {351, 7, 5, 0}, {351, 7, 4, 0}, {351, -2, 4, 0}// 389	390	391	
			, {351, -2, 5, 0}, {1194, 5, 6, 0}, {1194, 2, 6, 0}// 392	397	398	
			, {1194, 1, 4, 0}, {1194, 5, 4, 0}, {1195, 3, 3, 0}// 399	400	401	
			, {1196, 7, 7, 0}, {1196, 7, 6, 0}, {1196, 7, 5, 0}// 402	403	404	
			, {1196, 7, 4, 0}, {1196, 6, 7, 0}, {1196, 6, 6, 0}// 405	406	407	
			, {1196, 6, 5, 0}, {1196, 6, 4, 0}, {1196, 5, 7, 0}// 408	409	410	
			, {1196, 5, 5, 0}, {1196, 4, 7, 0}, {1196, 4, 6, 0}// 411	412	413	
			, {1196, 4, 5, 0}, {1196, 4, 4, 0}, {1196, 3, 7, 0}// 414	415	416	
			, {1196, 3, 6, 0}, {1196, 3, 5, 0}, {1196, 3, 4, 0}// 417	418	419	
			, {1196, 2, 7, 0}, {1196, 2, 5, 0}, {1196, 2, 4, 0}// 420	421	422	
			, {1196, 1, 7, 0}, {1196, 1, 6, 0}, {1196, 1, 5, 0}// 423	424	425	
			, {1196, 0, 7, 0}, {1196, 0, 6, 0}, {1196, 0, 5, 0}// 426	427	428	
			, {1196, 0, 4, 0}, {1196, -1, 7, 0}, {1196, -1, 6, 0}// 429	430	431	
			, {1196, -1, 5, 0}, {1196, -1, 4, 0}, {351, 7, -8, 0}// 432	433	438	
			, {351, 7, -6, 0}, {351, 7, -4, 0}, {351, 7, -1, 0}// 439	440	441	
			, {351, 7, 1, 0}, {351, 7, 3, 0}, {1195, -4, 2, 0}// 442	443	444	
			, {1195, -5, 1, 0}, {1195, -1, 2, 0}, {1195, -3, 0, 0}// 445	446	447	
			, {1195, -4, -1, 0}, {1195, -5, -2, 0}, {1195, -5, -6, 0}// 448	449	450	
			, {1195, -4, -5, 0}, {1195, -3, -4, 0}, {1195, -2, -3, 0}// 451	452	453	
			, {1195, 3, 2, 0}, {1195, 4, 3, 0}, {1195, 7, 3, 0}// 454	455	456	
			, {1195, 6, 2, 0}, {1195, 5, 1, 0}, {1195, -1, -5, 0}// 457	458	459	
			, {1195, -2, -6, 0}, {1195, -3, -7, 0}, {1195, -4, -8, 0}// 460	461	462	
			, {1195, -1, -8, 0}, {1195, 0, -7, 0}, {1195, 1, -6, 0}// 463	464	465	
			, {1195, 2, -5, 0}, {1195, 5, -2, 0}, {1195, 6, -1, 0}// 466	467	468	
			, {1195, 7, 0, 0}, {1195, 7, -3, 0}, {1195, 6, -4, 0}// 469	470	471	
			, {1195, 5, -5, 0}, {1195, 4, -6, 0}, {1195, 3, -7, 0}// 472	473	474	
			, {1195, 2, -8, 0}, {1195, 7, -6, 0}, {1195, 6, -7, 0}// 475	476	477	
			, {1195, 5, -8, 0}, {1196, -5, 2, 0}, {1196, -5, -3, 0}// 478	479	480	
			, {1196, -4, -2, 0}, {1196, -3, -1, 0}, {1196, -2, 0, 0}// 481	482	483	
			, {1196, 0, 2, 0}, {1196, 0, 3, 0}, {1196, 1, 3, 0}// 484	485	486	
			, {1196, 2, 2, 0}, {1196, -2, -2, 0}, {1196, -3, -3, 0}// 487	488	489	
			, {1196, -4, -4, 0}, {1196, -5, -5, 0}, {1196, -5, 0, 0}// 490	491	492	
			, {1196, -4, 1, 0}, {1196, -3, 2, 0}, {1196, -2, 3, 0}// 493	494	495	
			, {1196, -3, 3, 0}, {1196, -5, 3, 0}, {1196, 5, 3, 0}// 496	497	498	
			, {1196, 4, 2, 0}, {1196, 3, 2, 0}, {1196, -2, -4, 0}// 499	500	501	
			, {1196, -3, -5, 0}, {1196, -4, -6, 0}, {1196, -5, -7, 0}// 502	503	504	
			, {1196, -3, -8, 0}, {1196, -2, -7, 0}, {1196, -1, -6, 0}// 505	506	507	
			, {1196, 0, -5, 0}, {1196, 5, 0, 0}, {1196, 6, 1, 0}// 508	509	510	
			, {1196, 7, 2, 0}, {1196, 7, -1, 0}, {1196, 6, -2, 0}// 511	512	513	
			, {1196, 5, -3, 0}, {1196, 3, -5, 0}, {1196, 2, -6, 0}// 514	515	516	
			, {1196, 1, -7, 0}, {1196, 0, -8, 0}, {1196, 7, -4, 0}// 517	518	519	
			, {1196, 6, -5, 0}, {1196, 5, -6, 0}, {1196, 4, -7, 0}// 520	521	522	
			, {1196, 5, -7, 0}, {1196, 3, -8, 0}, {1196, 7, -7, 0}// 523	524	525	
			, {1196, 6, -8, 0}, {1193, -4, 3, 0}, {1193, -1, 3, 0}// 526	527	528	
			, {1193, -2, 2, 0}, {1193, -3, 1, 0}, {1193, -4, 0, 0}// 529	530	531	
			, {1193, -5, -1, 0}, {1193, 2, 3, 0}, {1193, 1, 2, 0}// 532	533	534	
			, {1193, -2, -1, 0}, {1193, -3, -2, 0}, {1193, -4, -3, 0}// 535	536	537	
			, {1193, -5, -4, 0}, {1193, 7, -8, 0}, {1193, 4, -8, 0}// 538	539	540	
			, {1193, 5, -7, 0}, {1193, 6, -6, 0}, {1193, 7, -5, 0}// 541	542	543	
			, {1193, 7, -2, 0}, {1193, 6, -3, 0}, {1193, 5, -4, 0}// 544	545	546	
			, {1193, 4, -5, 0}, {1193, 3, -6, 0}, {1193, 2, -7, 0}// 547	548	549	
			, {1193, 1, -8, 0}, {1193, -2, -8, 0}, {1193, -1, -7, 0}// 550	551	552	
			, {1193, 0, -6, 0}, {1193, 1, -5, 0}, {1193, 5, -1, 0}// 553	554	555	
			, {1193, 6, 0, 0}, {1193, 7, 1, 0}, {1193, 6, 3, 0}// 556	557	558	
			, {1193, 5, 2, 0}, {1193, -2, -5, 0}, {1193, -3, -6, 0}// 559	560	561	
			, {1193, -4, -7, 0}, {1193, -5, -8, 0}, {362, 7, -9, 20}// 562	563	564	
			, {362, 6, -9, 20}, {362, 5, -9, 20}, {362, 4, -9, 20}// 565	566	567	
			, {362, 3, -9, 20}, {362, 2, -9, 20}, {362, 1, -9, 20}// 568	569	570	
			, {362, 0, -9, 20}, {362, -1, -9, 20}, {362, -2, -9, 20}// 571	572	573	
			, {362, -3, -9, 20}, {362, -4, -9, 20}, {362, -5, -9, 20}// 574	575	576	
			, {352, -1, -9, 0}, {352, 0, -9, 0}, {352, 1, -9, 0}// 577	578	579	
			, {352, 6, -9, 0}, {352, 7, -9, 0}, {352, 5, -9, 0}// 580	581	582	
			, {352, 4, -9, 0}, {352, 3, -9, 0}, {352, 2, -9, 0}// 583	584	585	
			, {352, -2, -9, 0}, {352, -4, -9, 0}, {352, -3, -9, 0}// 586	587	588	
			, {352, -5, -9, 0}, {3135, -6, -3, 0}, {3133, -6, -2, 0}// 589	590	591	
			, {3131, -6, -2, 0}, {3137, -6, -3, 0}, {4268, -6, -1, 0}// 592	593	594	
			, {4269, -6, -2, 0}, {4269, -6, -3, 0}, {3135, -6, -4, 0}// 595	596	597	
			, {4270, -6, -4, 0}, {351, -7, -2, 0}, {351, -7, -3, 0}// 598	599	600	
			, {351, -7, -4, 0}, {4553, -6, -8, 0}, {361, -7, 3, 20}// 601	602	603	
			, {361, -7, 2, 20}, {361, -7, 1, 20}, {361, -7, 0, 20}// 604	605	606	
			, {361, -7, -1, 20}, {361, -7, -2, 20}, {361, -7, -3, 20}// 607	608	609	
			, {361, -7, -4, 20}, {361, -7, -5, 20}, {361, -7, -6, 20}// 610	611	612	
			, {361, -7, -7, 20}, {361, -7, -8, 20}, {362, -6, 3, 20}// 613	614	615	
			, {1375, -6, 3, 20}, {1375, -6, 2, 20}, {1375, -6, 1, 20}// 616	617	618	
			, {1375, -6, 0, 20}, {1375, -6, -1, 20}, {1375, -6, -2, 20}// 619	620	621	
			, {1375, -6, -3, 20}, {1375, -6, -4, 20}, {1375, -6, -5, 20}// 622	623	624	
			, {1375, -6, -6, 20}, {1375, -6, -7, 20}, {1375, -6, -8, 20}// 625	626	627	
			, {352, -6, 3, 0}, {351, -7, 3, 0}, {351, -7, 1, 0}// 628	633	634	
			, {351, -7, -1, 0}, {351, -7, -6, 0}, {351, -7, -8, 0}// 635	636	637	
			, {1195, -6, 0, 0}, {1195, -6, -3, 0}, {1196, -6, -4, 0}// 638	639	640	
			, {1196, -6, -6, 0}, {1196, -6, -2, 0}, {1196, -6, -7, 0}// 641	642	643	
			, {1196, -6, -8, 0}, {1196, -6, -1, 0}, {1196, -6, 3, 0}// 644	645	646	
			, {1193, -6, 1, 0}, {1193, -6, 2, 0}, {1193, -6, -5, 0}// 647	648	649	
			, {362, -6, -9, 20}, {363, -7, -9, 20}, {347, -7, -9, 0}// 650	651	652	
			, {352, -6, -9, 0}// 653	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MaginciaHealer_AddonDeed();
			}
		}

		[ Constructable ]
		public MaginciaHealer_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 355, 6, 9, 0, 0, 26, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 355, 4, 9, 0, 0, 26, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 355, 2, 9, 0, 0, 26, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 355, 0, 9, 0, 0, 26, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2842, 1, 4, 8, 0, 2, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 3617, -4, -1, 3, 2213, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2987, 8, 4, 0, 0, -1, "Healer of New Magincia", 1);// 165
			AddComplexComponent( (BaseAddon) this, 2594, 8, -8, 13, 0, 29, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 355, -3, 3, 0, 0, 26, "", 1);// 385
			AddComplexComponent( (BaseAddon) this, 355, -5, 3, 0, 0, 26, "", 1);// 386
			AddComplexComponent( (BaseAddon) this, 354, 7, 7, 0, 0, 27, "", 1);// 393
			AddComplexComponent( (BaseAddon) this, 354, 7, 6, 0, 0, 27, "", 1);// 394
			AddComplexComponent( (BaseAddon) this, 354, -2, 7, 0, 0, 27, "", 1);// 395
			AddComplexComponent( (BaseAddon) this, 354, -2, 6, 0, 0, 27, "", 1);// 396
			AddComplexComponent( (BaseAddon) this, 354, 7, 2, 0, 0, 27, "", 1);// 434
			AddComplexComponent( (BaseAddon) this, 354, 7, 0, 0, 0, 27, "", 1);// 435
			AddComplexComponent( (BaseAddon) this, 354, 7, -5, 0, 0, 27, "", 1);// 436
			AddComplexComponent( (BaseAddon) this, 354, 7, -7, 0, 0, 27, "", 1);// 437
			AddComplexComponent( (BaseAddon) this, 354, -7, 2, 0, 0, 27, "", 1);// 629
			AddComplexComponent( (BaseAddon) this, 354, -7, 0, 0, 0, 27, "", 1);// 630
			AddComplexComponent( (BaseAddon) this, 354, -7, -5, 0, 0, 27, "", 1);// 631
			AddComplexComponent( (BaseAddon) this, 354, -7, -7, 0, 0, 27, "", 1);// 632

		}

		public MaginciaHealer_Addon( Serial serial ) : base( serial )
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

	public class MaginciaHealer_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MaginciaHealer_Addon();
			}
		}

		[Constructable]
		public MaginciaHealer_AddonDeed()
		{
			Name = "MaginciaHealer_";
		}

		public MaginciaHealer_AddonDeed( Serial serial ) : base( serial )
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