using Microsoft.Xna.Framework;
using StardewValley;
using xTile.Layers;
using xTile.Tiles;

namespace iTile.Core.Logic.Action
{
    [ActionAttr(ActionManager.Action.Paste)]
    public class PasteTile : IAction
    {
        public Tile Execute(Vector2 pos, Tile tile = null)
        {
            if (tile == null)
            {
                CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "No tile provided");
                return null;
            }
            Layer layer = Game1.currentLocation.map.GetLayer(CoreManager.SelectedLayer);
            if (layer == null)
            {
                CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Unable to identify layer");
                return null;
            }

            CoreManager.Instance.saveManager.session.GetLocationProfileSafe(Game1.currentLocation).HandleTileReplacement(tile, layer.Id, pos);
            CoreManager.ShowNotification(CoreManager.defaultNotificationTime, "Successfully placed a tile");
            return tile;
        }
    }
}