using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachiKoro
{
    public class Player
    {
        public string Name { get; set; }
        public int LandmarkCount { get; set; }

        public int Money { get; set; } 

        public List<Card> Cards { get; set; }

        public bool CanRole2Dices { get; set; }
    }
}
