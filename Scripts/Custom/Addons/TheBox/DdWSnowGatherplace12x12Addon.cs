
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DdWSnowGatherplace12x12Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6090, -5, -3, 0}, {6085, -5, -4, 0}, {6077, -4, -3, 0}// 3	6	7	
			, {6077, -4, -1, 0}, {6077, -4, 0, 0}, {6090, -5, -2, 0}// 8	9	11	
			, {6090, -5, -1, 0}, {6091, -4, -4, 0}, {6077, -4, -2, 0}// 17	19	20	
			, {14156, -4, -3, 7}, {6077, -4, 2, 0}, {6090, -5, 2, 0}// 21	22	23	
			, {6080, -4, 1, 0}, {6090, -5, 1, 0}, {9007, -4, -3, 27}// 25	26	27	
			, {9079, -4, -3, 0}, {6090, -5, 0, 0}, {14156, -4, 4, 7}// 31	36	37	
			, {6090, -5, 3, 0}, {6089, -4, 5, 0}, {9079, -4, 4, 0}// 38	40	41	
			, {9006, -4, 5, 27}, {6090, -5, 4, 0}, {6077, -4, 3, 0}// 43	44	45	
			, {6077, -4, 4, 0}, {6088, -5, 5, 0}, {6092, 4, -3, 0}// 51	52	53	
			, {6078, 3, 0, 0}, {6079, 3, -3, 0}, {6077, 0, -1, 0}// 55	57	58	
			, {6077, -1, -3, 0}, {6079, 0, -2, 0}, {6077, 1, -3, 0}// 59	60	61	
			, {5940, 1, 2, 0}, {6077, -1, 1, 0}, {6077, 0, 1, 0}// 62	63	64	
			, {6077, 2, 0, 0}, {6091, -1, -4, 0}, {6092, 4, -1, 0}// 66	68	69	
			, {6091, 0, -4, 0}, {5939, 0, 2, 0}, {6077, -2, 2, 0}// 70	71	72	
			, {6077, -2, 0, 0}, {6092, 4, 0, 0}, {5951, -1, -1, 0}// 74	75	76	
			, {6077, -1, 0, 0}, {5938, -1, 2, 0}, {6092, 4, 1, 0}// 77	78	81	
			, {6077, 0, 0, 0}, {5948, -2, 1, 0}, {5946, 0, 1, 0}// 82	83	84	
			, {5949, -2, 0, 0}, {6078, -3, -2, 0}, {6080, 2, -2, 0}// 85	87	88	
			, {6077, -3, 1, 0}, {6077, -3, -1, 0}, {6091, 2, -4, 0}// 89	90	91	
			, {6092, 4, -2, 0}, {6077, -3, 0, 0}, {6077, -3, 2, 0}// 94	95	96	
			, {6077, 3, -2, 0}, {6092, 4, 2, 0}, {6086, 4, -4, 0}// 98	103	104	
			, {6077, -1, -1, 0}, {6078, 2, 2, 0}, {6077, 0, -3, 0}// 107	110	112	
			, {6077, 1, -1, 0}, {6077, -2, -3, 0}, {5941, 1, 1, 0}// 113	116	117	
			, {6077, 2, -3, 0}, {14154, -1, 0, 2}, {6091, 1, -4, 0}// 118	119	121	
			, {6077, 3, 1, 0}, {6077, -3, -3, 0}, {6091, -3, -4, 0}// 122	123	124	
			, {5950, -1, 0, 0}, {14156, 3, -3, 7}, {5944, 0, -1, 0}// 125	126	127	
			, {5942, 1, 0, 0}, {6077, 3, -2, 0}, {6077, 1, 0, 0}// 128	129	131	
			, {6091, -2, -4, 0}, {6077, 0, 2, 0}, {5937, -2, 2, 0}// 132	133	134	
			, {5943, 1, -1, 0}, {6077, 1, -2, 0}, {6077, 2, 1, 0}// 135	138	139	
			, {5953, -2, -1, 0}, {5947, -1, 1, 0}, {5945, 0, 0, 0}// 141	142	144	
			, {6077, 2, -1, 0}, {6077, -1, -2, 0}, {6077, -2, 1, 0}// 146	148	149	
			, {6077, -1, 2, 0}, {9006, 5, -3, 27}, {9079, 3, -3, 0}// 150	151	152	
			, {6077, -2, -1, 0}, {6077, 1, 2, 0}, {6091, 3, -4, 0}// 161	162	164	
			, {6077, 3, -1, 0}, {6077, 1, 1, 0}, {6077, -2, -2, 0}// 165	166	167	
			, {6077, 3, 2, 0}, {9007, 5, 5, 27}, {6077, 1, 3, 0}// 168	170	171	
			, {6092, 4, 4, 0}, {14156, 3, 4, 6}, {6092, 4, 3, 0}// 172	179	180	
			, {6077, 3, 3, 0}, {9079, 3, 4, 0}, {6089, -3, 5, 0}// 181	182	183	
			, {6077, 2, 3, 0}, {6089, 3, 5, 0}, {6077, -3, 3, 0}// 184	188	191	
			, {6077, 3, 4, 0}, {6089, 1, 5, 0}, {6089, -1, 5, 0}// 192	193	196	
			, {6079, -3, 4, 0}, {6089, 2, 5, 0}, {6077, -2, 4, 0}// 201	205	206	
			, {6087, 4, 5, 0}, {6077, -1, 4, 0}, {6077, 2, 4, 0}// 207	209	211	
			, {6078, 0, 3, 0}, {6077, -1, 3, 0}, {6089, -2, 5, 0}// 214	215	218	
			, {6089, 0, 5, 0}, {6077, -2, 3, 0}, {6077, 0, 4, 0}// 219	220	221	
			, {6077, 1, 4, 0}// 222	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DdWSnowGatherplace12x12AddonDeed();
			}
		}

		[ Constructable ]
		public DdWSnowGatherplace12x12Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 937, -5, -1, 21, 1367, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 937, -5, -3, 21, 1367, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9003, -4, -2, 0, 1172, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2915, -4, -1, 0, 1367, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2916, -4, 1, 0, 1367, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2916, -4, 0, 0, 1367, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2581, -5, 2, 15, 310, 0, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2581, -5, -2, 15, 70, 0, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2581, -5, 1, 15, 45, 0, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2591, -5, -4, 0, 37, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2581, -5, -1, 15, 40, 0, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 937, -5, 2, 21, 1367, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 937, -5, 1, 21, 1367, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2581, -5, 0, 15, 90, 0, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 937, -5, -2, 21, 1367, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2592, -5, -4, 0, 37, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 937, -5, 0, 21, 1367, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2914, -4, 2, 0, 1367, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 934, -4, -4, 20, 1367, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 937, -5, 3, 21, 1367, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 934, -4, 4, 20, 1367, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2591, -5, 4, 0, 37, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2592, -5, 4, 0, 37, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 9002, -4, 3, 0, 527, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2581, -5, 3, 15, 54, 0, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 937, -5, 4, 21, 1367, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2594, 1, -4, 15, 90, 0, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 9003, 2, -3, 0, 1169, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2594, -1, -4, 15, 40, 0, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 937, 4, -1, 21, 1367, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2594, 0, -4, 14, 310, 0, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2594, -2, -4, 15, 70, 0, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 937, 4, 2, 21, 1367, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 937, 4, -3, 21, 1367, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 934, 1, -4, 20, 1367, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 2920, 1, -3, 0, 1367, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 2921, -2, -3, 0, 1367, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 2922, -1, -3, 0, 1367, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 934, 3, -4, 20, 1367, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 934, 0, -4, 20, 1367, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 2914, 3, 2, 0, 1367, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2581, 4, 0, 15, 390, 0, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 934, -3, -4, 20, 1367, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 2592, 4, -4, 0, 37, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 2922, 0, -3, 0, 1367, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 934, -1, -4, 20, 1367, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 2591, 4, -4, 0, 37, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 937, 4, -2, 21, 1367, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 2916, 3, 0, 0, 1367, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 934, -2, -4, 20, 1367, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 2581, 4, -2, 15, 310, 0, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 2594, -3, -4, 14, 354, 0, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 2581, 4, 1, 15, 70, 0, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 9003, -3, -2, 1, 2123, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 2581, 4, -1, 15, 340, 0, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 2916, 3, 1, 0, 1367, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 937, 4, 1, 21, 1367, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 2915, 3, -1, 0, 1367, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 2581, 4, 2, 15, 54, 0, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 937, 4, 0, 21, 1367, -1, "", 1);// 156
			AddComplexComponent( (BaseAddon) this, 2594, 2, -4, 15, 45, 0, "", 1);// 157
			AddComplexComponent( (BaseAddon) this, 9002, -3, -3, 0, 299, -1, "", 1);// 158
			AddComplexComponent( (BaseAddon) this, 9003, 2, -2, 0, 1283, -1, "", 1);// 159
			AddComplexComponent( (BaseAddon) this, 934, 2, -4, 20, 1367, -1, "", 1);// 160
			AddComplexComponent( (BaseAddon) this, 9003, 3, -2, 0, 428, -1, "", 1);// 163
			AddComplexComponent( (BaseAddon) this, 934, -3, 4, 20, 1367, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 934, 1, 4, 20, 1367, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 2594, 1, 4, 15, 54, 0, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 2922, -1, 4, 0, 1367, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 2594, -2, 4, 15, 45, 0, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 934, 3, 4, 20, 1367, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 2591, 4, 4, 0, 37, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 2921, -2, 4, 0, 1367, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 934, -1, 4, 20, 1367, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 2594, 2, 4, 15, 40, 0, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 9003, -3, 5, 2, 1287, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 937, 4, 3, 21, 1367, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 9003, 2, 4, 0, 2123, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 2920, 1, 4, 0, 1367, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 2922, 0, 4, 0, 1367, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 9003, 2, 3, 0, 872, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 2594, -1, 4, 15, 310, 0, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 9003, -3, 4, 0, 1108, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 2594, 0, 4, 15, 90, 0, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 937, 4, 4, 21, 1367, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 934, -2, 4, 20, 1367, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 2594, -3, 4, 15, 70, 0, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 934, 2, 4, 20, 1367, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 9003, 3, 3, 0, 1284, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 934, 0, 4, 20, 1367, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 2592, 4, 4, 0, 37, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 2581, 4, 3, 15, 45, 0, "", 1);// 217

		}

		public DdWSnowGatherplace12x12Addon( Serial serial ) : base( serial )
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

	public class DdWSnowGatherplace12x12AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DdWSnowGatherplace12x12Addon();
			}
		}

		[Constructable]
		public DdWSnowGatherplace12x12AddonDeed()
		{
			Name = "DdWSnowGatherplace12x12";
		}

		public DdWSnowGatherplace12x12AddonDeed( Serial serial ) : base( serial )
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