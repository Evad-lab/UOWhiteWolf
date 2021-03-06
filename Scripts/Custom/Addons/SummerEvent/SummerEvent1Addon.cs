
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
	public class SummerEvent1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {12580, 59, 36, 5}, {3480, 59, 36, 5}, {3480, 69, 22, 5}// 1	2	3	
			, {12580, 69, 22, 5}, {3480, 60, 23, 5}, {12578, 64, 21, 5}// 4	5	6	
			, {9966, 64, 21, 5}, {12580, 60, 23, 5}, {12578, 63, 14, 5}// 7	8	9	
			, {9966, 63, 14, 5}, {3480, 58, 15, 5}, {12580, 58, 15, 5}// 10	11	12	
			, {12580, 45, 61, 5}, {13814, 42, 67, 5}, {9966, 48, 57, 5}// 13	14	15	
			, {12578, 48, 57, 5}, {3480, 45, 61, 5}, {3480, 50, 40, 5}// 16	17	18	
			, {12580, 50, 40, 5}, {12578, 46, 46, 5}, {9966, 46, 46, 5}// 19	20	21	
			, {12580, 54, 51, 5}, {3480, 54, 51, 5}, {12580, 56, 26, 5}// 22	23	24	
			, {9966, 56, 34, 5}, {12578, 42, 35, 9}, {12578, 56, 34, 5}// 25	26	27	
			, {13814, 56, 22, 5}, {9966, 42, 35, 9}, {3480, 56, 26, 5}// 28	29	30	
			, {12578, 49, 19, 5}, {9966, 49, 19, 5}, {12578, 57, 8, 5}// 31	32	33	
			, {9966, 57, 8, 5}, {9966, 54, 0, 5}, {12578, 49, -1, 5}// 34	35	36	
			, {9966, 49, -1, 5}, {12578, 54, 0, 5}, {3480, 42, 3, 5}// 37	38	39	
			, {12580, 42, 3, 5}, {12578, 34, 77, 5}, {3480, 31, 81, 5}// 40	41	42	
			, {12580, 31, 81, 5}, {13814, 26, 82, 5}, {13814, 27, 69, 5}// 43	44	45	
			, {9966, 34, 77, 5}, {12580, 32, 66, 5}, {12578, 38, 65, 5}// 46	47	48	
			, {9966, 38, 65, 5}, {9966, 36, 60, 7}, {12578, 36, 60, 7}// 49	50	51	
			, {13814, 30, 63, 5}, {3480, 32, 66, 5}, {12578, 32, 46, 5}// 52	53	54	
			, {9966, 32, 46, 5}, {12580, 40, 48, 15}, {13814, 40, 39, 5}// 55	56	57	
			, {3480, 40, 48, 15}, {12578, 28, 35, 5}, {9966, 28, 35, 5}// 58	59	60	
			, {13814, 28, 26, 5}, {12578, 35, 23, 5}, {9966, 35, 23, 5}// 61	62	63	
			, {12578, 36, 4, 5}, {9966, 36, 4, 5}, {12580, 29, 17, 5}// 64	65	66	
			, {3480, 29, 17, 5}, {9966, 28, 12, 5}, {13814, 37, 13, 6}// 67	68	69	
			, {12578, 28, 12, 5}, {12580, 33, -2, 5}, {13814, 40, -4, 5}// 70	71	72	
			, {9966, 27, 1, 6}, {9966, 32, -12, 5}, {9966, 37, -4, 5}// 73	74	75	
			, {3480, 33, -2, 5}, {12578, 32, -12, 5}, {12578, 27, 1, 6}// 76	77	78	
			, {12578, 37, -4, 5}, {12580, 29, -18, 5}, {3480, 26, -17, 5}// 79	80	81	
			, {13814, 26, -22, 5}, {3480, 29, -18, 5}, {12580, 26, -17, 5}// 82	83	84	
			, {12578, 31, -33, 8}, {9966, 31, -33, 8}, {12578, 28, -46, 5}// 85	86	87	
			, {9966, 28, -46, 5}, {13814, 30, -63, 8}, {12580, 35, -157, 5}// 88	89	91	
			, {3480, 35, -157, 5}, {12578, 26, -165, 2}, {9966, 36, -161, 5}// 92	93	94	
			, {9966, 26, -165, 2}, {12578, 36, -161, 5}, {9966, 14, 105, 5}// 95	96	97	
			, {12578, 14, 105, 5}, {9966, 13, 115, 5}, {3480, 18, 103, 5}// 98	99	100	
			, {12580, 18, 103, 5}, {13814, 17, 100, 5}, {12578, 13, 115, 5}// 101	102	103	
			, {12578, 20, 95, 5}, {3480, 18, 87, 5}, {13814, 14, 90, 5}// 104	105	106	
			, {3480, 14, 93, 5}, {12580, 14, 93, 5}, {9966, 20, 95, 5}// 107	108	109	
			, {12580, 18, 87, 5}, {9966, 19, 83, 5}, {12578, 19, 83, 5}// 110	111	112	
			, {12580, 25, 78, 7}, {6925, 17, 70, 5}, {3480, 25, 78, 7}// 113	114	115	
			, {9966, 25, 67, 5}, {12578, 25, 67, 5}, {6926, 19, 58, 5}// 116	117	118	
			, {9966, 20, 50, 5}, {12578, 20, 50, 5}, {13814, 25, 45, 5}// 119	120	121	
			, {6921, 14, 47, 5}, {6922, 17, 42, 5}, {6921, 13, 44, 5}// 122	123	124	
			, {6923, 16, 29, 5}, {6922, 12, 24, 5}, {13814, 24, 16, 5}// 125	126	127	
			, {9966, 11, 13, 5}, {12578, 11, 13, 5}, {3480, 25, -7, 5}// 128	129	130	
			, {12580, 25, -7, 5}, {13814, 17, -8, 5}, {13814, 20, 0, 5}// 131	132	133	
			, {12578, 16, 0, 5}, {9966, 16, 0, 5}, {3480, 12, -14, 6}// 134	135	136	
			, {3480, 17, -24, 8}, {12580, 17, -24, 8}, {12578, 19, -17, 5}// 137	138	139	
			, {9966, 19, -17, 5}, {9966, 23, -27, 5}, {12578, 23, -27, 5}// 140	141	142	
			, {12580, 12, -14, 6}, {9966, 13, -36, 11}, {12578, 13, -36, 11}// 143	144	145	
			, {12578, 19, -51, 18}, {9966, 19, -51, 18}, {13814, 20, -49, 5}// 146	147	148	
			, {13814, 22, -72, 5}, {8708, 16, -88, 10}, {9966, 4, 116, 5}// 149	150	154	
			, {3480, -1, 124, 5}, {12580, -1, 124, 5}, {13814, -3, 117, 5}// 155	156	157	
			, {12578, 4, 116, 5}, {3480, 5, 114, 5}, {12580, 5, 114, 5}// 158	159	160	
			, {6924, -6, 89, 5}, {9966, 4, 84, 5}, {12578, 4, 84, 5}// 161	162	163	
			, {6923, 2, 81, 5}, {8708, -6, 52, 10}, {4077, -5, 53, 5}// 164	166	167	
			, {4076, -6, 53, 5}, {6924, 0, 66, 5}, {4078, -5, 52, 5}// 168	169	170	
			, {6925, 5, 56, 5}, {4074, -6, 52, 5}, {6928, 0, 58, 5}// 171	172	173	
			, {4072, -6, 51, 5}, {4075, -5, 51, 5}, {6923, 4, 38, 5}// 174	175	176	
			, {6922, -4, 39, 5}, {6924, -1, 46, 5}, {6928, -4, 28, 5}// 177	178	179	
			, {6923, 4, 16, 5}, {12580, 2, -7, 5}, {13814, -2, -6, 5}// 180	181	182	
			, {12580, -4, 3, 5}, {12578, 2, 2, 5}, {9966, 1, -12, 5}// 183	184	185	
			, {12578, 1, -12, 5}, {3480, -4, 3, 5}, {9966, 9, -8, 5}// 186	187	188	
			, {3480, 2, -7, 5}, {9966, 2, 2, 5}, {12578, 9, -8, 5}// 189	190	191	
			, {9966, 8, -26, 5}, {12578, -1, -20, 5}, {9966, -1, -20, 5}// 192	193	194	
			, {12578, 8, -26, 5}, {9966, -3, -34, 5}, {13814, -3, -31, 5}// 195	196	197	
			, {12578, -3, -34, 5}, {13814, 0, -45, 5}, {13814, 3, -68, 5}// 198	199	200	
			, {3480, 3, -165, 8}, {12580, 3, -165, 8}, {9966, -10, 122, 5}// 203	204	205	
			, {12578, -10, 122, 5}, {9966, -13, 113, 5}, {12580, -9, 115, 5}// 206	207	208	
			, {9966, -18, 100, 5}, {12578, -18, 100, 5}, {13814, -12, 108, 5}// 209	210	211	
			, {3480, -12, 105, 5}, {3480, -9, 115, 5}, {12580, -12, 105, 5}// 212	213	214	
			, {12578, -13, 113, 5}, {12578, -18, 88, 5}, {9966, -18, 88, 5}// 215	216	217	
			, {6924, -22, 87, 5}, {6925, -10, 86, 6}, {13814, -8, 86, 5}// 218	219	220	
			, {3480, -13, 81, 5}, {12580, -13, 81, 5}, {6928, -11, 73, 5}// 221	222	223	
			, {6923, -15, 65, 5}, {4070, -7, 52, 5}, {6927, -9, 58, 5}// 224	225	226	
			, {6926, -21, 53, 5}, {4073, -7, 53, 5}, {3480, -21, 49, 5}// 227	228	229	
			, {12580, -21, 38, 5}, {3480, -21, 38, 5}, {4071, -7, 51, 5}// 230	231	232	
			, {6928, -18, 40, 5}, {6922, -13, 45, 5}, {12580, -21, 49, 5}// 233	234	235	
			, {13814, -16, 26, 5}, {6925, -20, 24, 5}, {3480, -7, 16, 5}// 236	237	238	
			, {12578, -22, 4, 5}, {12580, -7, 16, 5}, {9966, -22, 4, 5}// 239	240	241	
			, {9966, -12, 7, 5}, {12578, -12, 7, 5}, {6923, -16, 13, 5}// 242	243	244	
			, {12578, -11, 0, 5}, {12578, -13, -7, 5}, {12578, -8, -5, 5}// 245	246	247	
			, {9966, -8, -5, 5}, {9966, -21, -7, 5}, {12578, -21, -7, 5}// 248	249	250	
			, {9966, -11, 0, 5}, {9966, -13, -7, 5}, {9966, -10, -24, 5}// 251	252	253	
			, {12578, -10, -24, 5}, {12578, -20, -22, 5}, {9966, -20, -22, 5}// 254	255	256	
			, {3480, -20, -16, 5}, {12580, -20, -16, 5}, {13814, -10, -16, 5}// 257	258	259	
			, {13814, -16, -32, 16}, {13814, -22, -48, 20}, {13814, -10, -73, 6}// 260	261	262	
			, {3480, -13, -164, 5}, {9966, -21, -165, 5}, {9966, -7, -162, 3}// 265	266	267	
			, {12580, -13, -164, 5}, {12578, -7, -162, 3}, {12578, -21, -165, 5}// 268	269	270	
			, {9966, -32, 103, 5}, {12578, -32, 103, 5}, {3480, -28, 98, 5}// 271	272	273	
			, {12578, -33, 92, 5}, {13814, -24, 95, 16}, {9966, -32, 89, 16}// 274	275	276	
			, {9966, -33, 92, 5}, {12580, -28, 98, 5}, {6924, -38, 86, 6}// 277	278	279	
			, {12578, -32, 89, 16}, {13814, -32, 76, 5}, {6921, -31, 74, 5}// 280	281	282	
			, {6925, -23, 81, 5}, {12578, -33, 53, 5}, {9966, -33, 53, 5}// 283	284	285	
			, {13814, -32, 57, 5}, {6923, -28, 67, 5}, {12578, -29, 40, 5}// 286	287	288	
			, {12580, -35, 44, 5}, {12580, -36, 38, 5}, {3480, -35, 44, 5}// 289	290	291	
			, {3480, -36, 38, 5}, {6927, -24, 42, 5}, {9966, -29, 40, 5}// 292	293	294	
			, {9966, -32, 31, 5}, {3480, -25, 27, 5}, {12580, -25, 27, 5}// 295	296	297	
			, {13814, -34, 28, 5}, {12578, -32, 31, 5}, {9966, -33, 26, 5}// 298	299	300	
			, {12578, -33, 26, 5}, {3480, -24, 14, 5}, {13814, -35, 9, 5}// 301	302	303	
			, {12580, -24, 14, 5}, {12578, -28, 19, 5}, {9966, -28, 19, 5}// 304	305	306	
			, {13814, -25, 9, 5}, {12578, -38, 2, 5}, {13814, -31, -10, 5}// 307	308	309	
			, {12580, -27, -1, 5}, {9966, -32, -5, 5}, {3480, -27, -1, 5}// 310	311	312	
			, {12578, -32, -5, 5}, {9966, -38, 2, 5}, {3480, -29, -23, 5}// 313	314	315	
			, {12580, -29, -23, 5}, {13814, -37, -22, 9}, {12578, -30, -15, 5}// 316	317	318	
			, {9966, -30, -15, 5}, {9966, -24, -30, 5}, {13814, -35, -39, 6}// 319	320	321	
			, {13814, -37, -35, 6}, {13814, -38, -37, 21}, {12578, -24, -30, 5}// 322	323	324	
			, {13814, -38, -41, 11}, {9966, -34, -45, 5}, {12578, -34, -45, 5}// 325	326	327	
			, {12578, -28, -68, 5}, {9966, -28, -68, 5}, {13814, -27, -64, 9}// 328	329	330	
			, {9966, -35, -163, 5}, {12578, -35, -163, 5}, {3480, -45, 113, 5}// 334	335	336	
			, {9966, -52, 113, 5}, {12580, -49, 103, 6}, {12578, -52, 113, 5}// 337	338	339	
			, {12580, -45, 113, 5}, {13814, -48, 115, 5}, {9966, -40, 107, 5}// 340	341	342	
			, {3480, -49, 103, 6}, {12578, -40, 107, 5}, {12578, -49, 91, 5}// 343	344	345	
			, {12580, -40, 98, 5}, {9966, -43, 94, 5}, {12578, -43, 94, 5}// 346	347	348	
			, {13814, -47, 94, 5}, {3480, -40, 98, 5}, {9966, -49, 91, 5}// 349	350	351	
			, {12578, -40, 82, 5}, {9966, -40, 82, 5}, {9966, -48, 76, 5}// 352	353	354	
			, {13814, -45, 76, 5}, {3480, -46, 80, 5}, {12580, -46, 80, 5}// 355	356	357	
			, {12578, -48, 76, 5}, {9966, -46, 56, 5}, {13814, -45, 55, 5}// 358	359	360	
			, {12578, -46, 56, 5}, {9966, -45, 42, 5}, {12578, -50, 49, 17}// 361	362	363	
			, {9966, -50, 49, 17}, {12578, -45, 42, 5}, {13814, -42, 37, 5}// 364	365	366	
			, {12580, -54, 30, 5}, {3480, -54, 30, 5}, {12578, -47, 32, 5}// 367	368	369	
			, {12580, -43, 26, 5}, {9966, -47, 32, 5}, {13814, -54, 22, 5}// 370	371	372	
			, {3480, -43, 26, 5}, {3480, -48, 7, 5}, {9966, -44, 15, 5}// 373	374	375	
			, {9966, -41, 19, 5}, {12580, -48, 7, 5}, {12578, -41, 19, 5}// 376	377	378	
			, {13814, -45, 6, 6}, {12578, -44, 15, 5}, {9966, -49, -7, 5}// 379	380	381	
			, {12580, -41, -9, 5}, {3480, -41, -9, 5}, {12578, -49, -7, 5}// 382	383	384	
			, {13814, -51, -12, 5}, {9966, -43, -28, 5}, {12578, -43, -28, 5}// 385	386	387	
			, {3480, -52, -18, 5}, {12578, -40, -16, 5}, {6921, -54, -28, 5}// 388	389	390	
			, {9966, -40, -16, 5}, {12580, -52, -18, 5}, {13814, -42, -39, 8}// 391	392	393	
			, {12578, -52, -31, 5}, {13814, -45, -44, 5}, {6924, -45, -39, 5}// 394	395	396	
			, {6921, -54, -36, 5}, {9966, -52, -31, 5}, {13814, -41, -35, 5}// 397	398	399	
			, {13814, -50, -39, 6}, {13814, -50, -42, 22}, {13814, -48, -42, 6}// 400	401	402	
			, {9966, -39, -57, 5}, {12578, -39, -57, 5}, {13814, -47, -51, 25}// 403	404	405	
			, {13814, -48, -48, 7}, {13814, -44, -51, 7}, {6921, -44, -46, 5}// 406	407	408	
			, {6927, -50, -55, 5}, {6926, -43, -55, 5}, {9966, -48, -67, 5}// 409	410	411	
			, {12578, -48, -67, 5}, {13814, -50, -63, 5}, {736, -53, -69, 5}// 412	413	414	
			, {889, -52, -69, 0}, {2741, -54, -70, 5}, {4017, -54, -67, 7}// 415	417	423	
			, {889, -52, -73, 0}, {736, -53, -72, 5}, {7135, -52, -68, 5}// 429	430	431	
			, {739, -53, -73, 5}, {735, -54, -68, 5}, {889, -52, -72, 0}// 432	433	434	
			, {889, -52, -71, 0}, {888, -54, -67, 0}, {2746, -54, -69, 5}// 435	436	437	
			, {734, -53, -68, 5}, {740, -54, -73, 5}, {889, -52, -70, 0}// 438	439	440	
			, {2741, -54, -71, 5}, {2745, -54, -72, 5}, {5691, -53, -91, 6}// 441	442	444	
			, {2861, -54, -81, 5}, {5691, -43, -87, 6}, {4, -40, -84, 5}// 445	446	447	
			, {7135, -47, -87, 5}, {2861, -46, -81, 5}, {5, -39, -84, 5}// 448	449	450	
			, {5690, -48, -78, 6}, {5690, -48, -90, 6}, {7135, -52, -82, 5}// 451	452	453	
			, {2861, -54, -88, 5}, {5691, -53, -77, 6}, {4, -49, -93, 5}// 454	455	456	
			, {5, -48, -93, 5}, {3232, -50, -155, 5}, {3235, -50, -155, 5}// 457	460	461	
			, {3236, -49, -155, 5}, {9966, -52, -149, 5}, {12578, -52, -149, 5}// 462	463	464	
			, {3231, -50, -156, 5}, {3221, -44, -156, 5}, {3232, -49, -156, 5}// 465	466	467	
			, {9966, -42, -164, 5}, {12578, -42, -164, 5}, {3231, -42, -162, 5}// 470	472	473	
			, {3232, -41, -162, 5}, {3236, -41, -161, 5}, {3232, -42, -161, 5}// 474	475	476	
			, {3235, -42, -161, 5}, {12580, -60, 166, 5}, {3480, -60, 166, 5}// 477	479	480	
			, {3480, -55, 150, 5}, {12580, -55, 150, 5}, {3480, -65, 136, 5}// 481	482	483	
			, {12580, -65, 136, 5}, {3480, -59, 135, 5}, {12580, -59, 135, 5}// 484	485	486	
			, {3480, -55, 118, 5}, {9966, -58, 119, 5}, {12580, -55, 118, 5}// 487	488	489	
			, {12578, -58, 119, 5}, {9966, -65, 110, 5}, {12578, -65, 110, 5}// 490	491	492	
			, {13814, -64, 112, 5}, {12580, -59, 113, 5}, {3480, -59, 113, 5}// 493	494	495	
			, {3480, -60, 106, 5}, {12580, -60, 106, 5}, {3480, -55, 91, 18}// 496	497	498	
			, {12578, -57, 98, 15}, {12580, -55, 91, 18}, {13814, -59, 94, 17}// 499	500	501	
			, {9966, -61, 88, 13}, {12578, -61, 88, 13}, {9966, -57, 98, 15}// 502	503	504	
			, {13814, -63, 72, 5}, {12580, -62, 80, 13}, {12578, -60, 76, 7}// 505	506	507	
			, {9966, -60, 76, 7}, {3480, -62, 80, 13}, {12578, -55, 81, 5}// 508	509	510	
			, {9966, -55, 81, 5}, {12580, -62, 51, 5}, {13814, -64, 38, 5}// 511	512	513	
			, {3480, -62, 51, 5}, {9966, -63, 27, 5}, {12578, -63, 27, 5}// 514	515	516	
			, {12580, -57, 22, 5}, {3480, -57, 22, 5}, {13814, -62, 10, 5}// 517	518	519	
			, {9966, -55, 11, 5}, {12578, -55, 11, 5}, {12580, -62, 3, 5}// 520	521	522	
			, {3480, -62, 3, 5}, {13814, -60, -16, 5}, {6924, -62, -27, 5}// 523	524	525	
			, {9966, -58, -18, 5}, {12578, -58, -18, 5}, {13814, -67, -38, 5}// 526	527	528	
			, {13814, -61, -36, 7}, {13814, -64, -30, 5}, {6924, -64, -40, 5}// 529	530	531	
			, {6927, -64, -33, 5}, {6921, -57, -40, 5}, {7825, -63, -49, 3}// 532	533	534	
			, {13814, -56, -50, 5}, {2280, -64, -52, 7}, {2280, -67, -49, 5}// 535	537	538	
			, {2280, -67, -49, 11}, {2280, -68, -50, 11}, {2280, -68, -49, 11}// 541	542	543	
			, {2278, -67, -48, 9}, {2280, -66, -54, 16}, {2278, -64, -51, 8}// 544	545	546	
			, {2280, -66, -49, 67}, {2280, -64, -51, 37}, {2280, -66, -54, 32}// 547	548	549	
			, {2278, -65, -50, 5}, {2280, -68, -53, 11}, {2280, -64, -53, 16}// 550	551	552	
			, {2280, -66, -54, 32}, {2280, -66, -49, 51}, {2280, -66, -49, 51}// 553	556	558	
			, {2280, -66, -50, 5}, {2280, -65, -50, 47}, {2280, -66, -49, 51}// 559	562	563	
			, {6923, -55, -48, 5}, {2280, -62, -51, 10}, {2278, -66, -49, 6}// 565	566	567	
			, {2280, -65, -51, 6}, {2280, -68, -54, 17}, {2280, -66, -49, 35}// 568	570	571	
			, {2147, -62, -76, 6}, {2148, -65, -76, 6}, {2147, -64, -76, 6}// 572	573	574	
			, {6956, -61, -76, 6}, {2147, -63, -76, 6}, {6957, -64, -76, 6}// 575	576	577	
			, {6954, -62, -76, 6}, {2146, -61, -76, 6}, {6954, -63, -76, 6}// 578	579	580	
			, {735, -57, -68, 5}, {740, -57, -73, 5}, {888, -57, -67, 0}// 581	582	583	
			, {2739, -55, -70, 5}, {4219, -57, -67, 5}, {735, -56, -68, 5}// 584	585	586	
			, {2740, -55, -72, 5}, {741, -58, -71, 5}, {888, -58, -67, 0}// 590	591	592	
			, {888, -55, -67, 0}, {741, -58, -72, 5}, {4016, -55, -67, 5}// 595	596	597	
			, {2743, -57, -71, 5}, {2658, -56, -72, 5}, {2739, -56, -70, 5}// 598	599	600	
			, {2739, -55, -71, 5}, {741, -58, -70, 5}, {888, -56, -67, 0}// 601	605	606	
			, {740, -56, -73, 5}, {2742, -55, -69, 5}, {2744, -57, -72, 5}// 608	610	611	
			, {2743, -57, -70, 5}, {2739, -56, -71, 5}, {741, -58, -69, 5}// 612	616	618	
			, {740, -55, -73, 5}, {2740, -56, -72, 5}, {738, -58, -68, 5}// 619	620	621	
			, {735, -55, -68, 5}, {2742, -56, -69, 5}, {2653, -57, -72, 5}// 622	624	625	
			, {737, -58, -73, 5}, {2747, -57, -69, 5}, {3899, -62, -79, 6}// 626	627	628	
			, {2148, -65, -77, 6}, {2148, -65, -78, 6}, {5193, -62, -78, 6}// 629	630	631	
			, {6952, -64, -78, 6}, {3896, -64, -77, 6}, {6955, -64, -79, 6}// 632	633	634	
			, {4977, -62, -79, 11}, {2158, -61, -78, 6}, {3893, -62, -77, 6}// 635	636	637	
			, {2148, -65, -79, 6}, {2148, -61, -77, 6}, {2147, -63, -80, 6}// 638	639	640	
			, {2147, -62, -80, 6}, {2147, -64, -80, 6}, {5193, -63, -77, 6}// 641	642	643	
			, {2147, -61, -80, 6}, {3894, -64, -79, 6}, {4090, -63, -79, 9}// 644	645	646	
			, {2149, -65, -80, 6}, {3900, -64, -77, 6}, {2148, -61, -79, 6}// 647	648	649	
			, {4150, -63, -78, 6}, {6953, -61, -77, 6}, {6953, -61, -78, 6}// 650	651	652	
			, {6951, -62, -79, 6}, {6951, -63, -79, 6}, {6958, -61, -79, 6}// 653	654	655	
			, {6952, -64, -77, 6}, {4016, -61, -91, 5}, {5, -58, -82, 5}// 656	657	658	
			, {4, -59, -82, 5}, {888, -62, -91, 0}, {4017, -60, -91, 7}// 660	661	662	
			, {735, -60, -92, 5}, {738, -64, -92, 5}, {4219, -63, -91, 5}// 663	664	665	
			, {734, -59, -92, 5}, {735, -63, -92, 5}, {735, -61, -92, 5}// 666	667	669	
			, {7135, -58, -92, 5}, {888, -61, -91, 0}, {888, -64, -91, 0}// 670	673	674	
			, {735, -62, -92, 5}, {888, -60, -91, 0}, {5690, -56, -87, 6}// 675	676	677	
			, {888, -63, -91, 0}, {2743, -63, -95, 5}, {889, -58, -96, 0}// 679	680	681	
			, {889, -58, -97, 0}, {2740, -62, -96, 5}, {2744, -63, -96, 5}// 682	684	685	
			, {740, -63, -97, 5}, {736, -59, -96, 5}, {741, -64, -94, 5}// 691	692	693	
			, {740, -60, -97, 5}, {2745, -60, -96, 5}, {2739, -62, -95, 5}// 694	696	699	
			, {737, -64, -97, 5}, {2742, -61, -93, 5}, {2739, -61, -94, 5}// 702	704	705	
			, {2739, -62, -94, 5}, {2653, -63, -96, 5}, {2747, -63, -93, 5}// 706	707	708	
			, {741, -64, -93, 5}, {889, -58, -95, 0}, {740, -61, -97, 5}// 709	711	713	
			, {2658, -62, -96, 5}, {889, -58, -93, 0}, {889, -58, -94, 0}// 715	716	718	
			, {2746, -60, -93, 5}, {741, -64, -96, 5}, {2741, -60, -95, 5}// 719	720	723	
			, {2742, -62, -93, 5}, {2740, -61, -96, 5}, {2743, -63, -94, 5}// 724	726	727	
			, {2739, -61, -95, 5}, {740, -62, -97, 5}, {2741, -60, -94, 5}// 728	730	731	
			, {739, -59, -97, 5}, {736, -59, -93, 5}, {741, -64, -95, 5}// 732	733	734	
			, {9966, -60, -138, 5}, {12578, -60, -138, 5}, {7054, -68, -146, 5}// 736	737	738	
			, {7065, -68, -147, 5}, {7042, -68, -145, 5}, {3231, -60, -146, 5}// 739	740	742	
			, {3232, -59, -146, 5}, {3236, -59, -145, 5}, {3232, -60, -145, 5}// 743	744	745	
			, {3235, -60, -145, 5}, {3221, -56, -145, 5}, {3236, -57, -163, 6}// 746	747	748	
			, {3232, -57, -164, 6}, {9966, -58, -161, 5}, {3236, -63, -162, 6}// 749	750	751	
			, {12578, -58, -161, 5}, {3231, -64, -163, 6}, {3232, -63, -163, 6}// 752	754	755	
			, {3235, -64, -162, 6}, {3232, -64, -162, 6}, {3221, -63, -159, 5}// 756	757	758	
			, {3232, -58, -163, 6}, {3231, -58, -164, 6}, {3235, -58, -163, 6}// 759	760	761	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SummerEvent1AddonDeed();
			}
		}

		[ Constructable ]
		public SummerEvent1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8734, 30, -163, 5, 2498, -1, "Enchanted Crystal", 1);// 90
			AddComplexComponent( (BaseAddon) this, 17077, 16, -88, 25, 0, -1, "This Champ is ALWAYS active, it will cycle through the levels automatically!", 1);// 151
			AddComplexComponent( (BaseAddon) this, 8734, 23, -136, 5, 2498, -1, "Enchanted Crystal", 1);// 152
			AddComplexComponent( (BaseAddon) this, 8734, 21, -162, 5, 2498, -1, "Enchanted Crystal", 1);// 153
			AddComplexComponent( (BaseAddon) this, 17077, -6, 52, 24, 0, -1, "Spawn Control", 1);// 165
			AddComplexComponent( (BaseAddon) this, 8734, 2, -138, 5, 2498, -1, "Enchanted Crystal", 1);// 201
			AddComplexComponent( (BaseAddon) this, 8734, 3, -158, 5, 2498, -1, "Enchanted Crystal", 1);// 202
			AddComplexComponent( (BaseAddon) this, 8734, -17, -155, 5, 2498, -1, "Enchanted Crystal", 1);// 263
			AddComplexComponent( (BaseAddon) this, 8734, -19, -166, 5, 2498, -1, "Enchanted Crystal", 1);// 264
			AddComplexComponent( (BaseAddon) this, 8734, -25, -132, 5, 2498, -1, "Enchanted Crystal", 1);// 331
			AddComplexComponent( (BaseAddon) this, 8734, -33, -144, 5, 2498, -1, "Enchanted Crystal", 1);// 332
			AddComplexComponent( (BaseAddon) this, 8734, -33, -162, 5, 2498, -1, "Enchanted Crystal", 1);// 333
			AddComplexComponent( (BaseAddon) this, 4012, -50, -71, 5, 0, 29, "", 1);// 416
			AddComplexComponent( (BaseAddon) this, 1538, -54, -70, 28, 577, -1, "", 1);// 418
			AddComplexComponent( (BaseAddon) this, 1541, -53, -72, 25, 577, -1, "", 1);// 419
			AddComplexComponent( (BaseAddon) this, 1538, -53, -70, 25, 577, -1, "", 1);// 420
			AddComplexComponent( (BaseAddon) this, 1537, -54, -68, 25, 577, -1, "", 1);// 421
			AddComplexComponent( (BaseAddon) this, 1540, -53, -68, 25, 577, -1, "", 1);// 422
			AddComplexComponent( (BaseAddon) this, 1540, -54, -69, 28, 577, -1, "", 1);// 424
			AddComplexComponent( (BaseAddon) this, 1536, -54, -72, 25, 577, -1, "", 1);// 425
			AddComplexComponent( (BaseAddon) this, 1541, -54, -71, 28, 577, -1, "", 1);// 426
			AddComplexComponent( (BaseAddon) this, 1538, -53, -69, 25, 577, -1, "", 1);// 427
			AddComplexComponent( (BaseAddon) this, 1538, -53, -71, 25, 577, -1, "", 1);// 428
			AddComplexComponent( (BaseAddon) this, 2421, -50, -85, 8, 0, -1, "A Witch's Cauldron", 1);// 443
			AddComplexComponent( (BaseAddon) this, 8734, -52, -120, 5, 2498, -1, "Enchanted Crystal", 1);// 458
			AddComplexComponent( (BaseAddon) this, 8734, -54, -142, 5, 2498, -1, "Enchanted Crystal", 1);// 459
			AddComplexComponent( (BaseAddon) this, 6868, -51, -161, 19, 2415, -1, "", 1);// 468
			AddComplexComponent( (BaseAddon) this, 6868, -46, -163, 20, 2415, -1, "", 1);// 469
			AddComplexComponent( (BaseAddon) this, 6868, -45, -159, 13, 2415, -1, "", 1);// 471
			AddComplexComponent( (BaseAddon) this, 6868, -49, -158, 35, 2415, -1, "", 1);// 478
			AddComplexComponent( (BaseAddon) this, 2280, -65, -52, 9, 1, -1, "", 1);// 536
			AddComplexComponent( (BaseAddon) this, 2280, -65, -50, 17, 1, -1, "", 1);// 539
			AddComplexComponent( (BaseAddon) this, 2280, -67, -50, 8, 1, -1, "", 1);// 540
			AddComplexComponent( (BaseAddon) this, 2280, -65, -51, 19, 1, -1, "", 1);// 554
			AddComplexComponent( (BaseAddon) this, 2280, -66, -50, 17, 1, -1, "", 1);// 555
			AddComplexComponent( (BaseAddon) this, 10749, -63, -50, 7, 0, 0, "", 1);// 557
			AddComplexComponent( (BaseAddon) this, 2280, -65, -51, 11, 1, -1, "", 1);// 560
			AddComplexComponent( (BaseAddon) this, 2280, -66, -50, 11, 1, -1, "", 1);// 561
			AddComplexComponent( (BaseAddon) this, 15959, -64, -47, 5, 88, -1, "Summer Fest Pet MondainsMount/MinTameSkill/100/ItemID/16076/Female/False/Str/7897/Dex/1000/Int/800/BaseSoundID/229/BodyValue/719/Hue/2725/Name/Animagus/", 1);// 564
			AddComplexComponent( (BaseAddon) this, 2280, -66, -51, 16, 1, -1, "", 1);// 569
			AddComplexComponent( (BaseAddon) this, 1535, -57, -71, 25, 577, -1, "", 1);// 587
			AddComplexComponent( (BaseAddon) this, 1537, -56, -68, 25, 577, -1, "", 1);// 588
			AddComplexComponent( (BaseAddon) this, 1537, -55, -68, 25, 577, -1, "", 1);// 589
			AddComplexComponent( (BaseAddon) this, 1543, -57, -68, 25, 577, -1, "", 1);// 593
			AddComplexComponent( (BaseAddon) this, 1535, -57, -69, 25, 577, -1, "", 1);// 594
			AddComplexComponent( (BaseAddon) this, 1536, -56, -72, 25, 577, -1, "", 1);// 602
			AddComplexComponent( (BaseAddon) this, 1535, -57, -70, 25, 577, -1, "", 1);// 603
			AddComplexComponent( (BaseAddon) this, 1542, -57, -72, 25, 577, -1, "", 1);// 604
			AddComplexComponent( (BaseAddon) this, 1543, -56, -69, 28, 577, -1, "", 1);// 607
			AddComplexComponent( (BaseAddon) this, 1535, -56, -70, 28, 577, -1, "", 1);// 609
			AddComplexComponent( (BaseAddon) this, 1542, -56, -71, 28, 577, -1, "", 1);// 613
			AddComplexComponent( (BaseAddon) this, 1536, -55, -72, 25, 577, -1, "", 1);// 614
			AddComplexComponent( (BaseAddon) this, 1536, -55, -71, 28, 577, -1, "", 1);// 615
			AddComplexComponent( (BaseAddon) this, 1544, -55, -70, 36, 577, -1, "", 1);// 617
			AddComplexComponent( (BaseAddon) this, 1537, -55, -69, 28, 577, -1, "", 1);// 623
			AddComplexComponent( (BaseAddon) this, 1537, -62, -92, 25, 577, -1, "", 1);// 659
			AddComplexComponent( (BaseAddon) this, 1540, -59, -92, 25, 577, -1, "", 1);// 668
			AddComplexComponent( (BaseAddon) this, 1537, -61, -92, 25, 577, -1, "", 1);// 671
			AddComplexComponent( (BaseAddon) this, 1537, -60, -92, 25, 577, -1, "", 1);// 672
			AddComplexComponent( (BaseAddon) this, 1543, -63, -92, 25, 577, -1, "", 1);// 678
			AddComplexComponent( (BaseAddon) this, 1542, -62, -95, 28, 577, -1, "", 1);// 683
			AddComplexComponent( (BaseAddon) this, 1538, -59, -94, 25, 577, -1, "", 1);// 686
			AddComplexComponent( (BaseAddon) this, 1543, -62, -93, 28, 577, -1, "", 1);// 687
			AddComplexComponent( (BaseAddon) this, 1537, -61, -93, 28, 577, -1, "", 1);// 688
			AddComplexComponent( (BaseAddon) this, 1540, -60, -93, 28, 577, -1, "", 1);// 689
			AddComplexComponent( (BaseAddon) this, 1538, -59, -93, 25, 577, -1, "", 1);// 690
			AddComplexComponent( (BaseAddon) this, 1541, -59, -96, 25, 577, -1, "", 1);// 695
			AddComplexComponent( (BaseAddon) this, 4012, -56, -95, 5, 0, 29, "", 1);// 697
			AddComplexComponent( (BaseAddon) this, 1538, -60, -94, 28, 577, -1, "", 1);// 698
			AddComplexComponent( (BaseAddon) this, 1541, -60, -95, 28, 577, -1, "", 1);// 700
			AddComplexComponent( (BaseAddon) this, 1535, -63, -95, 25, 577, -1, "", 1);// 701
			AddComplexComponent( (BaseAddon) this, 1535, -63, -94, 25, 577, -1, "", 1);// 703
			AddComplexComponent( (BaseAddon) this, 1538, -59, -95, 25, 577, -1, "", 1);// 710
			AddComplexComponent( (BaseAddon) this, 1544, -61, -94, 36, 577, -1, "", 1);// 712
			AddComplexComponent( (BaseAddon) this, 1536, -61, -95, 28, 577, -1, "", 1);// 714
			AddComplexComponent( (BaseAddon) this, 1535, -63, -93, 25, 577, -1, "", 1);// 717
			AddComplexComponent( (BaseAddon) this, 1536, -60, -96, 25, 577, -1, "", 1);// 721
			AddComplexComponent( (BaseAddon) this, 1536, -62, -96, 25, 577, -1, "", 1);// 722
			AddComplexComponent( (BaseAddon) this, 1536, -61, -96, 25, 577, -1, "", 1);// 725
			AddComplexComponent( (BaseAddon) this, 1535, -62, -94, 28, 577, -1, "", 1);// 729
			AddComplexComponent( (BaseAddon) this, 1542, -63, -96, 25, 577, -1, "", 1);// 735
			AddComplexComponent( (BaseAddon) this, 6868, -57, -151, 5, 2415, -1, "", 1);// 741
			AddComplexComponent( (BaseAddon) this, 6868, -57, -165, 5, 2415, -1, "", 1);// 753

		}

		public SummerEvent1Addon( Serial serial ) : base( serial )
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

	public class SummerEvent1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SummerEvent1Addon();
			}
		}

		[Constructable]
		public SummerEvent1AddonDeed()
		{
			Name = "SummerEvent1";
		}

		public SummerEvent1AddonDeed( Serial serial ) : base( serial )
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