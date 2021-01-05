﻿using Microsoft.Xna.Framework;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTile.Tiles;
using xTile;
using xTile.Layers;
using iTile.Core.Logic.SaveSystem;

namespace iTile.Core.Logic.Action
{
    [ActionAttr(ActionManager.Action.Restore)]
    public class RestoreTile : IAction
    {
        public Tile Execute(Vector2 pos, Tile tile = null)
        {
            Layer layer = Game1.currentLocation.map.GetLayer(CoreManager.SelectedLayer);
            if (layer == null)
            {
                CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Unable to identify layer");
                return null;
            }

            CoreManager.Instance.saveManager.session.GetLocationProfileSafe(Game1.currentLocation).RestoreTile(pos, layer.Id);
            CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Tile has been restored");

            return null;
        }
    }
}