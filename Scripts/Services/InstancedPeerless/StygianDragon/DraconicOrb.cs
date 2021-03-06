//
//  X-RunUO - Ultima Online Server Emulator
//  Copyright (C) 2015 Pedro Pardal
//
//  This library is free software; you can redistribute it and/or
//  modify it under the terms of the GNU Lesser General Public
//  License as published by the Free Software Foundation; either
//  version 3.0 of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this program.
//

using System;
using Server;

namespace Server.Items
{
    public class DraconicOrb : PeerlessKey
    {
        public override int LabelNumber { get { return 1113515; } } // Draconic Orb (Lesser)

        [Constructable]
        public DraconicOrb()
            : base(0x573E)
        {
            Weight = 1.0;
            LootType = LootType.Blessed;
            Hue = 0x80F;
        }

        public override int Lifespan { get { return 43200; } }

        public DraconicOrb(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            /*int version = */
            reader.ReadInt();
        }
    }
}