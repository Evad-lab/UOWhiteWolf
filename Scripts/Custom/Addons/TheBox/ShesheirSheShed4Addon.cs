
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
	public class ShesheirSheShed4Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1091, 2, 3, 21}, {4551, 2, 2, 2}, {10510, 3, 1, 26}// 4	6	7	
			, {11516, 3, 4, 1}, {10512, 0, 3, 30}, {10512, 0, 2, 30}// 8	11	12	
			, {10510, 3, 2, 26}, {10510, 3, 3, 26}, {10510, 2, 4, 28}// 13	15	19	
			, {10510, 1, 1, 30}, {10512, -2, 1, 24}, {10511, 4, 4, 24}// 21	23	25	
			, {10510, 3, 4, 26}, {10511, 4, 3, 24}, {10510, 2, 2, 28}// 26	28	29	
			, {10513, -3, 4, 21}, {4551, -3, 2, 2}, {10512, 0, 4, 30}// 32	34	35	
			, {10512, -2, 4, 24}, {11514, 4, 3, 1}, {10510, 1, 3, 30}// 36	37	39	
			, {10512, 0, 1, 30}, {10512, -1, 2, 27}, {10512, -1, 4, 27}// 40	41	43	
			, {10510, 2, 1, 28}, {11516, -3, 4, 1}, {10512, -1, 1, 27}// 44	50	54	
			, {10511, 4, 1, 24}, {10511, 4, 2, 24}, {10513, -3, 1, 21}// 55	58	59	
			, {10512, -2, 3, 24}, {10510, 1, 4, 30}, {10513, -3, 2, 21}// 62	73	74	
			, {10512, -1, 3, 27}, {10513, -3, 3, 21}, {10510, 2, 3, 28}// 79	81	84	
			, {10512, -2, 2, 24}, {10510, 1, 2, 30}, {10510, 3, -1, 26}// 86	90	91	
			, {10510, 3, 0, 26}, {10512, -2, -1, 24}, {10510, 1, -2, 30}// 92	95	99	
			, {13422, 0, 0, 1}, {10512, -1, -2, 27}, {10510, 2, -1, 28}// 100	101	102	
			, {10512, -2, -3, 24}, {10510, 2, -3, 28}, {10510, 2, 0, 28}// 103	104	107	
			, {11514, 4, -3, 1}, {10513, -3, -2, 21}, {10512, -2, 0, 24}// 108	110	111	
			, {10510, 2, -2, 28}, {10510, 1, -3, 30}, {10512, 0, 0, 30}// 112	114	115	
			, {10510, 1, -1, 30}, {13573, 0, -1, 2}, {2711, -1, -3, 1}// 116	117	119	
			, {10512, 0, -1, 30}, {10511, 4, -1, 24}, {10511, 4, -3, 24}// 122	123	125	
			, {10512, -2, -2, 24}, {2711, 0, -3, 1}, {2711, 1, -3, 1}// 126	129	133	
			, {10511, 4, -2, 24}, {10510, 3, -2, 26}, {13422, 0, -1, 1}// 136	137	139	
			, {10513, -3, -1, 21}, {13422, -1, 0, 1}, {10512, -1, 0, 27}// 142	143	150	
			, {10510, 3, -3, 26}, {10512, 0, -2, 30}, {10512, -1, -3, 27}// 152	160	167	
			, {10513, -3, -3, 21}, {10511, 4, 0, 24}, {4551, 2, -3, 1}// 168	175	183	
			, {13603, -1, 0, 2}, {10510, 1, 0, 30}, {10513, -3, 0, 21}// 185	186	193	
			, {10512, 0, -3, 30}, {10512, -1, -1, 27}// 196	197	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ShesheirSheShed4AddonDeed();
			}
		}

		[ Constructable ]
		public ShesheirSheShed4Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4179, 2, 2, 10, 1195, -1, "Daisies", 2);// 1
			AddComplexComponent( (BaseAddon) this, 1299, 0, 2, 1, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1299, 3, 3, 1, 996, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4179, 3, 2, 11, 1195, -1, "Daisies", 2);// 5
			AddComplexComponent( (BaseAddon) this, 1299, -3, 2, 1, 996, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 4179, -2, 2, 11, 1195, -1, "Daisies", 2);// 10
			AddComplexComponent( (BaseAddon) this, 15773, -1, 4, 3, 31, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4179, -2, 3, 14, 1195, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1299, -2, 2, 1, 996, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4179, -2, 3, 17, 1195, -1, "Daisies", 2);// 18
			AddComplexComponent( (BaseAddon) this, 1299, 3, 2, 1, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 679, 3, 3, 1, 996, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 15776, -3, 2, 1, 31, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1299, -2, 1, 1, 996, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3332, -3, 2, 5, 0, -1, "Daisies", 1);// 30
			AddComplexComponent( (BaseAddon) this, 4179, -3, 3, 12, 1195, -1, "Daisies", 2);// 31
			AddComplexComponent( (BaseAddon) this, 15772, 0, 4, 3, 31, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1299, -1, 2, 1, 996, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1299, 1, 1, 1, 996, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 3332, 2, 2, 5, 0, -1, "Daisies", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1299, 0, 1, 1, 996, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 4179, 3, 3, 17, 1195, -1, "Daisies", 2);// 47
			AddComplexComponent( (BaseAddon) this, 1299, 2, 1, 1, 1153, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 262, -4, 2, 1, 1153, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 681, -3, 3, 1, 996, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9524, 2, 3, 1, 1153, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1091, 1, 3, 21, 1153, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 6093, -3, 2, 8, 0, -1, "Daisies", 1);// 56
			AddComplexComponent( (BaseAddon) this, 15777, 1, 4, 3, 31, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1091, 0, 3, 21, 1153, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 4179, 3, 3, 14, 1195, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 19595, -3, 1, 1, 31, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1299, -3, 3, 1, 1153, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1299, -2, 3, 1, 1153, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1299, -1, 3, 1, 996, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1299, 1, 2, 1, 1153, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 6093, 2, 2, 8, 0, -1, "Daisies", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1299, 0, 3, 1, 996, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1091, -1, 3, 21, 1153, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1299, 1, 3, 1, 996, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1299, 2, 2, 1, 1153, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1299, -1, 1, 1, 996, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 4179, -3, 2, 10, 1195, -1, "Daisies", 2);// 76
			AddComplexComponent( (BaseAddon) this, 1299, 2, 3, 1, 1153, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1299, -3, 1, 1, 996, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 9524, -2, 3, 1, 1153, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1091, -2, 3, 21, 1153, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 9518, 3, 2, 1, 1153, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 15776, 4, 1, 1, 31, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 4179, 2, 3, 12, 1195, -1, "Daisies", 2);// 87
			AddComplexComponent( (BaseAddon) this, 9515, -4, 1, 1, 1153, 0, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1299, 3, 1, 1, 1153, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1299, 1, -2, 1, 996, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 9515, -4, -1, 1, 1153, 0, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1299, -1, -1, 1, 1153, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1299, -2, -1, 1, 996, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1299, 1, 0, 1, 996, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 3332, 2, -3, 4, 0, -1, "Daisies", 1);// 105
			AddComplexComponent( (BaseAddon) this, 2416, 0, 0, 21, 1152, -1, "bubbling fountain", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2416, 0, 0, 23, 1152, -1, "bubbling fountain", 1);// 109
			AddComplexComponent( (BaseAddon) this, 7034, -3, -2, 7, 996, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 4179, 3, -2, 16, 1195, -1, "Daisies", 2);// 118
			AddComplexComponent( (BaseAddon) this, 1299, 1, -3, 1, 996, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 262, -4, 0, 1, 1153, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1299, 1, -1, 1, 996, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 15773, -2, -3, 0, 31, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1299, -1, -3, 1, 996, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 15773, 2, -3, 1, 31, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 2416, 0, 0, 21, 1152, -1, "bubbling fountain", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1299, -2, -2, 1, 996, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 679, -3, -3, 1, 996, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 2541, 0, 0, 14, 926, -1, "bubbling fountain", 1);// 135
			AddComplexComponent( (BaseAddon) this, 262, -4, -2, 1, 1153, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1299, -1, -2, 1, 996, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1299, 3, -3, 1, 1153, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1299, -2, 0, 1, 996, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 263, -3, -4, 1, 1153, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1299, 3, -2, 1, 996, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 9518, 3, -2, 1, 1153, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 15776, -3, -2, 1, 31, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 19596, -3, -1, 1, 31, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 2416, 0, 0, 21, 1152, -1, "bubbling fountain", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1299, 2, 0, 1, 1153, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 2416, 0, 0, 20, 1152, -1, "bubbling fountain", 1);// 154
			AddComplexComponent( (BaseAddon) this, 1299, -3, -3, 1, 996, -1, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 1299, 2, -1, 1, 996, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 1299, -1, 0, 1, 1153, -1, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 1299, -3, -1, 1, 996, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 9509, 1, -4, 1, 1153, 0, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 4079, -3, -2, 9, 0, -1, "Fifty Shades of Union", 1);// 161
			AddComplexComponent( (BaseAddon) this, 1299, 0, -2, 1, 996, -1, "", 1);// 162
			AddComplexComponent( (BaseAddon) this, 1299, 0, -3, 1, 996, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 16572, -1, -1, 1, 626, -1, "Medusa", 1);// 164
			AddComplexComponent( (BaseAddon) this, 2885, -3, -2, 1, 996, -1, "", 1);// 165
			AddComplexComponent( (BaseAddon) this, 1299, 0, -1, 1, 1153, -1, "", 1);// 166
			AddComplexComponent( (BaseAddon) this, 19539, -2, -3, 1, 0, 0, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 15775, 4, 0, 1, 31, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 1299, -3, 0, 1, 996, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1299, 3, 0, 1, 996, -1, "", 1);// 172
			AddComplexComponent( (BaseAddon) this, 6093, 2, -3, 7, 0, -1, "Daisies", 1);// 173
			AddComplexComponent( (BaseAddon) this, 4179, 2, -3, 9, 1195, -1, "Daisies", 2);// 174
			AddComplexComponent( (BaseAddon) this, 261, -2, -4, 1, 1153, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1299, 0, 0, 1, 1153, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 4179, 2, -2, 11, 1195, -1, "Daisies", 2);// 178
			AddComplexComponent( (BaseAddon) this, 261, 0, -4, 1, 1153, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1299, 3, -1, 1, 996, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 9509, -1, -4, 1, 1153, 0, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 261, 2, -4, 1, 1153, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 680, 3, -3, 1, 996, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 19594, -3, 0, 1, 31, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 1299, 2, -2, 1, 996, -1, "", 1);// 188
			AddComplexComponent( (BaseAddon) this, 6212, 0, 0, 14, 0, -1, "bubbling fountain", 1);// 189
			AddComplexComponent( (BaseAddon) this, 4179, 3, -3, 10, 1195, -1, "Daisies", 2);// 190
			AddComplexComponent( (BaseAddon) this, 1299, 2, -3, 1, 996, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 1299, -3, -2, 1, 996, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 1299, -2, -3, 1, 996, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 4179, 3, -2, 13, 1195, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 15776, 4, -1, 1, 31, -1, "", 1);// 198

		}

		public ShesheirSheShed4Addon( Serial serial ) : base( serial )
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

	public class ShesheirSheShed4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ShesheirSheShed4Addon();
			}
		}

		[Constructable]
		public ShesheirSheShed4AddonDeed()
		{
			Name = "ShesheirSheShed4";
		}

		public ShesheirSheShed4AddonDeed( Serial serial ) : base( serial )
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