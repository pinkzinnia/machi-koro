using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
	public class BlueCard:Card
	{
		public BlueCard()
		{
			FaceColor= ConsoleColor.Cyan;
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
			cardOwner.Money += 1;
			Console.WriteLine(cardOwner.Name +" got 1 coin from the bank.");
		}
		
	}
	
	public class B2:BlueCard
	{
		public B2():base()
		{
			Name="Ranch";
			MatchNum = new List<int>();
			MatchNum.Add(2);
			Cost = 1;
			Symbol = SymbolType.cow;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{
			cardOwner.Money +=1;
			Console.WriteLine(cardOwner.Name + "got 1 coin from the bank.");
		}
	}
	
	public class B4:BlueCard
	{ 
		public B4() :base()
	
		{
			Name="Flower Orchard";
			MatchNum = new List<int>();
			MatchNum.Add(4);
			Cost = 2;
			Symbol = SymbolType.wheat;
		}
			public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			cardOwner.Money +=1;
			Console.WriteLine(cardOwner.Name + "got 1 coin from the bank.");
		}
	}	
	
	public class B5:BlueCard
	{
		public B5() :base()
		{
			Name="Forest";
			MatchNum = new List<int>();
			MatchNum.Add(5);
			Cost = 3;
			Symbol = SymbolType.gear;
		}
		public override void PayRule(Player currentOwner, Player cardOwner)
		{
			cardOwner.Money +=1;
			Console.WriteLine(cardOwner + "got one coin from the bank.");
		}
	}
	
	public class B8:BlueCard
	{
		public B8() :base()
		{
			Name="Mackeral Boat";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			Cost = 2;
			Symbol = SymbolType.boat;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{
			cardOwner.Money +=3;
			Console.WriteLine(cardOwner + "got 3 coins from the bank.");
		}
	}
	
	public class B9:BlueCard
	{
		public B9() :base()
		{
			Name="Mine";
			MatchNum = new List<int>();
			MatchNum.Add(9);
			Cost = 6;
			Symbol = SymbolType.gear;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{
			cardOwner.Money +=5;
			Console.WriteLine("Yeah! " + cardOwner + "has a mine and earned 5 coins! Go " + cardOwner + "!!!");
		}	
	}
	
	public class B10:BlueCard
	{
		public B10() :base()
		{
			Name="Apple Orchard";
			MatchNum = new List<int>();
			MatchNum.Add(10);
			Cost = 3;
			Symbol = SymbolType.wheat;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{
			cardOwner.Money +=3;
			Console.WriteLine(cardOwner + "got 3 coins.");
		}
	}
	
	//Wait for Mom to teach...
	public class B12:BlueCard
	{
		public B12() :base()
		{ 
			Name="Tuna Boat";
			MatchNum = new List<int>();
			MatchNum.Add(12);
			MatchNum.Add(13);
			MatchNum.Add(14);
			Cost = 5;
			Symbol = SymbolType.boat;
		}
	}
}