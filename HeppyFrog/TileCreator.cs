using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeppyFrog
{
    internal class TileCreator : IPoolObjectCreator<Tile>
    {
        Tile IPoolObjectCreator<Tile>.Create()
        { 
            Tile tile = new Tile(' ');
            tile.SetBool(true);
            return tile;
        }
    }
}
