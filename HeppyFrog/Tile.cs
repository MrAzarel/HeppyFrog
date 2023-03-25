using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeppyFrog
{
    internal class Tile : IPoolable
    {
        public static char[] tileTypes = { '#', '_' };

        public char tile;
        public int tileWidth = 15;
        public int tileHeight;

        public Tile(char tile)
        {
            this.tile = tile;
            this.tileHeight = 119;
        }

        public void ResetState()
        {
            var rand = new Random();
            int probability = rand.Next(1, 20);
            int tileType;
            if (probability == 1) 
            { 
                tileType = 1;
            }
            else
            {
                tileType = 0;
            }
            char tileChar = Tile.tileTypes[tileType];
            this.tile = tileChar;
            tileHeight = 119;
        }
    }
}
