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
	public class GreenCard:Card
	{
		public GreenCard()
		{
			FaceColor= ConsoleColor.Green;
		}
	}
	public class BlueCard:Card
	{
		public BlueCard()
		{
			FaceColor= ConsoleColor.Cyan;
		}
	}
	public class RedCard:Card
	{
		public RedCard()
		{
			FaceColor= ConsoleColor.Red;
		}
	}
	public class PurpleCard:Card
	{
		public PurpleCard()
		{
			FaceColor= ConsoleColor.Magenta;
		}
	}
	public class G2:GreenCard
	{
		public G2():base()
		{
			Name = "Bakery";
			MatchNum = new List<int>();
			MatchNum.Add(2);
			MatchNum.Add(3);
			
			Cost = 1;
			Symbol = SymbolType.bread;
			
			
		}
		public override void  PayRule(Player currentPlayer, Player cardOwner)
		{
			Console.WriteLine("BakeryCard PayRule is missing");
		}
		
	}
	public class B1:BlueCard
	{
		public B1():base()
		{
			Name = "Wheat Field";
			MatchNum = new List<int>();
			MatchNum.Add(1);
			
			Cost = 1;
			Symbol = SymbolType.wheat;
			
			
		}
		public override void  PayRule(Player currentPlayer, Player cardOwner)
		{
			Console.WriteLine("WheatFieldCard PayRule is missing");
		}
		
	}

}
