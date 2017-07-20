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
        public Color FaceColor { get; set; }
        public int Cost { get; set; }

        public SymbolType Symbol { get; set; }

        public virtual void PayRule(){}
		
		public virtual void Print(){}
		
    }
	
	public class BakeryCard:Card
	{
		public BakeryCard()
		{
			ID = "G2";
			MatchNum = new List<int>();
			MatchNum.Add(2);
			MatchNum.Add(3);
			FaceColor= Color.Green;
			Cost = 1;
			Symbol = SymbolType.bread;
			
			
		}
		public override void  PayRule()
		{}
		public override void Print()
		{
			Console.Write(" Bakery, ");
		}
	}
	public class WheatFieldCard:Card
	{
		public WheatFieldCard()
		{
			ID = "B1";
			MatchNum = new List<int>();
			MatchNum.Add(1);
			FaceColor= Color.Blue;
			Cost = 1;
			Symbol = SymbolType.wheat;
			
			
		}
		public override void  PayRule()
		{}
			public override void Print()
		{
			Console.Write(" Wheat Field, ");
		}
	}

}
