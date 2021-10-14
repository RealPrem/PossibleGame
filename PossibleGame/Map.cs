using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleGame
{
    public class Map
    {
        public Tile[,] Tiles = new Tile[10,10];
        public Map()
        {

        }
        public void InitializeMap()
        {
            int XCords = 0;
            int YCords = 0;
            for (int X = 0; X < 10; X += 1)
            {
                XCords = 0;
                for (int Y = 0; Y < 10; Y += 1)
                {
                    Tiles[X, Y] = new Tile();
                    Tiles[X, Y].X = XCords;
                    Tiles[X, Y].Y = YCords;
                    XCords += 10;
                }
                YCords += 10;
            }
            Tiles[0, 0].ContainsPlayer = true;
            Console.WriteLine();
        }
        public Tile GetCurrentPlayerTile()
        {
            Tile PlayerTile = new Tile();
            for(int X = 0; X < 10; X += 1)
            {
                for (int Y = 0; Y < 10; Y += 1)
                {
                    if (Tiles[X,Y].ContainsPlayer == true)
                    {
                        PlayerTile = Tiles[X, Y];
                    }
                }
            }
            return PlayerTile;
        }
    }
}
