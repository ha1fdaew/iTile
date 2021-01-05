using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTile.Tiles;

namespace iTile.Core.Logic.Action
{
    public interface IAction
    {
        Tile Execute(Vector2 pos, Tile tile = null);
    }
}