using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
	public class GreenCard:Card
	{
		public GreenCard()
		{
			FaceColor= ConsoleColor.Green;
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
			cardOwner.Money += 1;
            Console.WriteLine(cardOwner.Name +" got 1 coin from the bank.");
		}
		
	}
	
	public class G4:GreenCard
	{
		public G4():base()
		{
			Name = "Convenience Store";
			MatchNum = new List<int>();
			MatchNum.Add(4);
	
			Cost = 2;
			Symbol = SymbolType.bread;
			
			
		}
		public override void  PayRule(Player currentPlayer, Player cardOwner)
		{
			cardOwner.Money += 3;
			 Console.WriteLine(cardOwner.Name +" got 3 coins from the bank.");
		}
		
	}
	
	public class G6:GreenCard
	{
		public G6():base()
		{
			Name = "Flower Shop";
			MatchNum = new List<int>();
			MatchNum.Add(6);
			
			Cost = 1;
			Symbol = SymbolType.bread;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			int countOfFlowerOrchard =0;
			
			foreach(Card card in cardOwner.Cards)
			{
				if(card is B4)
					countOfFlowerOrchard +=1;
			
				cardOwner.Money += countOfFlowerOrchard;
			 Console.WriteLine(cardOwner.Name +" got "+countOfFlowerOrchard+" coin(s) from the bank.");
			}
			
			
			
			
		}
	}
	
	public class G7:GreenCard
	{
		public G7():base()
		{
			Name = "Cheese Factory";
			MatchNum = new List<int>();
			MatchNum.Add(7);
			
			Cost = 5;
			Symbol = SymbolType.factory;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			int countOfCows =0;
			
			foreach(Card card in cardOwner.Cards)
			{
				if(card.Symbol == SymbolType.cow)
					countOfCows+=1;
			
				cardOwner.Money += countOfCows;
			 Console.WriteLine(cardOwner.Name +" got "+countOfCows+" coin(s) from the bank.");
			}
			
		}
	
	}
	
	public class G8:GreenCard
	{
		public G8():base()
		{
			Name = "Furniture Factory";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			
			Cost = 3;
			Symbol = SymbolType.factory;
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			int countOfGears =0;
			
			foreach(Card card in cardOwner.Cards)
			{
				if(card.Symbol == SymbolType.gear)
					countOfGears +=3;
			
				cardOwner.Money += countOfGears;
			 Console.WriteLine(cardOwner.Name +" got "+countOfGears+" coins from the bank.");
			}
	}
	}
	
	public class G11:GreenCard
	{
		public G11():base()
		{
			Name = "Fruit And Vegetable Market";
			MatchNum = new List<int>();
			MatchNum.Add(11);
			MatchNum.Add(12);
			Cost = 2;
			Symbol = SymbolType.apple;	
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			int countOfWheat=0;
			
			foreach(Card card in cardOwner.Cards)
			{
				if(card.Symbol == SymbolType.wheat)
					countOfWheat +=2;
			
				cardOwner.Money += countOfWheat;
			 Console.WriteLine(cardOwner.Name +" got "+countOfWheat+" coins from the bank.");
			}
	}
	public class G12:GreenCard
	{
		public G12():base()
		{
			Name = "Food Warehouse";
			MatchNum = new List<int>();
			MatchNum.Add(12);
			MatchNum.Add(13);
			Cost = 2;
			Symbol = SymbolType.factory;	
		}
		public override void PayRule(Player currentPlayer, Player cardOwner)
		{	
			int countOfCups=0;
			
			foreach(Card card in cardOwner.Cards)
			{
				if(card.Symbol == SymbolType.cup)
					countOfCups +=2;
			
				cardOwner.Money += countOfCups;
				 Console.WriteLine(cardOwner.Name +" got "+countOfCups+" coins from the bank.");
			}
		}
	} 
   } 
}
    