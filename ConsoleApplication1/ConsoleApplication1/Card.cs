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
        public string ID { get; set; }
        public List<int> MatchNum { get; set; }
        public ConsoleColor FaceColor { get; set; }
        public int Cost { get; set; }

        public SymbolType Symbol { get; set; }

        public virtual void PayRule(){}
		
		public void Print()
		{
			ConsoleColor currentFontColor = Console.ForegroundColor; 
			Console.ForegroundColor=FaceColor;			// change to the card face color before write the card name to the screen
			Console.Write(this.GetType().ToString().Replace("Card","").Replace("MachiKoro.","") +" ");
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
			FaceColor= ConsoleColor.Blue;
		}
	}
	public class RedCard:Card
	{
		public RedCard()
		{
			FaceColor= ConsoleColor.Red;
		}
	}
	public class YellowCard:Card
	{
		public YellowCard()
		{
			FaceColor= ConsoleColor.Yellow;
		}
	}
	public class BakeryCard:GreenCard
	{
		public BakeryCard():base()
		{
			ID = "G2";
			MatchNum = new List<int>();
			MatchNum.Add(2);
			MatchNum.Add(3);
			
			Cost = 1;
			Symbol = SymbolType.bread;
			
			
		}
		public override void  PayRule()
		{}
		
	}
	public class WheatFieldCard:BlueCard
	{
		public WheatFieldCard():base()
		{
			ID = "B1";
			MatchNum = new List<int>();
			MatchNum.Add(1);
			
			Cost = 1;
			Symbol = SymbolType.wheat;
			
			
		}
		public override void  PayRule()
		{}
		
	}

}
