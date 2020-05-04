
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
	public class LunaTrainingCenter11_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3144, 5, 5, 0}, {3150, 10, 6, 0}, {3147, 10, 7, 0}// 1	2	3	
			, {2819, 7, 2, 2}, {2786, 12, 4, 0}, {2786, 11, 4, 0}// 4	5	6	
			, {2786, 10, 4, 0}, {2786, 9, 4, 0}, {2778, 9, 2, 0}// 7	8	9	
			, {2778, 11, 2, 0}, {2778, 12, 2, 0}, {3263, 9, 6, 0}// 10	11	12	
			, {2778, 10, 2, 0}, {2778, 10, 3, 0}, {2786, 8, 4, 0}// 13	46	55	
			, {2785, 13, 3, 0}, {2783, 7, 2, 0}, {2778, 8, 3, 0}// 57	58	61	
			, {2778, 11, 3, 0}, {2779, 13, 4, 0}, {2778, 9, 3, 0}// 62	63	66	
			, {2822, 7, 2, 0}, {2778, 8, 2, 0}, {3146, 9, 7, 0}// 67	69	71	
			, {3128, 10, 7, 0}, {2778, 12, 3, 0}, {2785, 13, 2, 0}// 72	73	74	
			, {3144, 5, 4, 0}, {2783, 7, 3, 0}, {2781, 7, 4, 0}// 75	76	77	
			, {3340, 7, -6, 0}, {3144, 8, -6, 0}, {3148, 7, -6, 0}// 78	79	80	
			, {10644, 14, -7, 0}, {3343, 12, -6, 0}, {3346, 8, -5, 0}// 91	92	93	
			, {3143, 14, -4, 0}, {2813, 11, -2, 2}, {2814, 10, -2, 2}// 94	95	96	
			, {2815, 9, -2, 2}, {2816, 11, -2, 0}, {4229, 7, 1, 3}// 97	98	99	
			, {2778, 10, -1, 0}, {2782, 13, -2, 0}, {2778, 9, -1, 0}// 100	101	102	
			, {2778, 10, 0, 0}, {2785, 13, 1, 0}, {2778, 12, -1, 0}// 103	104	105	
			, {2778, 12, 0, 0}, {2780, 7, -2, 0}, {2778, 12, 1, 0}// 106	107	108	
			, {3207, 11, -6, 0}, {4232, 7, 0, 6}, {4235, 9, -2, 6}// 109	110	111	
			, {2778, 11, -1, 0}, {2818, 9, -2, 0}, {2817, 10, -2, 0}// 112	113	114	
			, {2778, 11, 1, 0}, {3214, 7, -6, 0}, {2783, 7, 0, 0}// 115	116	117	
			, {2778, 11, 0, 0}, {2778, 9, 0, 0}, {2783, 7, -1, 0}// 150	152	153	
			, {2778, 9, 1, 0}, {4230, 10, -2, 6}, {2778, 8, 0, 0}// 157	158	159	
			, {2784, 8, -2, 0}, {2784, 9, -2, 0}, {2784, 10, -2, 0}// 161	162	171	
			, {3878, 11, -2, 6}, {2824, 7, 0, 0}, {2823, 7, 1, 0}// 172	174	175	
			, {2778, 8, -1, 0}, {2784, 11, -2, 0}, {2784, 12, -2, 0}// 176	177	178	
			, {2783, 7, 1, 0}, {3141, 13, -6, 0}, {2821, 7, 0, 2}// 179	180	182	
			, {2820, 7, 1, 2}, {2785, 13, -1, 0}, {2778, 10, 1, 0}// 184	185	186	
			, {2785, 13, 0, 0}, {2778, 8, 1, 0}, {3342, -9, 4, 0}// 187	188	189	
			, {3342, 3, 2, 0}, {3146, -10, 7, 20}, {3145, -10, 4, 0}// 190	191	192	
			, {3141, -9, 6, 0}, {3149, -9, 7, 0}, {3147, -7, 7, 0}// 193	194	195	
			, {3127, -6, 7, 0}, {3141, -5, 5, 0}, {3143, -5, 5, 0}// 196	197	198	
			, {3128, -3, 5, 0}, {3150, -2, 5, 0}, {3128, -1, 7, 0}// 199	200	201	
			, {3141, -1, 5, 0}, {3143, 4, 7, 33}, {3142, 4, 3, 0}// 202	203	204	
			, {3208, -10, 6, 0}, {3263, -9, 6, 0}, {3205, 4, 4, 0}// 205	206	207	
			, {1318, -3, 2, 0}, {1318, -4, 2, 0}, {1318, -5, 2, 0}// 208	209	210	
			, {1318, -6, 2, 0}, {1318, -7, 2, 0}, {1318, -8, 2, 0}// 211	212	213	
			, {3142, 4, 6, 0}, {3150, 4, 5, 0}, {3209, -2, 4, 0}// 225	226	228	
			, {3263, -1, 6, 0}, {1318, -9, 2, 0}, {3150, 4, 7, 0}// 250	259	261	
			, {3208, -11, 7, 0}, {10644, -2, -7, 0}, {3341, 4, -5, 0}// 272	275	284	
			, {3342, -2, -6, 0}, {3148, -3, -6, 0}, {3143, -10, -7, 0}// 285	286	287	
			, {3141, 3, 1, 0}, {3141, 4, -1, 0}, {3145, 3, -4, 0}// 288	289	290	
			, {3127, 2, -4, 0}, {3143, 3, -6, 0}, {3147, 4, -5, 0}// 291	292	293	
			, {10644, 1, -7, 0}, {3203, 4, -5, 0}, {1318, -3, 1, 0}// 296	297	314	
			, {1318, -3, 0, 0}, {1318, -3, -1, 0}, {1318, -3, -2, 0}// 315	316	317	
			, {1318, -3, -3, 0}, {1318, -3, -4, 0}, {1318, -4, 1, 0}// 318	319	321	
			, {1318, -4, 0, 0}, {1318, -4, -1, 0}, {1318, -4, -2, 0}// 322	323	324	
			, {1318, -4, -3, 0}, {1318, -4, -4, 0}, {1318, -5, 1, 0}// 325	326	328	
			, {1318, -5, 0, 0}, {1318, -5, -1, 0}, {1318, -5, -2, 0}// 329	330	331	
			, {1318, -5, -3, 0}, {1318, -5, -4, 0}, {1318, -6, 1, 0}// 332	333	335	
			, {1318, -6, 0, 0}, {1318, -6, -1, 0}, {1318, -6, -2, 0}// 336	337	338	
			, {1318, -6, -3, 0}, {1318, -6, -4, 0}, {1318, -7, 1, 0}// 339	340	343	
			, {1318, -7, 0, 0}, {1318, -7, -1, 0}, {1318, -7, -2, 0}// 344	345	346	
			, {1318, -7, -3, 0}, {1318, -7, -4, 0}, {1318, -8, 1, 0}// 347	348	350	
			, {1318, -8, 0, 0}, {1318, -8, -1, 0}, {1318, -8, -2, 0}// 351	352	353	
			, {1318, -8, -3, 0}, {3208, 3, -3, 0}, {1318, -9, -4, 0}// 354	378	379	
			, {1318, -9, 1, 0}, {1318, -9, 0, 0}, {1318, -9, -2, 0}// 383	384	385	
			, {1318, -9, -3, 0}, {1318, -9, -1, 0}, {1318, -8, -4, 0}// 387	388	389	
			, {3149, -14, 5, 0}, {3142, -14, 7, 0}, {3264, -12, 2, 0}// 401	402	403	
			, {3262, -13, 7, 0}, {10644, -14, -7, 0}, {3346, -12, -3, 0}// 404	405	406	
			, {3149, -12, -5, 0}, {3145, -13, -3, 0}, {3142, -14, 1, 0}// 407	408	409	
			, {3204, -12, -1, 0}, {3208, -13, -3, 0}// 411	412	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LunaTrainingCenter11_AddonDeed();
			}
		}

		[ Constructable ]
		public LunaTrainingCenter11_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1535, 7, 2, 24, 53, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1535, 8, 2, 27, 53, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1535, 9, 2, 30, 53, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1540, 11, 2, 33, 53, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1543, 10, 2, 33, 53, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1538, 12, 2, 30, 53, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1538, 13, 2, 27, 53, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1538, 14, 2, 24, 53, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1538, 14, 3, 24, 53, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1538, 13, 3, 27, 53, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1540, 12, 3, 30, 53, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1537, 11, 3, 30, 53, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1537, 10, 3, 30, 53, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1543, 9, 3, 30, 53, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1535, 8, 3, 27, 53, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1535, 7, 3, 24, 53, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1535, 7, 4, 24, 53, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1537, 9, 4, 27, 53, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1543, 8, 4, 27, 53, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1537, 10, 4, 27, 53, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1537, 11, 4, 27, 53, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1537, 12, 4, 27, 53, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1540, 13, 4, 27, 53, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1538, 14, 4, 24, 53, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1543, 7, 5, 24, 53, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1537, 8, 5, 24, 53, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1537, 9, 5, 24, 53, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1537, 10, 5, 24, 53, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1537, 11, 5, 24, 53, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1537, 12, 5, 24, 53, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1537, 13, 5, 24, 53, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1540, 14, 5, 24, 53, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 497, 13, 5, 0, 53, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 498, 14, 3, 0, 53, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 498, 14, 4, 0, 53, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 496, 14, 5, 0, 53, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 497, 12, 5, 0, 53, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 7888, 7, 2, 6, 0, 2, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 497, 10, 5, 0, 53, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 497, 11, 5, 0, 53, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 497, 9, 5, 0, 53, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 497, 8, 5, 0, 53, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 497, 7, 5, 0, 53, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 503, 6, 2, 0, 53, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 503, 6, 4, 0, 53, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 503, 6, 3, 0, 53, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 500, 6, 5, 0, 53, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 9014, 6, -6, 0, 1195, 29, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 9014, 5, -6, 0, 1195, 29, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 9014, 7, -6, 0, 1195, 29, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 9014, 9, -6, 0, 1195, 29, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 9014, 8, -6, 0, 1195, 29, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 9014, 10, -6, 0, 1195, 29, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 9014, 12, -6, 0, 1195, 29, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 9014, 11, -6, 0, 1195, 29, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 9014, 13, -6, 0, 1195, 29, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 9014, 14, -6, 0, 1195, 29, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1542, 5, -4, 2, 53, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1536, 6, -4, 2, 53, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1536, 9, -2, 24, 53, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1536, 10, -2, 24, 53, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1536, 11, -2, 24, 53, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1536, 12, -2, 24, 53, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1536, 13, -2, 24, 53, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1541, 14, -2, 24, 53, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1535, 7, -1, 24, 53, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1542, 8, -1, 27, 53, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1536, 9, -1, 27, 53, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1536, 10, -1, 27, 53, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1536, 11, -1, 27, 53, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1536, 12, -1, 27, 53, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1541, 13, -1, 27, 53, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1538, 14, -1, 24, 53, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1535, 5, -2, 2, 53, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1535, 8, 0, 27, 53, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1542, 9, 0, 30, 53, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1536, 10, 0, 30, 53, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1536, 11, 0, 30, 53, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1541, 12, 0, 30, 53, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1538, 13, 0, 27, 53, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1538, 14, 0, 24, 53, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1535, 7, 1, 24, 53, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1535, 8, 1, 27, 53, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1535, 9, 1, 30, 53, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1542, 10, 1, 33, 53, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1541, 11, 1, 33, 53, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1538, 12, 1, 30, 53, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1538, 13, 1, 27, 53, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1538, 14, 1, 24, 53, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 739, 14, -3, 0, 53, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 498, 14, -1, 0, 53, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 498, 14, -2, 0, 53, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 502, 13, -3, 0, 53, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 503, 6, -2, 0, 53, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 502, 9, -3, 0, 53, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 502, 12, -3, 0, 53, -1, "", 1);// 164
			AddComplexComponent( (BaseAddon) this, 502, 11, -3, 0, 53, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 502, 10, -3, 0, 53, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 502, 8, -3, 0, 53, -1, "", 1);// 167
			AddComplexComponent( (BaseAddon) this, 502, 7, -3, 0, 53, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 503, 6, 0, 0, 53, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 503, 6, -1, 0, 53, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 503, 6, 1, 0, 53, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 6093, 5, -6, 0, 0, -1, "tiny flowers", 1);// 181
			AddComplexComponent( (BaseAddon) this, 6093, 6, -6, 0, 0, -1, "tiny flowers", 1);// 183
			AddComplexComponent( (BaseAddon) this, 888, -8, 6, 20, 16, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 888, -6, 6, 20, 16, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 888, -7, 6, 20, 16, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 889, 1, 4, 20, 16, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 888, -4, 6, 20, 16, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 888, -5, 6, 20, 16, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 888, -2, 6, 20, 16, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 888, -3, 6, 20, 16, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 888, -1, 6, 20, 16, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 889, 1, 2, 20, 16, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 889, 1, 3, 20, 16, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 1535, -7, 2, 45, 93, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 1540, 0, 5, 45, 93, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 1537, -1, 5, 45, 93, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 1537, -2, 5, 45, 93, -1, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 1537, -3, 5, 45, 93, -1, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 1537, -4, 5, 45, 93, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 1537, -5, 5, 45, 93, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 1537, -6, 5, 45, 93, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 1543, -7, 5, 45, 93, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 500, -10, 3, 0, 93, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 497, -3, 3, 0, 93, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 498, -2, 2, 0, 93, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 496, -2, 3, 0, 93, -1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 497, -4, 3, 0, 93, -1, "", 1);// 241
			AddComplexComponent( (BaseAddon) this, 497, -6, 3, 0, 93, -1, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 497, -5, 3, 0, 93, -1, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 497, -7, 3, 0, 93, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 497, -8, 3, 0, 93, -1, "", 1);// 245
			AddComplexComponent( (BaseAddon) this, 497, -9, 3, 0, 93, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 503, -10, 2, 0, 93, -1, "", 1);// 247
			AddComplexComponent( (BaseAddon) this, 1538, 0, 4, 45, 93, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 1540, -1, 4, 48, 93, -1, "", 1);// 249
			AddComplexComponent( (BaseAddon) this, 1537, -2, 4, 48, 93, -1, "", 1);// 251
			AddComplexComponent( (BaseAddon) this, 1537, -3, 4, 48, 93, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 1537, -4, 4, 48, 93, -1, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 1543, -6, 4, 48, 93, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 1537, -5, 4, 48, 93, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1535, -7, 4, 45, 93, -1, "", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1535, -7, 3, 45, 93, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1535, -6, 3, 48, 93, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1543, -5, 3, 51, 93, -1, "", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1537, -4, 3, 51, 93, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1537, -3, 3, 51, 93, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1540, -2, 3, 51, 93, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1538, -1, 3, 48, 93, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1538, 0, 3, 45, 93, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1538, 0, 2, 45, 93, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1538, -1, 2, 48, 93, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1538, -2, 2, 51, 93, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1543, -4, 2, 54, 93, -1, "", 1);// 270
			AddComplexComponent( (BaseAddon) this, 1540, -3, 2, 54, 93, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1535, -5, 2, 51, 93, -1, "", 1);// 273
			AddComplexComponent( (BaseAddon) this, 1535, -6, 2, 48, 93, -1, "", 1);// 274
			AddComplexComponent( (BaseAddon) this, 9014, -7, -6, 0, 1195, 29, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 9014, -9, -6, 0, 1195, 29, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 9014, -8, -6, 0, 1195, 29, "", 1);// 278
			AddComplexComponent( (BaseAddon) this, 9014, -10, -6, 0, 1195, 29, "", 1);// 279
			AddComplexComponent( (BaseAddon) this, 9014, -2, -6, 1, 1195, 29, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 9014, -4, -6, 0, 1195, 29, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 9014, -3, -6, 0, 1195, 29, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 9014, -5, -6, 0, 1195, 29, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 9014, 3, -6, 0, 1195, 29, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 9014, 4, -6, 0, 1195, 29, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 1542, -9, -4, 23, 93, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 1536, -8, -4, 23, 93, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 1536, -5, -2, 45, 93, -1, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 1536, -4, -2, 45, 93, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 1536, -3, -2, 45, 93, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 1536, -2, -2, 45, 93, -1, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 1536, -1, -2, 45, 93, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 1541, 0, -2, 45, 93, -1, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 1535, -7, -1, 45, 93, -1, "", 1);// 306
			AddComplexComponent( (BaseAddon) this, 1542, -6, -1, 48, 93, -1, "", 1);// 307
			AddComplexComponent( (BaseAddon) this, 1536, -5, -1, 48, 93, -1, "", 1);// 308
			AddComplexComponent( (BaseAddon) this, 1536, -4, -1, 48, 93, -1, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 1536, -3, -1, 48, 93, -1, "", 1);// 310
			AddComplexComponent( (BaseAddon) this, 1536, -2, -1, 48, 93, -1, "", 1);// 311
			AddComplexComponent( (BaseAddon) this, 1541, -1, -1, 48, 93, -1, "", 1);// 312
			AddComplexComponent( (BaseAddon) this, 1542, -5, 0, 51, 93, -1, "", 1);// 313
			AddComplexComponent( (BaseAddon) this, 1536, -4, 0, 51, 93, -1, "", 1);// 320
			AddComplexComponent( (BaseAddon) this, 1536, -3, 0, 51, 93, -1, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 1541, -2, 0, 51, 93, -1, "", 1);// 334
			AddComplexComponent( (BaseAddon) this, 1538, -1, 0, 48, 93, -1, "", 1);// 341
			AddComplexComponent( (BaseAddon) this, 1535, -6, 1, 48, 93, -1, "", 1);// 342
			AddComplexComponent( (BaseAddon) this, 1538, 0, 0, 45, 93, -1, "", 1);// 349
			AddComplexComponent( (BaseAddon) this, 889, 1, -2, 20, 16, -1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 889, 1, -1, 20, 16, -1, "", 1);// 356
			AddComplexComponent( (BaseAddon) this, 889, 1, -3, 20, 16, -1, "", 1);// 357
			AddComplexComponent( (BaseAddon) this, 889, 1, 0, 20, 16, -1, "", 1);// 358
			AddComplexComponent( (BaseAddon) this, 889, 1, 1, 20, 16, -1, "", 1);// 359
			AddComplexComponent( (BaseAddon) this, 9014, -11, -6, 0, 1195, 29, "", 1);// 360
			AddComplexComponent( (BaseAddon) this, 503, -10, 1, 0, 93, -1, "", 1);// 361
			AddComplexComponent( (BaseAddon) this, 739, -2, -5, 0, 93, -1, "", 1);// 362
			AddComplexComponent( (BaseAddon) this, 498, -2, 1, 0, 93, -1, "", 1);// 363
			AddComplexComponent( (BaseAddon) this, 498, -2, -3, 0, 93, -1, "", 1);// 364
			AddComplexComponent( (BaseAddon) this, 498, -2, -4, 0, 93, -1, "", 1);// 365
			AddComplexComponent( (BaseAddon) this, 502, -3, -5, 0, 93, -1, "", 1);// 366
			AddComplexComponent( (BaseAddon) this, 503, -10, -4, 0, 93, -1, "", 1);// 367
			AddComplexComponent( (BaseAddon) this, 502, -7, -5, 0, 93, -1, "", 1);// 368
			AddComplexComponent( (BaseAddon) this, 502, -4, -5, 0, 93, -1, "", 1);// 369
			AddComplexComponent( (BaseAddon) this, 502, -5, -5, 0, 93, -1, "", 1);// 370
			AddComplexComponent( (BaseAddon) this, 502, -6, -5, 0, 93, -1, "", 1);// 371
			AddComplexComponent( (BaseAddon) this, 502, -8, -5, 0, 93, -1, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 502, -9, -5, 0, 93, -1, "", 1);// 373
			AddComplexComponent( (BaseAddon) this, 503, -10, -2, 0, 93, -1, "", 1);// 374
			AddComplexComponent( (BaseAddon) this, 503, -10, -3, 0, 93, -1, "", 1);// 375
			AddComplexComponent( (BaseAddon) this, 503, -10, 0, 0, 93, -1, "", 1);// 376
			AddComplexComponent( (BaseAddon) this, 503, -10, -1, 0, 93, -1, "", 1);// 377
			AddComplexComponent( (BaseAddon) this, 1542, -4, 1, 54, 93, -1, "", 1);// 380
			AddComplexComponent( (BaseAddon) this, 1535, -5, 1, 51, 93, -1, "", 1);// 381
			AddComplexComponent( (BaseAddon) this, 1535, -6, 0, 48, 93, -1, "", 1);// 382
			AddComplexComponent( (BaseAddon) this, 1535, -7, 1, 45, 93, -1, "", 1);// 386
			AddComplexComponent( (BaseAddon) this, 1535, -9, -2, 23, 93, -1, "", 1);// 390
			AddComplexComponent( (BaseAddon) this, 1538, -2, 1, 51, 93, -1, "", 1);// 391
			AddComplexComponent( (BaseAddon) this, 1538, 0, -1, 45, 93, -1, "", 1);// 392
			AddComplexComponent( (BaseAddon) this, 1541, -3, 1, 54, 93, -1, "", 1);// 393
			AddComplexComponent( (BaseAddon) this, 9014, -6, -6, 0, 1195, 29, "", 1);// 394
			AddComplexComponent( (BaseAddon) this, 1538, 0, 1, 45, 93, -1, "", 1);// 395
			AddComplexComponent( (BaseAddon) this, 6093, 3, 1, 0, 0, -1, "tiny flowers", 1);// 396
			AddComplexComponent( (BaseAddon) this, 6093, 4, -5, 0, 0, -1, "tiny flowers", 1);// 397
			AddComplexComponent( (BaseAddon) this, 6093, 3, -4, 0, 0, -1, "tiny flowers", 1);// 398
			AddComplexComponent( (BaseAddon) this, 1538, -1, 1, 48, 93, -1, "", 1);// 399
			AddComplexComponent( (BaseAddon) this, 9014, 2, -6, 0, 1195, 29, "", 1);// 400
			AddComplexComponent( (BaseAddon) this, 9014, -13, -6, 0, 1195, 29, "", 1);// 410
			AddComplexComponent( (BaseAddon) this, 9014, -12, -6, 0, 1195, 29, "", 1);// 413
			AddComplexComponent( (BaseAddon) this, 6093, -12, 0, 0, 0, -1, "tiny flowers", 1);// 414
			AddComplexComponent( (BaseAddon) this, 6093, -12, -1, 0, 0, -1, "tiny flowers", 1);// 415
			AddComplexComponent( (BaseAddon) this, 6093, -12, -3, 0, 0, -1, "tiny flowers", 1);// 416
			AddComplexComponent( (BaseAddon) this, 6093, -12, 1, 0, 0, -1, "tiny flowers", 1);// 417

		}

		public LunaTrainingCenter11_Addon( Serial serial ) : base( serial )
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

	public class LunaTrainingCenter11_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LunaTrainingCenter11_Addon();
			}
		}

		[Constructable]
		public LunaTrainingCenter11_AddonDeed()
		{
			Name = "LunaTrainingCenter11_";
		}

		public LunaTrainingCenter11_AddonDeed( Serial serial ) : base( serial )
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