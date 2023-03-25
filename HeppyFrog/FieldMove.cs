using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeppyFrog
{
    internal class FieldMove
    {
        public static Tile[] tiles = new Tile[120];

        public static void Movment()
        {
            TileCreator creator = new TileCreator();
            ObjectPool<Tile> objectPool = new ObjectPool<Tile>(creator);
            CreatField(objectPool, tiles);
            while (true)
            {
                Thread.Sleep(50);
                if (tiles[0].tileHeight == 0)
                {
                    objectPool.ReturnObject(ref tiles[0]);
                    for (int i = 1; i < tiles.Length; i++)
                    {
                        tiles[i].tileHeight--;
                        tiles[i - 1] = tiles[i];
                        Console.SetCursorPosition(tiles[i].tileHeight, tiles[i].tileWidth);
                        Console.WriteLine(tiles[i].tile);
                    }
                    tiles[119] = objectPool.GetObject();
                    Console.SetCursorPosition(tiles[119].tileHeight, tiles[119].tileWidth);
                    Console.WriteLine(tiles[119].tile);
                }
            }
        }

        static void CreatField(ObjectPool<Tile> objectPool, Tile[] tiles)
        {
            for (int i = 0; i < 120; i++)
            {
                
                tiles[i] = objectPool.GetObject();
                tiles[i].tileHeight = i;
                if (i == 20)
                {
                    tiles[i].tile = '_';
                }
                tiles[i].tile = '#';
                Console.SetCursorPosition(tiles[i].tileHeight, tiles[i].tileWidth);
                Console.WriteLine(tiles[i].tile);
            }
        }
    }
}
