
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
	public class GingerBreadHouse16_Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {17782, 4, -2, 6}, {17782, 4, 1, 6}, {17778, 1, 4, 12}// 21	22	23	
			, {9006, 1, -3, 48}, {11138, 1, 1, 37}, {11138, 1, 0, 37}// 59	64	65	
			, {11137, 1, 3, 42}, {11137, 1, 2, 42}, {17778, -2, 4, 13}// 94	95	170	
			, {9076, 0, 4, 12}, {99, -2, 2, 5}, {11139, 0, 2, 36}// 189	193	198	
			, {11139, 0, 0, 36}, {11139, -3, 3, 27}, {11139, -3, 1, 27}// 200	221	223	
			, {11139, -3, -3, 27}// 227	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GingerBreadHouse16_AddonDeed();
			}
		}

		[ Constructable ]
		public GingerBreadHouse16_Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6093, 3, -1, 36, 0, -1, "Powered Sugar Snow", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6093, 3, -2, 36, 0, -1, "Powered Sugar Snow", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6093, 2, -2, 36, 0, -1, "Powered Sugar Snow", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6093, 3, 1, 36, 0, -1, "Powered Sugar Snow", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6093, 2, 0, 36, 0, -1, "Powered Sugar Snow", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6093, 4, -2, 36, 0, -1, "Powered Sugar Snow", 1);// 6
			AddComplexComponent( (BaseAddon) this, 6093, 2, -3, 39, 0, -1, "Powered Sugar Snow", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6093, 2, 3, 36, 0, -1, "Powered Sugar Snow", 1);// 8
			AddComplexComponent( (BaseAddon) this, 210, 4, -4, 0, 1153, -1, "Sugar Frosting", 1);// 9
			AddComplexComponent( (BaseAddon) this, 210, 4, -2, 0, 1153, -1, "Sugar Frosting", 1);// 10
			AddComplexComponent( (BaseAddon) this, 210, 4, 0, 0, 1153, -1, "Sugar Frosting", 1);// 11
			AddComplexComponent( (BaseAddon) this, 210, 4, 2, 0, 1153, -1, "Sugar Frosting", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9244, 4, 4, 37, 25, -1, "Gumdrop", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9244, 4, 3, 37, 76, -1, "Gumdrop", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9244, 4, 2, 37, 16, -1, "Gumdrop", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9244, 4, 1, 37, 56, -1, "Gumdrop", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9244, 4, -2, 37, 76, -1, "Gumdrop", 1);// 17
			AddComplexComponent( (BaseAddon) this, 9244, 4, 0, 37, 25, -1, "Gumdrop", 1);// 18
			AddComplexComponent( (BaseAddon) this, 9244, 4, -1, 37, 16, -1, "Gumdrop", 1);// 19
			AddComplexComponent( (BaseAddon) this, 9244, 4, -3, 37, 96, -1, "Gumdrop", 1);// 20
			AddComplexComponent( (BaseAddon) this, 10136, 4, 4, 34, 96, -1, "Sour Drops", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10136, 4, 3, 34, 56, -1, "Sour Drops", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10136, 4, 2, 34, 25, -1, "Sour Drops", 1);// 26
			AddComplexComponent( (BaseAddon) this, 10136, 4, 1, 34, 96, -1, "Sour Drops", 1);// 27
			AddComplexComponent( (BaseAddon) this, 10136, 4, 0, 34, 76, -1, "Sour Drops", 1);// 28
			AddComplexComponent( (BaseAddon) this, 10136, 4, -1, 34, 56, -1, "Sour Drops", 1);// 29
			AddComplexComponent( (BaseAddon) this, 10136, 4, -2, 34, 25, -1, "Sour Drops", 1);// 30
			AddComplexComponent( (BaseAddon) this, 10136, 4, -3, 34, 16, -1, "Sour Drops", 1);// 31
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 0, 25, -1, "Pez Candy", 2);// 32
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 2, 16, -1, "Pez Candy", 2);// 33
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 5, 96, -1, "Pez Candy", 2);// 34
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 8, 56, -1, "Pez Candy", 2);// 35
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 11, 76, -1, "Pez Candy", 2);// 36
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 14, 96, -1, "Pez Candy", 2);// 37
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 17, 16, -1, "Pez Candy", 2);// 38
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 20, 76, -1, "Pez Candy", 2);// 39
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 23, 56, -1, "Pez Candy", 2);// 40
			AddComplexComponent( (BaseAddon) this, 11699, 3, 4, 26, 25, -1, "Pez Candy", 2);// 41
			AddComplexComponent( (BaseAddon) this, 9001, 4, 4, 0, 38, -1, "Marshmellow Snowman", 1);// 42
			AddComplexComponent( (BaseAddon) this, 9010, 4, -4, 4, 0, 29, "Christmas Lights", 1);// 43
			AddComplexComponent( (BaseAddon) this, 9010, 4, -2, 4, 0, 29, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 9010, 4, -3, 4, 0, 29, "Christmas Lights", 1);// 45
			AddComplexComponent( (BaseAddon) this, 9010, 4, -1, 4, 0, 29, "Christmas Lights", 1);// 46
			AddComplexComponent( (BaseAddon) this, 9010, 4, 1, 4, 0, 29, "Christmas Lights", 1);// 47
			AddComplexComponent( (BaseAddon) this, 9010, 4, 0, 4, 0, 29, "Christmas Lights", 1);// 48
			AddComplexComponent( (BaseAddon) this, 9010, 4, 2, 4, 0, 29, "Christmas Lights", 1);// 49
			AddComplexComponent( (BaseAddon) this, 9010, 4, 3, 4, 0, 29, "Christmas Lights", 1);// 50
			AddComplexComponent( (BaseAddon) this, 9006, 1, 5, 48, 0, -1, "Sugar Candy", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9006, 1, 3, 47, 0, -1, "Sugar Candy", 1);// 52
			AddComplexComponent( (BaseAddon) this, 9006, 1, 1, 47, 0, -1, "Sugar Candy", 1);// 53
			AddComplexComponent( (BaseAddon) this, 9006, 1, -1, 47, 0, -1, "Sugar Candy", 1);// 54
			AddComplexComponent( (BaseAddon) this, 9006, 1, 0, 47, 0, -1, "Sugar Candy", 1);// 55
			AddComplexComponent( (BaseAddon) this, 9006, 1, 4, 47, 0, -1, "Sugar Candy", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9006, 1, 2, 47, 0, -1, "Sugar Candy", 1);// 57
			AddComplexComponent( (BaseAddon) this, 9006, 1, -2, 47, 0, -1, "Sugar Candy", 1);// 58
			AddComplexComponent( (BaseAddon) this, 105, 1, 3, 25, 1356, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 11138, 1, 4, 37, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 61
			AddComplexComponent( (BaseAddon) this, 11138, 1, 3, 37, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 62
			AddComplexComponent( (BaseAddon) this, 11138, 1, 2, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 63
			AddComplexComponent( (BaseAddon) this, 11138, 1, -1, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 66
			AddComplexComponent( (BaseAddon) this, 11138, 1, -2, 37, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 67
			AddComplexComponent( (BaseAddon) this, 11138, 1, -3, 37, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 68
			AddComplexComponent( (BaseAddon) this, 11138, 2, 4, 32, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 69
			AddComplexComponent( (BaseAddon) this, 11138, 2, 3, 32, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 70
			AddComplexComponent( (BaseAddon) this, 11138, 2, 2, 32, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 71
			AddComplexComponent( (BaseAddon) this, 11138, 2, 1, 32, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 72
			AddComplexComponent( (BaseAddon) this, 11138, 2, 0, 32, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 73
			AddComplexComponent( (BaseAddon) this, 11138, 2, -1, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 74
			AddComplexComponent( (BaseAddon) this, 11138, 2, -2, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 75
			AddComplexComponent( (BaseAddon) this, 11138, 2, -3, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 76
			AddComplexComponent( (BaseAddon) this, 11138, 3, 4, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 77
			AddComplexComponent( (BaseAddon) this, 11138, 3, 3, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 78
			AddComplexComponent( (BaseAddon) this, 11138, 3, 2, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 79
			AddComplexComponent( (BaseAddon) this, 11138, 3, 1, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 80
			AddComplexComponent( (BaseAddon) this, 11138, 3, 0, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 81
			AddComplexComponent( (BaseAddon) this, 11138, 3, -1, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 82
			AddComplexComponent( (BaseAddon) this, 11138, 3, -2, 31, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 83
			AddComplexComponent( (BaseAddon) this, 11138, 3, -3, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 84
			AddComplexComponent( (BaseAddon) this, 11138, 4, 4, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 85
			AddComplexComponent( (BaseAddon) this, 11138, 4, 3, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 86
			AddComplexComponent( (BaseAddon) this, 11138, 4, 2, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 87
			AddComplexComponent( (BaseAddon) this, 11138, 4, 1, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 88
			AddComplexComponent( (BaseAddon) this, 11138, 4, 0, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 89
			AddComplexComponent( (BaseAddon) this, 11138, 4, -1, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 90
			AddComplexComponent( (BaseAddon) this, 11138, 4, -2, 28, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 91
			AddComplexComponent( (BaseAddon) this, 11138, 4, -3, 29, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 92
			AddComplexComponent( (BaseAddon) this, 11137, 1, 4, 42, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 93
			AddComplexComponent( (BaseAddon) this, 11137, 1, 1, 42, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 96
			AddComplexComponent( (BaseAddon) this, 11137, 1, 0, 42, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 97
			AddComplexComponent( (BaseAddon) this, 11137, 1, -1, 42, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 98
			AddComplexComponent( (BaseAddon) this, 11137, 1, -2, 42, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 99
			AddComplexComponent( (BaseAddon) this, 11137, 1, -3, 43, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 100
			AddComplexComponent( (BaseAddon) this, 99, 3, -4, 0, 1356, -1, "Gingerbread House", 1);// 101
			AddComplexComponent( (BaseAddon) this, 93, 3, 0, 5, 1356, 255, "Gingerbread House", 1);// 102
			AddComplexComponent( (BaseAddon) this, 87, 3, 3, 5, 1356, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 87, 3, 2, 5, 1356, -1, "Gingerbread House", 1);// 104
			AddComplexComponent( (BaseAddon) this, 87, 3, 1, 5, 1356, -1, "Christmas Lights", 1);// 105
			AddComplexComponent( (BaseAddon) this, 87, 3, -1, 5, 1356, -1, "Gingerbread House", 1);// 106
			AddComplexComponent( (BaseAddon) this, 87, 3, -2, 5, 1356, -1, "Gingerbread House", 1);// 107
			AddComplexComponent( (BaseAddon) this, 87, 3, -3, 5, 1356, -1, "Gingerbread House", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1873, 1, 4, 0, 1356, -1, "Gingerbread House", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1878, 2, 4, 0, 1356, -1, "Gingerbread House", 1);// 110
			AddComplexComponent( (BaseAddon) this, 88, 3, 3, 5, 1356, -1, "Gingerbread House", 1);// 111
			AddComplexComponent( (BaseAddon) this, 88, 2, 3, 5, 1356, -1, "Gingerbread House", 1);// 112
			AddComplexComponent( (BaseAddon) this, 88, 1, 3, 5, 1356, -1, "Gingerbread House", 1);// 113
			AddComplexComponent( (BaseAddon) this, 88, 3, -4, 5, 1356, -1, "Gingerbread House", 1);// 114
			AddComplexComponent( (BaseAddon) this, 88, 1, -4, 5, 1356, -1, "Gingerbread House", 1);// 115
			AddComplexComponent( (BaseAddon) this, 88, 2, -4, 5, 1356, -1, "Gingerbread House", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1305, 3, 3, 5, 1356, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1305, 3, 2, 5, 1356, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1305, 3, 1, 5, 1356, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1305, 3, 0, 5, 1356, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1305, 3, -1, 5, 1356, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1305, 3, -2, 5, 1356, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1305, 3, -3, 5, 1356, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1305, 2, 3, 5, 1356, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1305, 2, 2, 5, 1356, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1305, 2, 1, 5, 1356, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1305, 2, 0, 5, 1356, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1305, 2, -1, 5, 1356, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1305, 2, -2, 5, 1356, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1305, 2, -3, 5, 1356, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1305, 1, 3, 5, 1356, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1305, 1, 2, 5, 1356, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1305, 1, 1, 5, 1356, -1, "Gingerbread House", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1305, 1, 0, 5, 1356, -1, "Gingerbread House", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1305, 1, -1, 5, 1356, -1, "Gingerbread House", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1305, 1, -2, 5, 1356, -1, "Gingerbread House", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1305, 1, -3, 5, 1356, -1, "Gingerbread House", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1872, 3, -3, 0, 1356, -1, "Gingerbread House", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1872, 2, -3, 0, 1356, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1872, 1, -3, 0, 1356, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1872, 2, 3, 0, 1356, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1872, 1, 3, 0, 1356, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1872, 3, 3, 0, 1356, -1, "Gingerbread House", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1872, 3, 2, 0, 1356, -1, "Gingerbread House", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1872, 3, 0, 0, 1356, -1, "Gingerbread House", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1872, 3, -2, 0, 1356, -1, "Gingerbread House", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1872, 3, -1, 0, 1356, -1, "Gingerbread House", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1872, 3, 1, 0, 1356, -1, "Gingerbread House", 1);// 148
			AddComplexComponent( (BaseAddon) this, 2365, -3, -1, 5, 1357, -1, "Gingerbread Fireplace", 1);// 149
			AddComplexComponent( (BaseAddon) this, 2359, -3, 0, 5, 1357, 48, "Gingerbread Fireplace", 1);// 150
			AddComplexComponent( (BaseAddon) this, 2901, 0, -3, 5, 1153, -1, "Sugar Candy Chair", 1);// 151
			AddComplexComponent( (BaseAddon) this, 2898, -2, -3, 5, 1153, -1, "Sugar Candy Chair", 1);// 152
			AddComplexComponent( (BaseAddon) this, 2879, -1, -3, 5, 1153, -1, "Sugar Candy Table", 1);// 153
			AddComplexComponent( (BaseAddon) this, 6093, -1, -1, 36, 0, -1, "Powered Sugar Snow", 1);// 154
			AddComplexComponent( (BaseAddon) this, 6093, -1, -3, 36, 0, -1, "Powered Sugar Snow", 1);// 155
			AddComplexComponent( (BaseAddon) this, 6093, -2, -2, 36, 0, -1, "Powered Sugar Snow", 1);// 156
			AddComplexComponent( (BaseAddon) this, 6093, -1, 0, 36, 0, -1, "Powered Sugar Snow", 1);// 157
			AddComplexComponent( (BaseAddon) this, 6093, -1, 2, 36, 0, -1, "Powered Sugar Snow", 1);// 158
			AddComplexComponent( (BaseAddon) this, 6093, -2, 1, 36, 0, -1, "Powered Sugar Snow", 1);// 159
			AddComplexComponent( (BaseAddon) this, 6093, -1, 3, 36, 0, -1, "Powered Sugar Snow", 1);// 160
			AddComplexComponent( (BaseAddon) this, 6093, -2, 4, 36, 0, -1, "Powered Sugar Snow", 1);// 161
			AddComplexComponent( (BaseAddon) this, 9244, -3, 3, 38, 16, -1, "Gumdrop", 1);// 162
			AddComplexComponent( (BaseAddon) this, 9244, -3, -1, 38, 56, -1, "Gumdrop", 1);// 163
			AddComplexComponent( (BaseAddon) this, 9244, -3, -2, 38, 96, -1, "Gumdrop", 1);// 164
			AddComplexComponent( (BaseAddon) this, 9244, -3, 4, 38, 96, -1, "Gumdrop", 1);// 165
			AddComplexComponent( (BaseAddon) this, 9244, -3, 2, 38, 76, -1, "Gumdrop", 1);// 166
			AddComplexComponent( (BaseAddon) this, 9244, -3, 0, 38, 25, -1, "Gumdrop", 1);// 167
			AddComplexComponent( (BaseAddon) this, 9244, -3, -3, 38, 16, -1, "Gumdrop", 1);// 168
			AddComplexComponent( (BaseAddon) this, 9244, -3, 1, 38, 56, -1, "Gumdrop", 1);// 169
			AddComplexComponent( (BaseAddon) this, 10136, -3, 4, 35, 16, -1, "Sour Drops", 1);// 171
			AddComplexComponent( (BaseAddon) this, 10136, -3, 3, 35, 76, -1, "Sour Drops", 1);// 172
			AddComplexComponent( (BaseAddon) this, 10136, -3, 2, 35, 56, -1, "Sour Drops", 1);// 173
			AddComplexComponent( (BaseAddon) this, 10136, -3, -3, 35, 56, -1, "Sour Drops", 1);// 174
			AddComplexComponent( (BaseAddon) this, 10136, -3, -2, 35, 25, -1, "Sour Drops", 1);// 175
			AddComplexComponent( (BaseAddon) this, 10136, -3, -1, 35, 16, -1, "Sour Drops", 1);// 176
			AddComplexComponent( (BaseAddon) this, 10136, -3, 0, 35, 76, -1, "Sour Drops", 1);// 177
			AddComplexComponent( (BaseAddon) this, 10136, -3, 1, 35, 96, -1, "Sour Drops", 1);// 178
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 0, 25, -1, "Pez Candy", 2);// 179
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 2, 96, -1, "Pez Candy", 2);// 180
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 5, 16, -1, "Pez Candy", 2);// 181
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 26, 56, -1, "Pez Candy", 2);// 182
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 23, 76, -1, "Pez Candy", 2);// 183
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 20, 16, -1, "Pez Candy", 2);// 184
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 17, 56, -1, "Pez Candy", 2);// 185
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 14, 96, -1, "Pez Candy", 2);// 186
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 8, 76, -1, "Pez Candy", 2);// 187
			AddComplexComponent( (BaseAddon) this, 11699, -3, 4, 11, 25, -1, "Pez Candy", 2);// 188
			AddComplexComponent( (BaseAddon) this, 9000, -4, 4, 0, 4, -1, "Marshmellow Snowman", 1);// 190
			AddComplexComponent( (BaseAddon) this, 9004, 0, 4, 9, 38, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 99, 0, 3, 25, 1356, -1, "Gingerbread House", 1);// 192
			AddComplexComponent( (BaseAddon) this, 99, -1, 3, 25, 1356, -1, "Gingerbread House", 1);// 194
			AddComplexComponent( (BaseAddon) this, 105, -2, 3, 25, 1356, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 11139, 0, 4, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 196
			AddComplexComponent( (BaseAddon) this, 11139, 0, 3, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 197
			AddComplexComponent( (BaseAddon) this, 11139, 0, 1, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 199
			AddComplexComponent( (BaseAddon) this, 11139, 0, -1, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 201
			AddComplexComponent( (BaseAddon) this, 11139, 0, -2, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 202
			AddComplexComponent( (BaseAddon) this, 11139, 0, -3, 36, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 203
			AddComplexComponent( (BaseAddon) this, 11139, -1, 4, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 204
			AddComplexComponent( (BaseAddon) this, 11139, -1, 3, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 205
			AddComplexComponent( (BaseAddon) this, 11139, -1, 2, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 206
			AddComplexComponent( (BaseAddon) this, 11139, -1, 1, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 207
			AddComplexComponent( (BaseAddon) this, 11139, -1, 0, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 208
			AddComplexComponent( (BaseAddon) this, 11139, -1, -1, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 209
			AddComplexComponent( (BaseAddon) this, 11139, -1, -2, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 210
			AddComplexComponent( (BaseAddon) this, 11139, -1, -3, 33, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 211
			AddComplexComponent( (BaseAddon) this, 11139, -2, 4, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 212
			AddComplexComponent( (BaseAddon) this, 11139, -2, 3, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 213
			AddComplexComponent( (BaseAddon) this, 11139, -2, 2, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 214
			AddComplexComponent( (BaseAddon) this, 11139, -2, 1, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 215
			AddComplexComponent( (BaseAddon) this, 11139, -2, 0, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 216
			AddComplexComponent( (BaseAddon) this, 11139, -2, -1, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 217
			AddComplexComponent( (BaseAddon) this, 11139, -2, -2, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 218
			AddComplexComponent( (BaseAddon) this, 11139, -2, -3, 30, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 219
			AddComplexComponent( (BaseAddon) this, 11139, -3, 4, 27, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 220
			AddComplexComponent( (BaseAddon) this, 11139, -3, 2, 27, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 222
			AddComplexComponent( (BaseAddon) this, 11139, -3, 0, 27, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 224
			AddComplexComponent( (BaseAddon) this, 11139, -3, -1, 27, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 225
			AddComplexComponent( (BaseAddon) this, 11139, -3, -2, 27, 0, -1, "Gramcracker Crumble Roof Tile", 1);// 226
			AddComplexComponent( (BaseAddon) this, 100, -4, 3, 0, 1356, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 93, -4, 0, 5, 1356, 255, "Gingerbread House", 1);// 229
			AddComplexComponent( (BaseAddon) this, 90, -4, -4, 5, 1356, -1, "Gingerbread House", 1);// 230
			AddComplexComponent( (BaseAddon) this, 87, -4, 2, 5, 1356, -1, "Gingerbread House", 1);// 231
			AddComplexComponent( (BaseAddon) this, 87, -4, 1, 5, 1356, -1, "Gingerbread House", 1);// 232
			AddComplexComponent( (BaseAddon) this, 87, -4, 3, 5, 1356, -1, "Gingerbread House", 1);// 233
			AddComplexComponent( (BaseAddon) this, 87, -4, -1, 5, 1356, -1, "Gingerbread House", 1);// 234
			AddComplexComponent( (BaseAddon) this, 87, -4, -2, 5, 1356, -1, "Gingerbread House", 1);// 235
			AddComplexComponent( (BaseAddon) this, 87, -4, -3, 5, 1356, -1, "Gingerbread House", 1);// 236
			AddComplexComponent( (BaseAddon) this, 1873, -1, 4, 0, 1356, -1, "Gingerbread House", 1);// 237
			AddComplexComponent( (BaseAddon) this, 1880, -2, 4, 0, 1356, -1, "Gingerbread House", 1);// 238
			AddComplexComponent( (BaseAddon) this, 1873, 0, 4, 0, 1356, -1, "Gingerbread House", 1);// 239
			AddComplexComponent( (BaseAddon) this, 88, -1, 3, 5, 1356, -1, "Gingerbread House", 1);// 240
			AddComplexComponent( (BaseAddon) this, 88, -2, 3, 5, 1356, -1, "Gingerbread House", 1);// 241
			AddComplexComponent( (BaseAddon) this, 88, -3, 3, 5, 1356, -1, "Gingerbread House", 1);// 242
			AddComplexComponent( (BaseAddon) this, 88, 0, -4, 5, 1356, -1, "Gingerbread House", 1);// 243
			AddComplexComponent( (BaseAddon) this, 88, -1, -4, 5, 1356, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 88, -2, -4, 5, 1356, -1, "Gingerbread House", 1);// 245
			AddComplexComponent( (BaseAddon) this, 88, -3, -4, 5, 1356, -1, "Gingerbread House", 1);// 246
			AddComplexComponent( (BaseAddon) this, 1305, 0, 3, 5, 1356, -1, "", 1);// 247
			AddComplexComponent( (BaseAddon) this, 1305, 0, 2, 5, 1356, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 1305, 0, 1, 5, 1356, -1, "Gingerbread House", 1);// 249
			AddComplexComponent( (BaseAddon) this, 1305, 0, 0, 5, 1356, -1, "Gingerbread House", 1);// 250
			AddComplexComponent( (BaseAddon) this, 1305, 0, -1, 5, 1356, -1, "Gingerbread House", 1);// 251
			AddComplexComponent( (BaseAddon) this, 1305, 0, -2, 5, 1356, -1, "Gingerbread House", 1);// 252
			AddComplexComponent( (BaseAddon) this, 1305, 0, -3, 5, 1356, -1, "Gingerbread House", 1);// 253
			AddComplexComponent( (BaseAddon) this, 1305, -1, 3, 5, 1356, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 1305, -1, 2, 5, 1356, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 1305, -1, 1, 5, 1356, -1, "Gingerbread House", 1);// 256
			AddComplexComponent( (BaseAddon) this, 1305, -1, 0, 5, 1356, -1, "Gingerbread House", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1305, -1, -1, 5, 1356, -1, "Gingerbread House", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1305, -1, -2, 5, 1356, -1, "Gingerbread House", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1305, -1, -3, 5, 1356, -1, "Gingerbread House", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1305, -2, 3, 5, 1356, -1, "", 1);// 261
			AddComplexComponent( (BaseAddon) this, 1305, -2, 2, 5, 1356, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1305, -2, 1, 5, 16, -1, "Gingerbread House", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1305, -2, 0, 5, 96, -1, "Gingerbread House", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1305, -2, -1, 5, 56, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1305, -2, -2, 5, 76, -1, "Gingerbread House", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1305, -2, -3, 5, 1356, -1, "Gramcracker Crumble Roof Tile", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1305, -3, 3, 5, 1356, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1305, -3, 2, 5, 1356, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1305, -3, 1, 5, 76, -1, "Gingerbread House", 1);// 270
			AddComplexComponent( (BaseAddon) this, 1305, -3, 0, 5, 1356, -1, "Gingerbread House", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1305, -3, -1, 5, 1356, -1, "Gingerbread House", 1);// 272
			AddComplexComponent( (BaseAddon) this, 1305, -3, -2, 5, 25, -1, "Gingerbread House", 1);// 273
			AddComplexComponent( (BaseAddon) this, 1305, -3, -3, 5, 1356, -1, "Gingerbread House", 1);// 274
			AddComplexComponent( (BaseAddon) this, 1872, 0, -3, 0, 1356, -1, "", 1);// 275
			AddComplexComponent( (BaseAddon) this, 1872, -1, -3, 0, 1356, -1, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 1872, -2, -3, 0, 1356, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 1872, -3, -3, 0, 1356, -1, "", 1);// 278
			AddComplexComponent( (BaseAddon) this, 1872, -3, -2, 0, 1356, -1, "", 1);// 279
			AddComplexComponent( (BaseAddon) this, 1872, -3, -1, 0, 1356, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 1872, -3, 0, 0, 1356, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 1872, -3, 1, 0, 1356, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 1872, -3, 2, 0, 1356, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 1872, -3, 3, 0, 1356, -1, "Gingerbread House", 1);// 284
			AddComplexComponent( (BaseAddon) this, 1872, -2, 3, 0, 1356, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 1872, -1, 3, 0, 1356, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 1872, 0, 3, 0, 1356, -1, "", 1);// 287

		}

		public GingerBreadHouse16_Addon( Serial serial ) : base( serial )
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

	public class GingerBreadHouse16_AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GingerBreadHouse16_Addon();
			}
		}

		[Constructable]
		public GingerBreadHouse16_AddonDeed()
		{
			Name = "GingerBreadHouse16_";
		}

		public GingerBreadHouse16_AddonDeed( Serial serial ) : base( serial )
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