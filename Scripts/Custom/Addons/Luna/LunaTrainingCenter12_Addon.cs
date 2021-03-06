
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
	public class LunaTrainingCenter12_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3342, 31, 7, 0}, {3344, 34, 5, 0}, {3142, 31, 8, 0}// 1	2	3	
			, {3144, 30, 7, 0}, {3128, 34, 2, 0}, {3210, 24, 8, 0}// 4	5	6	
			, {3205, 34, 2, 0}, {3143, 24, 6, 0}, {3127, 22, 3, 0}// 7	8	9	
			, {3143, 20, 2, 0}, {7108, 23, 2, 6}, {4184, 31, 2, 18}// 10	11	12	
			, {3205, 22, 4, 0}, {3208, 20, 2, 0}, {6986, 32, 3, 0}// 13	14	15	
			, {6991, 33, 2, 0}, {6990, 32, 2, 0}, {6988, 31, 2, 0}// 16	17	18	
			, {6987, 31, 3, 0}, {6983, 29, 2, 0}, {6984, 30, 2, 0}// 19	20	21	
			, {6980, 30, 3, 0}, {6982, 28, 2, 0}, {6979, 29, 3, 0}// 22	23	24	
			, {6978, 28, 3, 0}, {7000, 29, 5, 0}, {6999, 28, 5, 0}// 25	26	27	
			, {6998, 28, 6, 0}, {6997, 28, 7, 0}, {6995, 29, 7, 0}// 28	29	30	
			, {6975, 30, 4, 0}, {6977, 28, 4, 0}, {6976, 29, 4, 0}// 31	32	33	
			, {7017, 32, 3, 0}, {7015, 31, 4, 0}, {7016, 31, 3, 0}// 34	35	36	
			, {3209, 24, 6, 0}, {7017, 32, 5, 0}, {1173, 27, 5, 0}// 37	38	39	
			, {7018, 33, 5, 0}, {7014, 30, 4, 0}, {7019, 34, 5, 0}// 40	41	42	
			, {7008, 33, 4, 0}, {7008, 33, 6, 0}, {7012, 30, 5, 0}// 43	44	45	
			, {1173, 23, 4, 0}, {1173, 24, 2, 0}, {1173, 26, 5, 0}// 46	47	48	
			, {1173, 23, 3, 0}, {1173, 26, 4, 0}, {1173, 25, 4, 0}// 49	50	51	
			, {1173, 25, 3, 0}, {1173, 25, 2, 0}, {1173, 24, 3, 0}// 52	53	54	
			, {1173, 26, 2, 0}, {1173, 27, 3, 0}, {7019, 34, 3, 0}// 55	56	57	
			, {7016, 31, 5, 0}, {7018, 33, 3, 0}, {7002, 30, 5, 0}// 58	59	60	
			, {3149, 24, 7, 0}, {7011, 31, 5, 0}, {7013, 30, 3, 0}// 61	62	63	
			, {1173, 26, 3, 0}, {3214, 22, 3, 0}, {7001, 29, 6, 0}// 64	65	66	
			, {1173, 24, 4, 0}, {7014, 30, 6, 0}, {7015, 31, 6, 0}// 67	68	69	
			, {7621, 23, 2, 0}, {7620, 24, 2, 0}, {6996, 30, 7, 0}// 70	71	72	
			, {1173, 24, 5, 0}, {1173, 23, 2, 0}, {7011, 31, 7, 0}// 73	74	75	
			, {7010, 32, 7, 0}, {7010, 32, 5, 0}, {7009, 32, 6, 0}// 76	77	78	
			, {7007, 34, 4, 0}, {7009, 32, 4, 0}, {1173, 25, 5, 0}// 79	80	81	
			, {1173, 27, 4, 0}, {7003, 30, 6, 0}, {1173, 23, 5, 0}// 82	83	84	
			, {1173, 27, 2, 0}, {7007, 34, 6, 0}, {3346, 23, -5, 0}// 85	86	87	
			, {3128, 27, -1, 0}, {3144, 28, -6, 0}, {3264, 22, -3, 0}// 88	89	90	
			, {3143, 27, -4, 0}, {3209, 23, -6, 0}, {3145, 28, -2, 0}// 91	92	93	
			, {3211, 23, -1, 0}, {3206, 23, -3, 0}, {3127, 27, 1, 0}// 94	95	96	
			, {3211, 27, 0, 0}, {3344, 33, 0, 0}, {3247, 33, -6, 0}// 97	98	99	
			, {3245, 33, -3, 0}, {3265, 27, -2, 0}, {3236, 34, -1, 0}// 100	101	102	
			, {3209, 22, -2, 0}, {10644, 28, -7, 0}, {3268, 32, -1, 0}// 103	106	107	
			, {3223, 32, -6, 0}, {3272, 32, -4, 0}, {3149, 34, 0, 0}// 108	109	110	
			, {10644, 20, -7, 0}, {3263, 22, 0, 0}, {3209, 21, -4, 0}// 114	117	118	
			, {10644, 26, -7, 0}, {3220, 32, -2, 0}, {3220, 33, -1, 0}// 123	124	125	
			, {3231, 32, -3, 0}, {3234, 32, -5, 0}, {3211, 19, 1, 0}// 126	127	128	
			, {3204, 28, -2, 0}, {3214, 20, 1, 0}, {1206, 20, -2, 0}// 129	130	131	
			, {1206, 20, -1, 0}, {1206, 20, 0, 0}, {1206, 21, -3, 0}// 132	133	134	
			, {1206, 21, -2, 0}, {1206, 21, -1, 0}, {1206, 21, 0, 0}// 135	136	137	
			, {3763, 20, -3, 6}, {12788, 34, -4, 0}, {12788, 34, -3, 0}// 138	139	140	
			, {12788, 34, -2, 0}, {12788, 34, -5, 0}, {12788, 33, -6, 0}// 141	142	143	
			, {3214, 22, 1, 0}, {6993, 32, 1, 0}, {7620, 21, -3, 0}// 144	145	146	
			, {1206, 19, 0, 0}, {7621, 29, 1, 0}, {7620, 30, 1, 0}// 147	148	149	
			, {1318, 34, -7, 0}, {12788, 33, -5, 0}, {12788, 33, -4, 0}// 150	151	154	
			, {7621, 20, -3, 0}, {5356, 29, 1, 6}, {3207, 21, 1, 0}// 155	156	157	
			, {3213, 21, -5, 0}, {12788, 33, -2, 0}, {12788, 34, -6, 0}// 158	159	160	
			, {3209, 28, -4, 0}, {1206, 19, -2, 0}, {3262, 20, 1, 0}// 161	162	163	
			, {1206, 19, -1, 0}, {6992, 33, 1, 0}, {6989, 31, 1, 0}// 164	165	166	
			, {12788, 33, -3, 0}, {1206, 20, -3, 0}, {2860, 33, -4, 0}// 167	168	169	
			, {10644, 23, -7, 0}, {1206, 19, -3, 0}, {1318, 33, -7, 0}// 172	173	174	
			, {3206, 8, 8, 0}, {3214, 5, 8, 0}, {3265, 18, 6, 0}// 175	176	177	
			, {3127, 18, 7, 0}, {3147, 17, 2, 0}, {2778, 6, 2, 0}// 178	179	200	
			, {2778, 6, 3, 0}, {2778, 7, 2, 0}, {2778, 7, 3, 0}// 201	202	203	
			, {2778, 8, 2, 0}, {2778, 8, 3, 0}, {2778, 9, 2, 0}// 204	205	206	
			, {2778, 9, 3, 0}, {2778, 10, 2, 0}, {2778, 10, 3, 0}// 207	208	209	
			, {2783, 5, 2, 0}, {2783, 5, 3, 0}, {2785, 11, 2, 0}// 210	211	212	
			, {2785, 11, 3, 0}, {2778, 6, 4, 0}, {2778, 7, 4, 0}// 213	214	215	
			, {2778, 8, 4, 0}, {2778, 9, 4, 0}, {2778, 10, 4, 0}// 216	217	218	
			, {2779, 11, 5, 0}, {2781, 5, 5, 0}, {2783, 5, 4, 0}// 219	220	221	
			, {2785, 11, 4, 0}, {2786, 6, 5, 0}, {2786, 7, 5, 0}// 222	223	224	
			, {2786, 8, 5, 0}, {2786, 9, 5, 0}, {2786, 10, 5, 0}// 225	226	227	
			, {3204, 3, 8, 0}, {3206, 3, 6, 0}, {3264, 16, 2, 0}// 232	261	274	
			, {3212, 16, -3, 0}, {3203, 11, -5, 0}, {3203, 8, -6, 0}// 278	279	280	
			, {3206, 7, -5, 0}, {3263, 11, -3, 0}, {3210, 9, -5, 0}// 281	282	283	
			, {3212, 5, -4, 0}, {3250, 11, -6, 0}, {3144, 4, -5, 0}// 284	285	286	
			, {3145, 5, -6, 0}, {3144, 8, -5, 0}, {3143, 11, -5, 0}// 287	288	289	
			, {3148, 12, -6, 0}, {3263, 16, -1, 0}, {10644, 15, -7, 0}// 290	291	294	
			, {10644, 17, -7, 0}, {3204, 16, -5, 0}, {3353, 17, -6, 0}// 295	296	298	
			, {3213, 17, -4, 0}, {3262, 17, 1, 0}, {3264, 16, -4, 0}// 303	307	309	
			, {10644, 12, -7, 0}, {2778, 6, 0, 0}, {2778, 6, 1, 0}// 312	349	350	
			, {2778, 7, 0, 0}, {2778, 7, 1, 0}, {2778, 8, 0, 0}// 351	352	353	
			, {2778, 8, 1, 0}, {2778, 9, 0, 0}, {2778, 9, 1, 0}// 354	355	356	
			, {2778, 10, 0, 0}, {2778, 10, 1, 0}, {2780, 5, -1, 0}// 357	358	359	
			, {2782, 11, -1, 0}, {2783, 5, 0, 0}, {2783, 5, 1, 0}// 360	361	362	
			, {2784, 6, -1, 0}, {2784, 7, -1, 0}, {2784, 8, -1, 0}// 363	364	365	
			, {2784, 9, -1, 0}, {2784, 10, -1, 0}, {2785, 11, 0, 0}// 366	367	368	
			, {2785, 11, 1, 0}, {3263, 18, 1, 0}, {1206, 18, -2, 0}// 369	370	373	
			, {1206, 18, -3, 0}, {1206, 17, 0, 0}, {3209, 17, 1, 0}// 377	378	403	
			, {1206, 17, -3, 0}, {3211, 16, 0, 0}, {1206, 17, -1, 0}// 404	410	412	
			, {1206, 17, -2, 0}, {1206, 18, -1, 0}, {3207, 16, 1, 0}// 413	418	419	
			, {1206, 18, 0, 0}, {3204, -7, 3, 0}, {3353, -5, 7, 0}// 422	424	425	
			, {3213, 1, 5, 0}, {3213, 1, 3, 0}, {3244, 0, 7, 0}// 426	427	428	
			, {3252, -7, 6, 0}, {3147, -7, 3, 0}, {3145, -8, 3, 0}// 429	430	431	
			, {3127, -7, 6, 0}, {3143, -6, 7, 0}, {3143, -7, 8, 0}// 432	433	434	
			, {3127, -9, 8, 0}, {3146, -1, 7, 0}, {3141, 1, 7, 0}// 435	436	437	
			, {3128, -4, 7, 0}, {3147, 1, 4, 0}, {3210, -11, 7, 0}// 438	439	440	
			, {3350, -7, 3, 0}, {3263, 1, 6, 0}, {3263, -8, 5, 0}// 441	442	443	
			, {3213, -12, 8, 0}, {6209, -9, 4, 6}, {6196, -8, 3, 12}// 444	445	446	
			, {4017, -9, 6, 0}, {2316, -9, 4, 6}, {12788, -1, 2, 0}// 447	448	449	
			, {12788, -1, 3, 0}, {6160, -9, 3, 6}, {15107, -3, 2, 1}// 450	451	452	
			, {12788, -2, 2, 0}, {12788, -2, 3, 0}, {3203, -5, 5, 0}// 453	454	455	
			, {1318, -10, 3, 0}, {1318, -9, 2, 0}, {1318, -9, 4, 0}// 457	458	459	
			, {1318, -9, 3, 0}, {1318, -9, 5, 0}, {1318, -13, 5, 0}// 460	461	462	
			, {3543, -2, 3, 1}, {1318, -12, 2, 0}, {7618, -9, 2, 0}// 464	465	466	
			, {3543, -3, 4, 2}, {1318, -11, 4, 0}, {1318, -11, 3, 0}// 469	470	471	
			, {1318, -11, 2, 0}, {1318, -12, 5, 0}, {1318, -13, 6, 0}// 472	473	480	
			, {7619, -9, 3, 0}, {1318, -12, 4, 0}, {1318, -12, 3, 0}// 485	486	487	
			, {12788, -1, 4, 0}, {7617, -9, 4, 0}, {1318, -13, 2, 0}// 488	489	490	
			, {3212, -1, 5, 0}, {3204, -6, 4, 0}, {1318, -13, 3, 0}// 491	492	493	
			, {1318, -13, 4, 0}, {12788, -5, 4, 0}, {12788, -4, 4, 0}// 494	495	496	
			, {3203, -6, 2, 1}, {1318, -10, 6, 0}, {1318, -11, 6, 0}// 497	499	500	
			, {1318, -9, 6, 0}, {3235, 0, 5, 0}, {3235, -4, 5, 0}// 501	502	503	
			, {12788, -2, 4, 0}, {12788, -3, 4, 0}, {1318, -12, 6, 0}// 504	505	506	
			, {7621, -13, 6, 0}, {3203, -6, 3, 1}, {3203, 0, 4, 0}// 507	508	509	
			, {1318, -10, 5, 0}, {3203, -3, 5, 0}, {1318, -10, 4, 0}// 510	511	512	
			, {3203, 0, 2, 0}, {1318, -10, 2, 0}, {7710, -5, 3, 1}// 514	515	519	
			, {7710, -4, 3, 0}, {3211, -6, 5, 0}, {3204, 0, 3, 0}// 520	522	523	
			, {7620, -11, 6, 0}, {1318, -11, 5, 0}, {3264, -5, 6, 0}// 525	527	528	
			, {12788, -5, 2, 0}, {3213, -8, 2, 0}, {3206, -9, 8, 0}// 529	530	531	
			, {12788, -5, 3, 0}, {12788, -4, 2, 0}, {3204, -2, 5, 0}// 532	533	534	
			, {12788, -4, 3, 0}, {3263, -7, 8, 0}, {7622, -12, 6, 0}// 535	536	537	
			, {12788, -3, 2, 0}, {3206, -2, 6, 0}, {3208, 0, 7, 0}// 538	539	540	
			, {3211, -8, 7, 0}, {12788, -3, 3, 0}, {6206, -9, 2, 6}// 541	542	544	
			, {3342, 1, 0, 0}, {3212, 2, -5, 0}, {3209, 1, -3, 0}// 548	549	550	
			, {3265, -9, -5, 0}, {3208, -9, -3, 0}, {3209, -9, -2, 0}// 551	552	553	
			, {3209, -8, -3, 0}, {3211, -8, -1, 0}, {3211, -6, -5, 0}// 554	555	556	
			, {3253, 1, -5, 0}, {3253, -8, -6, 0}, {3253, -8, 1, 0}// 557	558	559	
			, {3142, -9, -5, 0}, {3148, -7, -5, 0}, {3150, -6, -5, 0}// 560	561	562	
			, {3146, -6, -4, 0}, {3146, -7, 0, 0}, {3143, -10, -3, 0}// 563	564	565	
			, {3142, -7, 0, 0}, {3142, 1, 1, 0}, {3147, 0, -2, 0}// 566	567	568	
			, {3149, -1, -5, 0}, {3143, 0, -5, 0}, {3341, -9, -4, 0}// 569	570	571	
			, {10644, -2, -7, 0}, {4017, -9, 0, 0}, {12788, -1, 1, 0}// 573	580	581	
			, {15106, -5, 1, 1}, {3203, 0, -1, 0}, {3203, 0, 0, 0}// 582	583	584	
			, {7710, -3, 1, 0}, {12788, -1, 0, 0}, {12788, -2, 1, 0}// 585	586	587	
			, {7710, -4, 1, 0}, {1318, -13, 1, 0}, {1318, -9, 0, 0}// 588	589	592	
			, {1318, -9, 1, 0}, {1318, -13, -7, 0}, {10644, -11, -7, 0}// 593	594	595	
			, {3543, -4, 0, 1}, {1318, -12, 1, 0}, {1318, -11, 1, 0}// 596	598	599	
			, {3543, -1, 0, 0}, {1318, -11, 0, 0}, {1318, -13, 0, 0}// 601	603	604	
			, {3233, -2, -1, 0}, {10644, -5, -7, 0}, {3212, -4, -1, 0}// 605	606	607	
			, {3211, 0, 1, 0}, {3211, -6, 1, 0}, {15103, -3, 0, 0}// 608	609	610	
			, {1318, -10, 0, 0}, {1318, -12, 0, 0}, {12788, -5, 0, 0}// 613	615	616	
			, {3203, -6, 0, 1}, {1318, -10, 1, 0}, {3203, -3, -1, 1}// 617	620	621	
			, {3203, -5, -1, 1}, {3204, -6, -1, 0}, {12788, -5, 1, 0}// 622	626	628	
			, {15107, -1, 1, 1}, {12788, -4, 0, 0}, {12788, -4, 1, 0}// 629	632	633	
			, {1318, -12, -7, 0}, {12788, -3, 0, 0}, {1318, -11, -7, 0}// 634	635	636	
			, {12788, -3, 1, 0}, {3148, -8, -3, 0}, {12788, -2, 0, 0}// 638	642	643	
			, {3204, -1, -1, 1}, {3145, -28, 2, 0}, {3142, -29, 3, 0}// 644	646	647	
			, {3205, -29, 3, 0}, {3352, -26, 7, 0}, {3344, -29, 8, 0}// 648	649	650	
			, {3212, -17, 4, 0}, {3204, -16, 4, 0}, {3207, -17, 6, 0}// 651	652	653	
			, {3145, -17, 2, 0}, {3128, -17, 4, 0}, {3127, -17, 8, 2}// 654	655	656	
			, {3145, -16, 7, 0}, {3144, -16, 6, 0}, {3209, -23, 7, 0}// 657	658	659	
			, {3205, -24, 7, 0}, {3208, -21, 7, 0}, {3143, -29, 2, 20}// 660	661	662	
			, {2142, -27, 2, 0}, {2142, -27, 3, 0}, {2142, -27, 4, 0}// 663	664	665	
			, {2142, -27, 5, 0}, {2142, -27, 6, 0}, {2142, -18, 2, 0}// 666	667	668	
			, {2142, -18, 3, 0}, {2142, -18, 4, 0}, {2142, -18, 5, 0}// 669	670	671	
			, {2142, -18, 6, 0}, {12788, -21, 3, 0}, {12788, -19, 5, 0}// 672	673	674	
			, {12788, -21, 2, 0}, {6237, -15, 3, 6}, {4084, -15, 4, 6}// 675	676	677	
			, {12788, -21, 6, 0}, {1318, -14, 2, 0}, {12788, -21, 5, 0}// 678	679	680	
			, {12788, -19, 2, 0}, {1318, -15, 4, 0}, {6212, -14, 3, 11}// 681	682	683	
			, {7617, -15, 4, 0}, {12788, -24, 5, 0}, {12788, -24, 6, 0}// 684	685	686	
			, {7619, -15, 3, 0}, {7618, -15, 2, 0}, {12788, -20, 5, 0}// 687	688	689	
			, {1318, -14, 6, 0}, {1318, -14, 4, 0}, {1318, -14, 3, 0}// 690	691	692	
			, {1318, -14, 5, 0}, {6198, -15, 2, 6}, {12788, -20, 6, 0}// 693	694	695	
			, {12788, -20, 4, 0}, {1318, -15, 2, 0}, {12788, -26, 2, 0}// 696	697	698	
			, {12788, -19, 3, 0}, {12788, -20, 2, 0}, {12788, -26, 6, 0}// 699	700	701	
			, {12788, -26, 4, 0}, {12788, -18, 5, 0}, {2141, -25, 6, 0}// 702	703	704	
			, {12788, -18, 2, 0}, {1318, -15, 5, 0}, {12788, -25, 3, 0}// 705	706	707	
			, {2141, -21, 6, 0}, {1318, -15, 6, 0}, {2141, -20, 6, 0}// 708	709	710	
			, {12788, -25, 2, 0}, {12788, -25, 4, 0}, {12788, -25, 5, 0}// 711	712	713	
			, {12788, -26, 3, 0}, {12788, -23, 3, 0}, {12788, -25, 6, 0}// 714	715	716	
			, {2141, -24, 6, 0}, {12788, -22, 5, 0}, {12788, -23, 2, 0}// 717	718	719	
			, {12788, -19, 6, 0}, {12788, -26, 5, 0}, {2141, -26, 6, 0}// 720	721	722	
			, {6203, -15, 4, 6}, {12788, -18, 6, 0}, {12788, -24, 4, 0}// 723	724	725	
			, {12788, -24, 3, 0}, {2141, -18, 6, 0}, {2141, -19, 6, 0}// 726	727	728	
			, {12788, -21, 4, 0}, {12788, -22, 3, 0}, {12788, -23, 6, 0}// 729	730	731	
			, {12788, -20, 3, 0}, {12788, -22, 2, 0}, {12788, -18, 4, 0}// 732	733	734	
			, {12788, -18, 3, 0}, {12788, -23, 4, 0}, {12788, -22, 6, 0}// 735	736	737	
			, {12788, -22, 4, 0}, {12788, -23, 5, 0}, {2141, -23, 6, 0}// 738	739	740	
			, {12788, -24, 2, 0}, {2141, -22, 6, 0}, {3263, -16, 7, 0}// 741	742	743	
			, {1318, -15, 3, 0}, {12788, -19, 4, 0}, {3141, -29, -4, 0}// 744	745	746	
			, {3127, -29, -1, 0}, {3352, -29, -6, 0}, {3341, -29, -3, 0}// 747	753	754	
			, {3148, -28, 1, 0}, {3207, -29, -4, 0}, {3207, -29, 0, 0}// 755	756	757	
			, {10644, -14, -7, 0}, {10644, -18, -7, 0}, {3148, -15, -5, 0}// 758	759	761	
			, {3213, -16, -5, 0}, {3208, -15, -2, 0}, {3264, -14, -4, 0}// 762	763	764	
			, {3207, -15, -3, 0}, {3214, -16, -2, 0}, {3206, -17, 1, 0}// 765	766	767	
			, {3147, -16, 0, 0}, {3143, -17, 1, 0}, {3148, -16, -2, 0}// 768	770	771	
			, {3150, -17, -4, 0}, {10644, -27, -7, 0}, {12788, -23, -5, 0}// 772	773	777	
			, {12788, -23, -4, 0}, {2142, -27, -2, 0}, {2142, -27, -1, 0}// 778	779	780	
			, {2142, -27, 0, 0}, {2142, -27, 1, 0}, {2142, -18, -6, 0}// 781	782	783	
			, {2142, -18, -5, 0}, {2142, -18, -4, 0}, {2142, -18, -3, 0}// 784	785	786	
			, {2142, -18, -2, 0}, {2142, -18, -1, 0}, {2142, -18, 0, 0}// 787	788	789	
			, {2142, -18, 1, 0}, {2152, -22, -7, 0}, {2143, -27, -7, 0}// 790	791	792	
			, {4017, -15, 0, 0}, {12788, -19, -2, 0}, {12788, -19, -3, 0}// 793	794	795	
			, {2141, -26, -7, 0}, {12788, -19, -1, 0}, {2141, -25, -7, 0}// 796	797	798	
			, {12788, -23, -1, 0}, {12788, -23, 0, 0}, {12788, -19, -5, 0}// 799	800	801	
			, {12788, -19, -6, 0}, {12788, -19, -4, 0}, {1318, -14, 0, 0}// 802	803	804	
			, {12788, -19, 0, 0}, {1318, -15, 0, 0}, {1318, -15, 1, 0}// 805	806	807	
			, {2150, -23, -7, 0}, {12788, -23, -6, 0}, {1318, -14, 1, 0}// 808	809	810	
			, {2141, -24, -7, 0}, {12788, -26, 1, 0}, {12788, -25, -5, 0}// 811	812	813	
			, {12788, -21, -2, 0}, {12788, -21, -3, 0}, {12788, -21, -5, 0}// 814	815	816	
			, {12788, -21, -1, 0}, {12788, -21, 0, 0}, {12788, -25, -4, 0}// 817	818	819	
			, {12788, -25, -2, 0}, {2142, -27, -3, 0}, {12788, -20, -4, 0}// 820	821	822	
			, {12788, -25, -3, 0}, {12788, -20, -1, 0}, {12788, -20, 0, 0}// 823	824	825	
			, {12788, -26, -2, 0}, {12788, -26, 0, 0}, {12788, -26, -1, 0}// 826	827	828	
			, {12788, -26, -5, 0}, {12788, -26, -3, 0}, {12788, -26, -4, 0}// 829	830	831	
			, {2141, -20, -7, 0}, {12788, -26, -6, 0}, {12788, -25, -6, 0}// 832	834	835	
			, {12788, -20, -3, 0}, {12788, -21, 1, 0}, {12788, -22, 0, 0}// 836	837	838	
			, {12788, -22, -4, 0}, {12788, -22, -5, 0}, {12788, -22, 1, 0}// 839	840	841	
			, {12788, -20, 1, 0}, {12788, -18, -4, 0}, {12788, -25, 1, 0}// 842	843	844	
			, {12788, -19, 1, 0}, {12788, -21, -6, 0}, {12788, -23, -2, 0}// 845	846	847	
			, {12788, -22, -6, 0}, {12788, -21, -4, 0}, {2141, -18, -7, 0}// 848	849	850	
			, {12788, -18, -3, 0}, {12788, -25, 0, 0}, {12788, -23, 1, 0}// 851	852	853	
			, {12788, -18, -6, 0}, {12788, -18, -5, 0}, {2142, -27, -6, 0}// 854	855	856	
			, {2142, -27, -5, 0}, {12788, -18, -1, 0}, {12788, -18, -2, 0}// 857	858	859	
			, {12788, -23, -3, 0}, {12788, -20, -2, 0}, {12788, -20, -5, 0}// 860	861	862	
			, {12788, -22, -1, 0}, {2141, -21, -7, 0}, {12788, -22, -2, 0}// 863	864	865	
			, {12788, -24, 1, 0}, {12788, -24, -4, 0}, {12788, -24, -5, 0}// 866	867	868	
			, {12788, -24, -6, 0}, {12788, -24, -3, 0}, {12788, -18, 1, 0}// 869	870	871	
			, {12788, -18, 0, 0}, {12788, -22, -3, 0}, {2141, -19, -7, 0}// 872	873	874	
			, {12788, -24, -2, 0}, {12788, -20, -6, 0}, {2142, -27, -4, 0}// 875	876	878	
			, {12788, -24, -1, 0}, {12788, -24, 0, 0}, {12788, -25, -1, 0}// 879	880	881	
			, {3145, -30, 3, 0}, {3265, -31, 8, 0}, {3145, -30, 6, 0}// 882	883	884	
			, {3127, -34, 7, 0}, {3148, -32, 8, 0}, {3148, -30, 8, 0}// 885	886	887	
			, {3212, -34, 8, 0}, {3127, -31, -3, 0}, {3145, -30, -4, 0}// 888	889	890	
			, {3148, -30, 0, 0}, {3345, -31, -4, 0}, {3145, -32, -5, 0}// 891	892	893	
			, {3263, -32, -6, 0}, {3208, -31, -3, 0}, {3148, -32, -6, 0}// 894	895	896	
			, {10644, -33, -7, 0}// 899	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LunaTrainingCenter12_AddonDeed();
			}
		}

		[ Constructable ]
		public LunaTrainingCenter12_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9014, 28, -6, 0, 1195, 29, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 9014, 27, -6, 0, 1195, 29, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 6093, 20, 1, 0, 0, -1, "tiny flowers", 1);// 111
			AddComplexComponent( (BaseAddon) this, 6093, 21, 1, 0, 0, -1, "tiny flowers", 1);// 112
			AddComplexComponent( (BaseAddon) this, 6093, 22, 0, 0, 0, -1, "tiny flowers", 1);// 113
			AddComplexComponent( (BaseAddon) this, 6093, 22, -3, 0, 0, -1, "tiny flowers", 1);// 115
			AddComplexComponent( (BaseAddon) this, 6093, 22, -4, 0, 0, -1, "tiny flowers", 1);// 116
			AddComplexComponent( (BaseAddon) this, 6093, 22, -1, 0, 0, -1, "tiny flowers", 1);// 119
			AddComplexComponent( (BaseAddon) this, 9014, 22, -6, 0, 1195, 29, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 9014, 21, -6, 0, 1195, 29, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 9014, 23, -6, 0, 1195, 29, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1114, 19, -1, 0, 1, -1, "Piano", 1);// 152
			AddComplexComponent( (BaseAddon) this, 6093, 21, -5, 0, 0, -1, "tiny flowers", 1);// 153
			AddComplexComponent( (BaseAddon) this, 3772, 19, 0, 12, 1, -1, "Piano", 1);// 170
			AddComplexComponent( (BaseAddon) this, 3774, 19, 0, 15, 0, -1, "Sheet Music", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1540, 9, 3, 33, 53, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1535, 7, 3, 30, 53, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 1538, 10, 2, 30, 53, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 1541, 9, 2, 33, 53, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 1542, 8, 2, 33, 53, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1535, 7, 2, 30, 53, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1535, 6, 2, 27, 53, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 1535, 5, 2, 24, 53, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 888, 4, 7, 0, 37, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 888, 5, 7, 0, 37, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 888, 6, 7, 0, 37, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 889, 13, 5, 0, 37, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 888, 7, 7, 0, 37, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 888, 8, 7, 0, 37, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 888, 9, 7, 0, 37, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 888, 10, 7, 0, 37, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 888, 11, 7, 0, 37, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 889, 13, 2, 0, 37, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 889, 13, 3, 0, 37, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 889, 13, 4, 0, 37, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 1537, 7, 6, 24, 53, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 503, 4, 3, 0, 53, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 1537, 8, 5, 27, 53, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 1537, 9, 5, 27, 53, -1, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 1540, 12, 6, 24, 53, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 503, 4, 2, 0, 53, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 1538, 11, 2, 27, 53, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 1537, 11, 6, 24, 53, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 497, 11, 6, 0, 53, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 498, 12, 4, 0, 53, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 497, 9, 6, 0, 53, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 496, 12, 6, 0, 53, -1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 497, 8, 6, 0, 53, -1, "", 1);// 241
			AddComplexComponent( (BaseAddon) this, 1537, 9, 6, 24, 53, -1, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 1537, 10, 6, 24, 53, -1, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 1537, 8, 6, 24, 53, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 497, 7, 6, 0, 53, -1, "", 1);// 245
			AddComplexComponent( (BaseAddon) this, 1537, 7, 5, 27, 53, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 1535, 5, 5, 24, 53, -1, "", 1);// 247
			AddComplexComponent( (BaseAddon) this, 1535, 5, 4, 24, 53, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 1535, 6, 4, 27, 53, -1, "", 1);// 249
			AddComplexComponent( (BaseAddon) this, 1543, 7, 4, 30, 53, -1, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 1537, 8, 4, 30, 53, -1, "", 1);// 251
			AddComplexComponent( (BaseAddon) this, 1537, 6, 6, 24, 53, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 1537, 9, 4, 30, 53, -1, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 503, 4, 5, 0, 53, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 503, 4, 4, 0, 53, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1540, 10, 4, 30, 53, -1, "", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1538, 11, 4, 27, 53, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1538, 12, 4, 24, 53, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1537, 10, 5, 27, 53, -1, "", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1538, 12, 3, 24, 53, -1, "", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1538, 11, 3, 27, 53, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1538, 10, 3, 30, 53, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1543, 8, 3, 33, 53, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1538, 12, 2, 24, 53, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1535, 6, 3, 27, 53, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1535, 5, 3, 24, 53, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1540, 11, 5, 27, 53, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1543, 6, 5, 27, 53, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1538, 12, 5, 24, 53, -1, "", 1);// 270
			AddComplexComponent( (BaseAddon) this, 497, 10, 6, 0, 53, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1543, 5, 6, 24, 53, -1, "", 1);// 272
			AddComplexComponent( (BaseAddon) this, 498, 12, 5, 0, 53, -1, "", 1);// 273
			AddComplexComponent( (BaseAddon) this, 500, 4, 6, 0, 53, -1, "", 1);// 275
			AddComplexComponent( (BaseAddon) this, 497, 6, 6, 0, 53, -1, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 497, 5, 6, 0, 53, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 9014, 16, -6, 0, 1195, 29, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 9014, 17, -6, 0, 1195, 29, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 9014, 10, -6, 0, 1195, 29, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 9014, 7, -6, 0, 1195, 29, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 9014, 8, -6, 0, 1195, 29, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 9014, 3, -6, 0, 1195, 29, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 9014, 4, -6, 0, 1195, 29, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 6093, 16, -5, 0, 0, -1, "tiny flowers", 1);// 304
			AddComplexComponent( (BaseAddon) this, 6093, 18, 1, 0, 0, -1, "tiny flowers", 1);// 305
			AddComplexComponent( (BaseAddon) this, 6093, 16, 0, 0, 0, -1, "tiny flowers", 1);// 306
			AddComplexComponent( (BaseAddon) this, 6093, 16, -1, 0, 0, -1, "tiny flowers", 1);// 308
			AddComplexComponent( (BaseAddon) this, 9014, 6, -6, 0, 1195, 29, "", 1);// 310
			AddComplexComponent( (BaseAddon) this, 9014, 5, -6, 0, 1195, 29, "", 1);// 311
			AddComplexComponent( (BaseAddon) this, 9014, 11, -6, 0, 1195, 29, "", 1);// 313
			AddComplexComponent( (BaseAddon) this, 6093, 16, -3, 0, 0, -1, "tiny flowers", 1);// 314
			AddComplexComponent( (BaseAddon) this, 6093, 17, -4, 0, 0, -1, "tiny flowers", 1);// 315
			AddComplexComponent( (BaseAddon) this, 9014, 9, -6, 0, 1195, 29, "", 1);// 316
			AddComplexComponent( (BaseAddon) this, 502, 7, -2, 0, 53, -1, "", 1);// 317
			AddComplexComponent( (BaseAddon) this, 2928, 17, 0, 2, 1, -1, "Piano", 1);// 318
			AddComplexComponent( (BaseAddon) this, 5981, 17, 0, 6, 1, -1, "Piano", 1);// 319
			AddComplexComponent( (BaseAddon) this, 5984, 17, 0, 8, 1, -1, "Piano", 1);// 320
			AddComplexComponent( (BaseAddon) this, 1538, 12, 1, 24, 53, -1, "", 1);// 321
			AddComplexComponent( (BaseAddon) this, 1538, 11, 1, 27, 53, -1, "", 1);// 322
			AddComplexComponent( (BaseAddon) this, 1541, 10, 1, 30, 53, -1, "", 1);// 323
			AddComplexComponent( (BaseAddon) this, 1536, 9, 1, 30, 53, -1, "", 1);// 324
			AddComplexComponent( (BaseAddon) this, 1536, 8, 1, 30, 53, -1, "", 1);// 325
			AddComplexComponent( (BaseAddon) this, 1542, 7, 1, 30, 53, -1, "", 1);// 326
			AddComplexComponent( (BaseAddon) this, 1535, 6, 1, 27, 53, -1, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 1535, 3, -1, 2, 53, -1, "", 1);// 328
			AddComplexComponent( (BaseAddon) this, 1538, 12, 0, 24, 53, -1, "", 1);// 329
			AddComplexComponent( (BaseAddon) this, 1541, 11, 0, 27, 53, -1, "", 1);// 330
			AddComplexComponent( (BaseAddon) this, 1536, 10, 0, 27, 53, -1, "", 1);// 331
			AddComplexComponent( (BaseAddon) this, 1536, 9, 0, 27, 53, -1, "", 1);// 332
			AddComplexComponent( (BaseAddon) this, 1536, 8, 0, 27, 53, -1, "", 1);// 333
			AddComplexComponent( (BaseAddon) this, 1536, 7, 0, 27, 53, -1, "", 1);// 334
			AddComplexComponent( (BaseAddon) this, 1542, 6, 0, 27, 53, -1, "", 1);// 335
			AddComplexComponent( (BaseAddon) this, 1535, 5, 0, 24, 53, -1, "", 1);// 336
			AddComplexComponent( (BaseAddon) this, 1541, 12, -1, 24, 53, -1, "", 1);// 337
			AddComplexComponent( (BaseAddon) this, 1536, 11, -1, 24, 53, -1, "", 1);// 338
			AddComplexComponent( (BaseAddon) this, 1536, 10, -1, 24, 53, -1, "", 1);// 339
			AddComplexComponent( (BaseAddon) this, 1536, 9, -1, 24, 53, -1, "", 1);// 340
			AddComplexComponent( (BaseAddon) this, 1536, 8, -1, 24, 53, -1, "", 1);// 341
			AddComplexComponent( (BaseAddon) this, 1536, 7, -1, 24, 53, -1, "", 1);// 342
			AddComplexComponent( (BaseAddon) this, 1536, 4, -3, 2, 53, -1, "", 1);// 343
			AddComplexComponent( (BaseAddon) this, 1542, 3, -3, 2, 53, -1, "", 1);// 344
			AddComplexComponent( (BaseAddon) this, 889, 13, 0, 0, 37, -1, "", 1);// 345
			AddComplexComponent( (BaseAddon) this, 889, 13, -1, 0, 37, -1, "", 1);// 346
			AddComplexComponent( (BaseAddon) this, 889, 13, -2, 0, 37, -1, "", 1);// 347
			AddComplexComponent( (BaseAddon) this, 889, 13, 1, 0, 37, -1, "", 1);// 348
			AddComplexComponent( (BaseAddon) this, 503, 4, -1, 0, 53, -1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 503, 4, 0, 0, 53, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 2480, 17, -2, 2, 1, -1, "Piano", 1);// 374
			AddComplexComponent( (BaseAddon) this, 2924, 18, -2, 0, 1, -1, "Piano", 1);// 375
			AddComplexComponent( (BaseAddon) this, 2925, 18, -1, 0, 1, -1, "Piano", 1);// 376
			AddComplexComponent( (BaseAddon) this, 5991, 18, 0, 8, 1, -1, "Piano", 1);// 379
			AddComplexComponent( (BaseAddon) this, 739, 12, -2, 0, 53, -1, "", 1);// 380
			AddComplexComponent( (BaseAddon) this, 6093, 16, 1, 0, 0, -1, "tiny flowers", 1);// 381
			AddComplexComponent( (BaseAddon) this, 2845, 18, 0, 17, 0, 1, "A Candelabra", 1);// 382
			AddComplexComponent( (BaseAddon) this, 4006, 18, 0, 7, 0, -1, "Piano Keys", 1);// 383
			AddComplexComponent( (BaseAddon) this, 7031, 18, 0, 12, 1, -1, "Piano", 1);// 384
			AddComplexComponent( (BaseAddon) this, 5987, 18, 0, 9, 1, -1, "Piano", 1);// 385
			AddComplexComponent( (BaseAddon) this, 5986, 18, 0, 14, 1, -1, "Piano", 1);// 386
			AddComplexComponent( (BaseAddon) this, 5986, 18, 0, 12, 1, -1, "Piano", 1);// 387
			AddComplexComponent( (BaseAddon) this, 5987, 18, -1, 8, 1, -1, "Piano", 1);// 388
			AddComplexComponent( (BaseAddon) this, 5988, 18, -1, 10, 1, -1, "Piano", 1);// 389
			AddComplexComponent( (BaseAddon) this, 9014, 12, -6, 0, 1195, 29, "", 1);// 390
			AddComplexComponent( (BaseAddon) this, 7933, 18, -1, 9, 1, -1, "Piano", 1);// 391
			AddComplexComponent( (BaseAddon) this, 5981, 17, 0, 7, 1, -1, "Piano", 1);// 392
			AddComplexComponent( (BaseAddon) this, 5985, 17, 0, 9, 1, -1, "Piano", 1);// 393
			AddComplexComponent( (BaseAddon) this, 2480, 17, 0, 11, 1, -1, "Piano", 1);// 394
			AddComplexComponent( (BaseAddon) this, 502, 8, -2, 0, 53, -1, "", 1);// 395
			AddComplexComponent( (BaseAddon) this, 498, 12, -1, 0, 53, -1, "", 1);// 396
			AddComplexComponent( (BaseAddon) this, 502, 9, -2, 0, 53, -1, "", 1);// 397
			AddComplexComponent( (BaseAddon) this, 502, 10, -2, 0, 53, -1, "", 1);// 398
			AddComplexComponent( (BaseAddon) this, 5988, 18, -1, 9, 1, -1, "Piano", 1);// 399
			AddComplexComponent( (BaseAddon) this, 5991, 18, -1, 9, 1, -1, "Piano", 1);// 400
			AddComplexComponent( (BaseAddon) this, 2252, 18, -1, 11, 1, -1, "Piano", 1);// 401
			AddComplexComponent( (BaseAddon) this, 2923, 18, 0, 0, 1, -1, "Piano", 1);// 402
			AddComplexComponent( (BaseAddon) this, 6093, 17, 1, 0, 0, -1, "tiny flowers", 1);// 405
			AddComplexComponent( (BaseAddon) this, 502, 11, -2, 0, 53, -1, "", 1);// 406
			AddComplexComponent( (BaseAddon) this, 498, 12, 0, 0, 53, -1, "", 1);// 407
			AddComplexComponent( (BaseAddon) this, 7933, 17, 0, 7, 1, -1, "Piano", 1);// 408
			AddComplexComponent( (BaseAddon) this, 502, 6, -2, 0, 53, -1, "", 1);// 409
			AddComplexComponent( (BaseAddon) this, 503, 4, 1, 0, 53, -1, "", 1);// 411
			AddComplexComponent( (BaseAddon) this, 7883, 17, -1, 1, 1, -1, "Piano", 1);// 414
			AddComplexComponent( (BaseAddon) this, 502, 5, -2, 0, 53, -1, "", 1);// 415
			AddComplexComponent( (BaseAddon) this, 5985, 18, 0, 10, 1, -1, "Piano", 1);// 416
			AddComplexComponent( (BaseAddon) this, 7933, 18, 0, 14, 1, -1, "Piano", 1);// 417
			AddComplexComponent( (BaseAddon) this, 5981, 18, -1, 10, 1, -1, "Piano", 1);// 420
			AddComplexComponent( (BaseAddon) this, 4006, 18, -1, 7, 0, -1, "Piano Keys", 1);// 421
			AddComplexComponent( (BaseAddon) this, 5431, 17, 0, 10, 1, -1, "Piano", 1);// 423
			AddComplexComponent( (BaseAddon) this, 7385, -5, 2, 2, 1264, -1, "water", 1);// 456
			AddComplexComponent( (BaseAddon) this, 6093, -1, 5, 0, 0, -1, "tiny flowers", 1);// 463
			AddComplexComponent( (BaseAddon) this, 7385, -1, 3, 2, 1264, -1, "water", 1);// 467
			AddComplexComponent( (BaseAddon) this, 7385, -1, 4, 2, 1264, -1, "water", 1);// 468
			AddComplexComponent( (BaseAddon) this, 7385, -2, 4, 2, 1264, -1, "water", 1);// 474
			AddComplexComponent( (BaseAddon) this, 6093, -3, 5, 0, 0, -1, "tiny flowers", 1);// 475
			AddComplexComponent( (BaseAddon) this, 7385, -4, 4, 2, 1264, -1, "water", 1);// 476
			AddComplexComponent( (BaseAddon) this, 7385, -3, 4, 2, 1264, -1, "water", 1);// 477
			AddComplexComponent( (BaseAddon) this, 7385, -3, 3, 2, 1264, -1, "water", 1);// 478
			AddComplexComponent( (BaseAddon) this, 7385, -2, 3, 2, 1264, -1, "water", 1);// 479
			AddComplexComponent( (BaseAddon) this, 7385, -1, 2, 2, 1264, -1, "water", 1);// 481
			AddComplexComponent( (BaseAddon) this, 7385, -4, 3, 2, 1264, -1, "water", 1);// 482
			AddComplexComponent( (BaseAddon) this, 7385, -5, 4, 2, 1264, -1, "water", 1);// 483
			AddComplexComponent( (BaseAddon) this, 7385, -5, 3, 2, 1264, -1, "water", 1);// 484
			AddComplexComponent( (BaseAddon) this, 7385, -3, 2, 2, 1264, -1, "water", 1);// 498
			AddComplexComponent( (BaseAddon) this, 7385, -4, 2, 2, 1264, -1, "water", 1);// 513
			AddComplexComponent( (BaseAddon) this, 6093, 0, 4, 0, 0, -1, "tiny flowers", 1);// 516
			AddComplexComponent( (BaseAddon) this, 6093, 0, 2, 0, 0, -1, "tiny flowers", 1);// 517
			AddComplexComponent( (BaseAddon) this, 6093, -6, 5, 0, 0, -1, "tiny flowers", 1);// 518
			AddComplexComponent( (BaseAddon) this, 6093, -5, 5, 0, 0, -1, "tiny flowers", 1);// 521
			AddComplexComponent( (BaseAddon) this, 6093, -6, 3, 1, 0, -1, "tiny flowers", 1);// 524
			AddComplexComponent( (BaseAddon) this, 6093, -6, 2, 1, 0, -1, "tiny flowers", 1);// 526
			AddComplexComponent( (BaseAddon) this, 7385, -2, 2, 2, 1264, -1, "water", 1);// 543
			AddComplexComponent( (BaseAddon) this, 6093, -7, -4, 0, 0, -1, "tiny flowers", 1);// 545
			AddComplexComponent( (BaseAddon) this, 6093, -8, -3, 0, 0, -1, "tiny flowers", 1);// 546
			AddComplexComponent( (BaseAddon) this, 6093, -9, -5, 0, 0, -1, "tiny flowers", 1);// 547
			AddComplexComponent( (BaseAddon) this, 9014, 0, -6, 0, 1195, 29, "", 1);// 572
			AddComplexComponent( (BaseAddon) this, 9014, -7, -6, 0, 1195, 29, "", 1);// 574
			AddComplexComponent( (BaseAddon) this, 9014, -5, -6, 0, 1195, 29, "", 1);// 575
			AddComplexComponent( (BaseAddon) this, 9014, -6, -6, 0, 1195, 29, "", 1);// 576
			AddComplexComponent( (BaseAddon) this, 9014, -8, -6, 0, 1195, 29, "", 1);// 577
			AddComplexComponent( (BaseAddon) this, 9014, -9, -6, 0, 1195, 29, "", 1);// 578
			AddComplexComponent( (BaseAddon) this, 9014, -10, -6, 1, 1195, 29, "", 1);// 579
			AddComplexComponent( (BaseAddon) this, 7385, -5, 0, 2, 1264, -1, "water", 1);// 590
			AddComplexComponent( (BaseAddon) this, 7385, -5, 1, 2, 1264, -1, "", 1);// 591
			AddComplexComponent( (BaseAddon) this, 6093, 0, -1, 0, 0, -1, "tiny flowers", 1);// 597
			AddComplexComponent( (BaseAddon) this, 7385, -1, 0, 2, 1264, -1, "water", 1);// 600
			AddComplexComponent( (BaseAddon) this, 7385, -1, 1, 2, 1264, -1, "water", 1);// 602
			AddComplexComponent( (BaseAddon) this, 6093, -4, -1, 0, 0, -1, "tiny flowers", 1);// 611
			AddComplexComponent( (BaseAddon) this, 6093, -1, -1, 1, 0, -1, "tiny flowers", 1);// 612
			AddComplexComponent( (BaseAddon) this, 7385, -4, 0, 2, 1264, -1, "water", 1);// 614
			AddComplexComponent( (BaseAddon) this, 7385, -3, 1, 2, 1264, -1, "water", 1);// 618
			AddComplexComponent( (BaseAddon) this, 7385, -4, 1, 2, 1264, -1, "", 1);// 619
			AddComplexComponent( (BaseAddon) this, 7385, -3, 0, 2, 1264, -1, "water", 1);// 623
			AddComplexComponent( (BaseAddon) this, 6093, -4, -1, 0, 0, -1, "tiny flowers", 1);// 624
			AddComplexComponent( (BaseAddon) this, 6093, 0, 1, 0, 0, -1, "tiny flowers", 1);// 625
			AddComplexComponent( (BaseAddon) this, 6093, -6, 0, 1, 0, -1, "tiny flowers", 1);// 627
			AddComplexComponent( (BaseAddon) this, 7385, -2, 1, 2, 1264, -1, "water", 1);// 630
			AddComplexComponent( (BaseAddon) this, 7385, -2, 0, 2, 1264, -1, "water", 1);// 631
			AddComplexComponent( (BaseAddon) this, 9014, -1, -6, 0, 1195, 29, "", 1);// 637
			AddComplexComponent( (BaseAddon) this, 6093, -9, -4, 0, 0, -1, "tiny flowers", 1);// 639
			AddComplexComponent( (BaseAddon) this, 6093, -8, -6, 0, 0, -1, "tiny flowers", 1);// 640
			AddComplexComponent( (BaseAddon) this, 9014, 2, -6, 0, 1195, 29, "", 1);// 641
			AddComplexComponent( (BaseAddon) this, 9014, 1, -6, 0, 1195, 29, "", 1);// 645
			AddComplexComponent( (BaseAddon) this, 6093, -16, -2, 0, 0, -1, "tiny flowers", 1);// 748
			AddComplexComponent( (BaseAddon) this, 6093, -15, -4, 0, 0, -1, "tiny flowers", 1);// 749
			AddComplexComponent( (BaseAddon) this, 6093, -15, -2, 0, 0, -1, "tiny flowers", 1);// 750
			AddComplexComponent( (BaseAddon) this, 6093, -16, -5, 0, 0, -1, "tiny flowers", 1);// 751
			AddComplexComponent( (BaseAddon) this, 6093, -29, -4, 0, 0, -1, "tiny flowers", 1);// 752
			AddComplexComponent( (BaseAddon) this, 9014, -27, -6, 0, 1195, 29, "", 1);// 760
			AddComplexComponent( (BaseAddon) this, 9014, -14, -6, 0, 1195, 29, "", 1);// 769
			AddComplexComponent( (BaseAddon) this, 9014, -15, -6, 0, 1195, 29, "", 1);// 774
			AddComplexComponent( (BaseAddon) this, 9014, -16, -6, 0, 1195, 29, "", 1);// 775
			AddComplexComponent( (BaseAddon) this, 9014, -17, -6, 0, 1195, 29, "", 1);// 776
			AddComplexComponent( (BaseAddon) this, 9014, -29, -6, 0, 1195, 29, "", 1);// 833
			AddComplexComponent( (BaseAddon) this, 9014, -28, -6, 0, 1195, 29, "", 1);// 877
			AddComplexComponent( (BaseAddon) this, 9014, -32, -6, 0, 1195, 29, "", 1);// 897
			AddComplexComponent( (BaseAddon) this, 9014, -30, -6, 0, 1195, 29, "", 1);// 898
			AddComplexComponent( (BaseAddon) this, 9014, -31, -6, 0, 1195, 29, "", 1);// 900

		}

		public LunaTrainingCenter12_Addon( Serial serial ) : base( serial )
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

	public class LunaTrainingCenter12_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LunaTrainingCenter12_Addon();
			}
		}

		[Constructable]
		public LunaTrainingCenter12_AddonDeed()
		{
			Name = "LunaTrainingCenter12_";
		}

		public LunaTrainingCenter12_AddonDeed( Serial serial ) : base( serial )
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