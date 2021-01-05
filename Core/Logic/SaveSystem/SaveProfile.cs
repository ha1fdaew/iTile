﻿#pragma warning disable IDE0060 // Remove unused parameter

using Newtonsoft.Json;
using StardewValley;
using System.Collections.Generic;
using System.Linq;

namespace iTile.Core.Logic.SaveSystem
{
    public class SaveProfile
    {
        public List<LocationProfile> locs = new List<LocationProfile>();

        [JsonConstructor]
        public SaveProfile()
        {
        }

        public SaveProfile(bool jsonWorkaround)
        {
        }

        public LocationProfile GetLocationProfileSafe(string name)
        {
            LocationProfile p = locs.FirstOrDefault(loc => string.Equals(name, loc.Name));
            if (p == null)
            {
                p = new LocationProfile(name);
                locs.Add(p);
            }
            return p;
        }

        public LocationProfile GetLocationProfileSafe(GameLocation loc)
        {
            return GetLocationProfileSafe(loc.name);
        }
    }
}