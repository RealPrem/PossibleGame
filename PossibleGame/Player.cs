using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleGame
{
    public class Player
    {
        public List<Path> Paths = new List<Path>();
        public Map Map = new Map();
        public Player()
        {
            Map.InitializeMap();
        }
        public void InitializeMoves()
        {
            for (int i = 0; i < 15; i += 1)
            {

            }
        }
        public void MovePlayer()
        {
            foreach (var Path in Paths)
            {
                foreach (var Move in Path.Moves)
                {
                    Tile CurrentUserPosition = Map.GetCurrentPlayerTile();
                    int CurrentX = CurrentUserPosition.X;
                    int CurrentY = CurrentUserPosition.Y;
                    Map.Tiles[CurrentX, CurrentY].ContainsPlayer = false;
                    if (Move.Name == "U")
                    {
                        Map.Tiles[CurrentX, CurrentY - 1].ContainsPlayer = true;
                    }
                    else if (Move.Name == "D")
                    {
                        Map.Tiles[CurrentX, CurrentY - 1].ContainsPlayer = true;
                    }
                    else if (Move.Name == "L")
                    {
                        Map.Tiles[CurrentX - 1, CurrentY].ContainsPlayer = true;
                    }
                    else
                    {
                        Map.Tiles[CurrentX + 1, CurrentY].ContainsPlayer = true;
                    }
                }
            }
        }
    }
}
