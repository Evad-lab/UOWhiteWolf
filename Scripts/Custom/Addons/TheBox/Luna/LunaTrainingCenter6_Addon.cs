
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
	public class LunaTrainingCenter6_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3348, -5, 13, 0}, {3349, -4, 7, 0}, {3127, -3, 13, 0}// 1	2	3	
			, {3141, -4, 13, 0}, {3144, -5, 14, 0}, {7427, 4, 11, 0}// 4	5	14	
			, {7426, 4, 10, 0}, {7425, 4, 9, 0}, {7424, 4, 8, 0}// 15	16	17	
			, {7423, 4, 7, 0}, {7409, 3, 12, 0}, {7428, 3, 11, 0}// 18	19	20	
			, {7438, 3, 10, 0}, {7437, 3, 9, 0}, {7436, 3, 8, 0}// 21	22	23	
			, {7422, 3, 7, 0}, {7410, 2, 12, 0}, {7429, 2, 11, 0}// 24	25	26	
			, {7439, 2, 10, 0}, {7442, 2, 9, 0}, {7435, 2, 8, 0}// 27	28	29	
			, {7421, 2, 7, 0}, {7411, 1, 12, 0}, {7430, 1, 11, 0}// 30	31	32	
			, {7440, 1, 10, 0}, {7441, 1, 9, 0}, {7434, 1, 8, 0}// 33	34	35	
			, {7420, 1, 7, 0}, {7412, 0, 12, 0}, {7431, 0, 11, 0}// 36	37	38	
			, {7432, 0, 10, 0}, {7433, 0, 9, 0}, {7418, 0, 8, 0}// 39	40	41	
			, {7419, 0, 7, 0}, {7413, -1, 12, 0}, {7414, -1, 11, 0}// 42	43	44	
			, {7415, -1, 10, 0}, {7416, -1, 9, 0}, {7417, -1, 8, 0}// 45	46	47	
			, {3619, 1, 7, 6}, {7565, -1, 11, 6}, {3779, 3, 7, 6}// 76	82	83	
			, {7564, -1, 10, 6}, {3146, -5, 8, 0}, {4650, 3, 7, 6}// 85	88	93	
			, {7816, 2, 7, 6}, {4651, 2, 7, 6}, {8787, -1, 9, 6}// 94	111	147	
			, {3148, 7, 5, 0}, {3144, 7, 4, 0}, {3142, 6, 5, 0}// 151	152	153	
			, {3349, -5, 6, 0}, {3351, 2, 4, 0}, {3344, 6, 0, 0}// 154	160	161	
			, {3212, -4, 5, 0}, {3262, -4, 4, 0}, {3265, -1, 4, 0}// 162	163	164	
			, {3262, 6, 4, 0}, {3211, 7, 3, 0}, {3210, -5, -1, 0}// 165	166	167	
			, {3214, -4, -2, 0}, {3149, 4, 0, 0}, {2794, 3, -2, 0}// 168	241	246	
			, {2794, 2, -2, 0}, {2794, 1, -2, 0}, {2794, 0, -2, 0}// 247	248	249	
			, {2794, -1, -2, 0}, {2793, 4, -3, 0}, {2793, 4, -4, 0}// 250	251	252	
			, {2791, -2, -3, 0}, {2791, -2, -4, 0}, {2789, -2, -2, 0}// 253	254	255	
			, {2787, 4, -2, 0}, {2795, 3, -3, 0}, {2795, 3, -4, 0}// 256	257	258	
			, {2795, 2, -3, 0}, {2795, 2, -4, 0}, {2795, 1, -3, 0}// 259	260	261	
			, {2795, 1, -4, 0}, {2795, 0, -3, 0}, {2795, 0, -4, 0}// 262	263	264	
			, {2795, -1, -3, 0}, {3128, -5, -3, 0}, {3144, -4, -1, 0}// 265	266	269	
			, {3142, -3, 4, 0}, {3145, -4, 6, 0}, {2792, 0, -8, 0}// 270	271	272	
			, {2792, 1, -8, 0}, {2792, 3, -8, 0}, {2792, 2, -8, 0}// 273	274	275	
			, {2792, -1, -8, 0}, {2795, 3, -6, 0}, {2795, 3, -5, 0}// 276	277	278	
			, {2788, -2, -8, 0}, {2795, 2, -6, 0}, {2795, 2, -5, 0}// 279	280	281	
			, {2795, 3, -7, 0}, {2790, 4, -8, 0}, {2795, 0, -7, 0}// 282	283	286	
			, {2793, 4, -7, 0}, {3145, -4, 4, 0}, {2795, -1, -6, 0}// 287	288	289	
			, {6534, -2, -7, 0}, {6558, 2, -8, 0}, {6562, 1, -8, 0}// 290	292	293	
			, {6550, -2, -5, 0}, {2795, 0, -6, 0}, {3141, -5, -4, 0}// 294	295	296	
			, {2795, -1, -4, 0}, {2795, -1, -5, 0}, {2795, -1, -7, 0}// 297	298	299	
			, {6546, -2, -4, 0}, {3147, 4, 1, 0}, {3150, -5, -6, 0}// 300	301	302	
			, {3144, 7, -8, 0}, {3143, 7, 0, 0}, {3127, 7, -1, 0}// 303	304	305	
			, {2795, 1, -6, 0}, {3141, 5, 0, 0}, {2793, 4, -6, 0}// 306	307	308	
			, {2793, 4, -5, 0}, {2791, -2, -7, 0}, {2791, -2, -6, 0}// 309	310	311	
			, {2795, 0, -5, 0}, {2795, 1, -7, 0}, {2791, -2, -5, 0}// 312	313	349	
			, {6522, -1, -8, 0}, {2795, 1, -5, 0}, {3207, 7, -7, 0}// 351	356	358	
			, {2795, 2, -7, 0}, {3350, -5, -12, 0}, {3348, 4, -11, 0}// 359	361	362	
			, {3213, -2, -13, 0}, {3210, 1, -13, 0}, {3142, 3, -12, 0}// 363	364	365	
			, {3150, -4, -12, 0}, {3141, 7, -10, 0}, {3263, 7, -10, 0}// 366	367	368	
			, {10644, -6, 14, 0}, {10644, -6, 2, 0}, {3145, -6, 6, 0}// 369	370	371	
			, {3147, -6, -5, 0}, {10644, -6, -1, 0}, {10644, -6, -8, 0}// 372	373	374	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LunaTrainingCenter6_AddonDeed();
			}
		}

		[ Constructable ]
		public LunaTrainingCenter6_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9010, -5, 14, 0, 1195, 29, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9010, -5, 13, 0, 1195, 29, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9010, -5, 12, 0, 1195, 29, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 9010, -5, 11, 0, 1195, 29, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9010, -5, 10, 0, 1195, 29, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9010, -5, 9, 0, 1195, 29, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 9010, -5, 8, 0, 1195, 29, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9010, -5, 7, 0, 1195, 29, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1305, 4, 10, 0, 1109, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1305, 4, 11, 0, 1109, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1305, 4, 12, 0, 1109, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1305, 4, 13, 0, 1109, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1305, 4, 14, 0, 1109, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1305, 5, 7, 0, 1109, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1305, 5, 8, 0, 1109, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1305, 5, 9, 0, 1109, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1305, 5, 10, 0, 1109, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1305, 5, 11, 0, 1109, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1305, 5, 12, 0, 1109, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1305, 5, 13, 0, 1109, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1305, 5, 14, 0, 1109, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1305, 6, 7, 0, 1109, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1305, 6, 8, 0, 1109, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1305, 6, 9, 0, 1109, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1305, 6, 10, 0, 1109, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1305, 6, 11, 0, 1109, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1305, 6, 12, 0, 1109, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1305, 6, 13, 0, 1109, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1305, 6, 14, 0, 1109, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1305, 3, 11, 0, 1109, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1305, 3, 13, 0, 1109, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1305, 3, 12, 0, 1109, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1305, 1, 10, 0, 1109, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1305, 1, 12, 0, 1109, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 7618, -1, 9, 0, 1106, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1305, 0, 9, 0, 1109, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1305, 0, 7, 0, 1109, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1305, 0, 8, 0, 1109, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1305, -1, 14, 0, 1109, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1305, 3, 9, 0, 1109, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1305, 3, 10, 0, 1109, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1305, 2, 10, 0, 1109, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1305, -1, 13, 0, 1109, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 1305, 2, 8, 0, 1109, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 1305, 2, 9, 0, 1109, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1305, 0, 10, 0, 1109, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 6571, -1, 7, 18, 0, 1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1305, 3, 8, 0, 1109, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 7620, 3, 7, 0, 1106, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1305, -1, 7, 0, 1109, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1305, 1, 13, 0, 1109, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1305, 1, 14, 0, 1109, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 7619, -1, 10, 0, 1106, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1305, 2, 7, 0, 1109, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1305, -1, 8, 0, 1109, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1305, 4, 9, 0, 1109, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1305, 2, 12, 0, 1109, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1305, -1, 11, 0, 1109, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1305, 2, 11, 0, 1109, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1305, -1, 10, 0, 1109, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1305, 1, 11, 0, 1109, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 6570, 5, 7, 0, 0, 29, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1305, 3, 14, 0, 1109, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1305, -1, 9, 0, 1109, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 6571, 5, 7, 18, 0, 1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1305, 0, 11, 0, 1109, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1305, 0, 12, 0, 1109, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1305, 0, 13, 0, 1109, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 503, -2, 7, 0, 1107, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 497, -1, 14, 0, 1107, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 498, 6, 7, 0, 1107, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 503, -2, 8, 0, 1107, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 503, -2, 9, 0, 1107, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 503, -2, 10, 0, 1107, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 503, -2, 11, 0, 1107, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 503, -2, 12, 0, 1107, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 503, -2, 13, 0, 1107, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 500, -2, 14, 0, 1107, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 496, 6, 14, 0, 1107, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 497, 4, 14, 0, 1107, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 497, 0, 14, 0, 1107, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 498, 6, 8, 0, 1107, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 7622, 2, 7, 0, 1106, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 498, 6, 11, 0, 1107, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1305, 0, 14, 0, 1109, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 498, 6, 10, 0, 1107, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 7621, 1, 7, 0, 1106, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 7617, -1, 11, 0, 1106, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 498, 6, 9, 0, 1107, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1305, 2, 13, 0, 1109, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1305, 1, 7, 0, 1109, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1305, 1, 8, 0, 1109, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1305, -1, 12, 0, 1109, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1305, 2, 14, 0, 1109, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1305, 4, 7, 0, 1109, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1305, 4, 8, 0, 1109, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 6570, -1, 7, 0, 0, 29, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1305, 3, 7, 0, 1109, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 497, 5, 14, 0, 1107, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1305, 1, 9, 0, 1109, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 498, 6, 12, 0, 1107, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 498, 6, 13, 0, 1107, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 9010, -5, 6, 0, 1195, 29, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 9010, -5, 5, 0, 1195, 29, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 9010, -5, 3, 0, 1195, 29, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 9010, -5, 4, 0, 1195, 29, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 9010, -5, -2, 0, 1195, 29, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 1542, -2, -8, 23, 49, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1536, -1, -8, 23, 49, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 1536, 2, -6, 45, 49, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1536, 3, -6, 45, 49, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 1536, 4, -6, 45, 49, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1536, 5, -6, 45, 49, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 1536, 6, -6, 45, 49, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1541, 7, -6, 45, 49, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1535, 0, -5, 45, 49, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1542, 1, -5, 48, 49, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1536, 2, -5, 48, 49, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1536, 3, -5, 48, 49, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1536, 4, -5, 48, 49, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 1536, 5, -5, 48, 49, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 1541, 6, -5, 48, 49, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 1538, 7, -5, 45, 49, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1535, -2, -6, 23, 49, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1535, 1, -4, 48, 49, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 1542, 2, -4, 51, 49, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 1536, 3, -4, 51, 49, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 1536, 4, -4, 51, 49, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 1541, 5, -4, 51, 49, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 1538, 6, -4, 48, 49, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 1538, 7, -4, 45, 49, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 1535, 0, -3, 45, 49, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 1535, 1, -3, 48, 49, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 1535, 2, -3, 51, 49, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 1542, 3, -3, 54, 49, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 1541, 4, -3, 54, 49, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 1538, 5, -3, 51, 49, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 1538, 6, -3, 48, 49, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 1538, 7, -3, 45, 49, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 1535, 0, -2, 45, 49, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 1535, 1, -2, 48, 49, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1535, 2, -2, 51, 49, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 1540, 4, -2, 54, 49, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1543, 3, -2, 54, 49, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1538, 5, -2, 51, 49, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1538, 6, -2, 48, 49, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1538, 7, -2, 45, 49, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 1538, 7, -1, 45, 49, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 1538, 6, -1, 48, 49, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1540, 5, -1, 51, 49, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1537, 4, -1, 51, 49, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 1537, 3, -1, 51, 49, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1543, 2, -1, 51, 49, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 1535, 1, -1, 48, 49, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 1535, 0, -1, 45, 49, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 1535, 0, 0, 45, 49, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 1537, 2, 0, 48, 49, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 1543, 1, 0, 48, 49, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1537, 3, 0, 48, 49, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 1537, 4, 0, 48, 49, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 1537, 5, 0, 48, 49, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 1540, 6, 0, 48, 49, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 1538, 7, 0, 45, 49, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 1543, 0, 1, 45, 49, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 1537, 1, 1, 45, 49, -1, "", 1);// 226
			AddComplexComponent( (BaseAddon) this, 1537, 2, 1, 45, 49, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 1537, 3, 1, 45, 49, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 1537, 4, 1, 45, 49, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 1537, 5, 1, 45, 49, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 1537, 6, 1, 45, 49, -1, "", 1);// 231
			AddComplexComponent( (BaseAddon) this, 1540, 7, 1, 45, 49, -1, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 888, 6, 2, 20, 37, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 888, 5, 2, 20, 37, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 888, 4, 2, 20, 37, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 888, 3, 2, 20, 37, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 888, 2, 2, 20, 37, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 888, 1, 2, 20, 37, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 888, 0, 2, 20, 37, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 888, -1, 2, 20, 37, -1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 9010, -5, -3, 0, 1195, 29, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 9010, -5, -4, 0, 1195, 29, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 9010, -5, -5, 0, 1195, 29, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 6585, -1, -5, 0, 0, -1, "Iron Ore", 1);// 245
			AddComplexComponent( (BaseAddon) this, 9010, -5, -1, 0, 1195, 29, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 6526, 0, -8, 0, 0, 29, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 9010, -5, -6, 0, 1195, 29, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 9010, -5, -7, 0, 1195, 29, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 6538, -2, -6, 0, 0, 29, "", 1);// 291
			AddComplexComponent( (BaseAddon) this, 500, -3, -1, 0, 49, -1, "", 1);// 314
			AddComplexComponent( (BaseAddon) this, 503, -3, -3, 0, 49, -1, "", 1);// 315
			AddComplexComponent( (BaseAddon) this, 503, -3, -2, 0, 49, -1, "", 1);// 316
			AddComplexComponent( (BaseAddon) this, 503, -3, -5, 0, 49, -1, "", 1);// 317
			AddComplexComponent( (BaseAddon) this, 503, -3, -4, 0, 49, -1, "", 1);// 318
			AddComplexComponent( (BaseAddon) this, 503, -3, -7, 0, 49, -1, "", 1);// 319
			AddComplexComponent( (BaseAddon) this, 503, -3, -6, 0, 49, -1, "", 1);// 320
			AddComplexComponent( (BaseAddon) this, 502, -2, -9, 0, 49, -1, "", 1);// 321
			AddComplexComponent( (BaseAddon) this, 502, -1, -9, 0, 49, -1, "", 1);// 322
			AddComplexComponent( (BaseAddon) this, 502, 1, -9, 0, 49, -1, "", 1);// 323
			AddComplexComponent( (BaseAddon) this, 502, 2, -9, 0, 49, -1, "", 1);// 324
			AddComplexComponent( (BaseAddon) this, 502, 3, -9, 0, 49, -1, "", 1);// 325
			AddComplexComponent( (BaseAddon) this, 502, 0, -9, 0, 49, -1, "", 1);// 326
			AddComplexComponent( (BaseAddon) this, 497, -2, -1, 0, 49, -1, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 497, -1, -1, 0, 49, -1, "", 1);// 328
			AddComplexComponent( (BaseAddon) this, 497, 3, -1, 0, 49, -1, "", 1);// 329
			AddComplexComponent( (BaseAddon) this, 503, -3, -8, 0, 49, -1, "", 1);// 330
			AddComplexComponent( (BaseAddon) this, 502, 4, -9, 0, 49, -1, "", 1);// 331
			AddComplexComponent( (BaseAddon) this, 496, 5, -1, 0, 49, -1, "", 1);// 332
			AddComplexComponent( (BaseAddon) this, 498, 5, -8, 0, 49, -1, "", 1);// 333
			AddComplexComponent( (BaseAddon) this, 498, 5, -7, 0, 49, -1, "", 1);// 334
			AddComplexComponent( (BaseAddon) this, 498, 5, -2, 0, 49, -1, "", 1);// 335
			AddComplexComponent( (BaseAddon) this, 498, 5, -3, 0, 49, -1, "", 1);// 336
			AddComplexComponent( (BaseAddon) this, 497, 4, -1, 0, 49, -1, "", 1);// 337
			AddComplexComponent( (BaseAddon) this, 739, 5, -9, 0, 49, -1, "", 1);// 338
			AddComplexComponent( (BaseAddon) this, 498, 5, -6, 0, 49, -1, "", 1);// 339
			AddComplexComponent( (BaseAddon) this, 498, 5, -5, 0, 49, -1, "", 1);// 340
			AddComplexComponent( (BaseAddon) this, 498, 5, -4, 0, 49, -1, "", 1);// 341
			AddComplexComponent( (BaseAddon) this, 502, 4, 6, 0, 1107, -1, "", 1);// 342
			AddComplexComponent( (BaseAddon) this, 502, 1, 6, 0, 1107, -1, "", 1);// 343
			AddComplexComponent( (BaseAddon) this, 502, 2, 6, 0, 1107, -1, "", 1);// 344
			AddComplexComponent( (BaseAddon) this, 502, 3, 6, 0, 1107, -1, "", 1);// 345
			AddComplexComponent( (BaseAddon) this, 502, -1, 6, 0, 1107, -1, "", 1);// 346
			AddComplexComponent( (BaseAddon) this, 502, 0, 6, 0, 1107, -1, "", 1);// 347
			AddComplexComponent( (BaseAddon) this, 502, 5, 6, 0, 1107, -1, "", 1);// 348
			AddComplexComponent( (BaseAddon) this, 6585, 0, -4, 0, 0, -1, "Iron Ore", 1);// 350
			AddComplexComponent( (BaseAddon) this, 6585, 2, -4, 0, 0, -1, "Iron Ore", 1);// 352
			AddComplexComponent( (BaseAddon) this, 6586, 1, -6, 0, 0, -1, "Iron Ore", 1);// 353
			AddComplexComponent( (BaseAddon) this, 6583, 2, -6, 0, 0, -1, "Iron Ore", 1);// 354
			AddComplexComponent( (BaseAddon) this, 6585, 2, -7, 0, 0, -1, "Iron Ore", 1);// 355
			AddComplexComponent( (BaseAddon) this, 6585, -1, -7, 0, 0, -1, "Iron Ore", 1);// 357
			AddComplexComponent( (BaseAddon) this, 739, 6, 6, 0, 1107, -1, "", 1);// 360

		}

		public LunaTrainingCenter6_Addon( Serial serial ) : base( serial )
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

	public class LunaTrainingCenter6_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LunaTrainingCenter6_Addon();
			}
		}

		[Constructable]
		public LunaTrainingCenter6_AddonDeed()
		{
			Name = "LunaTrainingCenter6_";
		}

		public LunaTrainingCenter6_AddonDeed( Serial serial ) : base( serial )
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