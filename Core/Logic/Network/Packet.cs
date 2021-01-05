﻿using iTile.Core.Logic.SaveSystem;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTile.Core.Logic.Network
{
    public class Packet
    {
        public Vector2 Position { get; set; }

        public string LayerId { get; set; }

        public TileProfile TileProfile { get; set; }

        public string LocationName { get; set; }

        [JsonConstructor]
        public Packet()
        {
        }

        public Packet(TileProfile tileProfile, string locationName) : this(locationName)
        {
            TileProfile = tileProfile;
        }

        public Packet(Vector2 position, string layerId, string locationName) : this(locationName)
        {
            Position = position;
            LayerId = layerId;
        }

        private Packet(string locName)
        {
            LocationName = locName;
        }
    }
}