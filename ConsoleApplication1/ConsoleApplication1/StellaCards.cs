using System;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
	public class FlowerShopCard:GreenCard
	{
		public FlowerShopCard():base()
		{
			ID = "G6";
			MatchNum = new List<int>();
			MatchNum.Add(6);
			
			Cost = 1;
			Symbol = SymbolType.bread;
		}
		
	}
	public class CheeseFactoryCard:GreenCard
	{
		public CheeseFactoryCard():base()
		{
			ID = "G7";
			MatchNum = new List<int>();
			MatchNum.Add(7);
			
			Cost = 5;
			Symbol = SymbolType.factory;
		}
	}
	public class FurnitureFactoryCard:GreenCard
	{
		public FurnitureFactoryCard():base()
		{
			ID = "G8";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			
			Cost = 3;
			Symbol = SymbolType.factory;
		}
	}
	public class FruitAndVegetableMarketCard:GreenCard
	{
		public FruitAndVegetableMarketCard():base()
		{
			ID = "G11";
			MatchNum = new List<int>();
			MatchNum.Add(11);
			MatchNum.Add(12);
			Cost = 2;
			Symbol = SymbolType.apple;	
		}
	}
	public class FoodWarehouseCard:GreenCard
	{
		public FoodWarehouseCard():base()
		{
			ID = "G12";
			MatchNum = new List<int>();
			MatchNum.Add(12);
			MatchNum.Add(13);
			Cost = 2;
			Symbol = SymbolType.factory;	
		}
	}
	public class SushiBarCard:RedCard
	{
		public SushiBarCard():base()
		{
			ID = "R1";
			MatchNum = new List<int>();
			MatchNum.Add(1);
			Cost = 4;
			Symbol = SymbolType.cup;	
		}
	}
	public class CafeCard:RedCard
	{
		public CafeCard():base()
		{
			ID = "R3";
			MatchNum = new List<int>();
			MatchNum.Add(3);
			Cost = 2;
			Symbol = SymbolType.cup;	
		}
	}	
	public class PizzaJointCard:RedCard
	{
		public PizzaJointCard():base()
		{
			ID = "R7";
			MatchNum = new List<int>();
			MatchNum.Add(7);
			Cost = 1;
			Symbol = SymbolType.cup;	
		}
	}		
	public class HamburgerStandCard:RedCard
	{
		public HamburgerStandCard():base()
		{
			ID = "R8";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			Cost = 1;
			Symbol = SymbolType.cup;	
		}
	}			
	public class FamilyRestaurantCard:RedCard
	{
		public FamilyRestaurantCard():base()
		{
			ID = "R9";
			MatchNum = new List<int>();
			MatchNum.Add(9);
			MatchNum.Add(10);
			Cost = 3;
			Symbol = SymbolType.cup;	
		}
	}	
}