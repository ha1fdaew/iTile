﻿using Microsoft.Xna.Framework;
using StardewValley;
using xTile.Layers;
using xTile.Tiles;
using xTile.Dimensions;

namespace iTile.Core.Logic.Action
{
    [ActionAttr(ActionManager.Action.Copy)]
    public class CopyTile : IAction
    {
        public Tile clipboardTile;
        public string locName;

        public Tile Execute(Vector2 pos, Tile tile = null)
        {
            Layer layer = Game1.currentLocation.map.GetLayer(CoreManager.SelectedLayer);
            if (layer == null)
            {
                CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Unable to identify layer");
                return null;
            }

            Tile t = layer.PickTile(new Location((int)pos.X, (int)pos.Y) * Game1.tileSize, Game1.viewport.Size);
            if (t == null)
            {
                CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "There's no tile at this position\non layer " + layer.Id);
                return null;
            }

            clipboardTile = t;
            locName = Game1.currentLocation.NameOrUniqueName;
            CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Successfully copied a tile");
            return clipboardTile;
        }
    }
}