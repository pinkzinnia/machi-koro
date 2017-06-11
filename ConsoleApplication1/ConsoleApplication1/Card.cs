using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachiKoro
{
    public enum SymbolType {cup, bread, gear, wheat, cow, boat, tower, apple, factory }
    public abstract class  Card
    {
        public string ID { get; set; }
        public int MatchNum { get; set; }
        public Color FaceColor { get; set; }
        public int Cost { get; set; }

        public SymbolType Symbol { get; set; }

        public abstract void PayRule();

    }
}
