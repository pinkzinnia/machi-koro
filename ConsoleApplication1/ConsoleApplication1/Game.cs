using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachiKoro
{
   public class Game
    {
        public Game (List<Player> players)
        {
            Players = players;
        }
        public List<Player> Players { get; set; }
        public int CurentPlayerIndex { get; set; }

    }
}
