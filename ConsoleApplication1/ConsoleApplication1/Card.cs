using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
    public enum SymbolType {cup, bread, gear, wheat, cow, boat, tower, apple, factory }
    public  class  Card
    {
        public string Name { get; set; }
        public List<int> MatchNum { get; set; }
        public ConsoleColor FaceColor { get; set; }
        public int Cost { get; set; }

        public SymbolType Symbol { get; set; }

        public virtual void PayRule(Player currentPlayer, Player cardOwner){Console.WriteLine("no rule created yet.");}
		
		public void Print()
		{
			ConsoleColor currentFontColor = Console.ForegroundColor; 
			Console.ForegroundColor=FaceColor;			// change to the card face color before write the card name to the screen
			Console.Write(Name +" ");
			Console.ForegroundColor=currentFontColor; // change it to the previouse font color
		}
		
    }
	
	
	
	
	


}
