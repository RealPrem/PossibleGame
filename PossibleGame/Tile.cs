using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleGame
{
    public class Tile
    {
        public int X;
        public int Y;
        public bool ContainsPlayer;
        public bool ContainsEnemy;
        public Tile()
        {

        }
        public bool GetContainsPlayer()
        {
            return ContainsPlayer;
        }
        public bool GetContainsEnemy()
        {
            return ContainsEnemy;
        }
    }
}
