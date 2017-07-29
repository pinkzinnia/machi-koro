using System;
using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
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
	}
	public class R1:RedCard
	{
		public R1():base()
		{
			Name = "Sushi Bar";
			MatchNum = new List<int>();
			MatchNum.Add(1);
			Cost = 4;
			Symbol = SymbolType.cup;	
		}
	}
	public class R3:RedCard
	{
		public R3():base()
		{
			Name = "Cafe";
			MatchNum = new List<int>();
			MatchNum.Add(3);
			Cost = 2;
			Symbol = SymbolType.cup;	
		}
	}	
	public class R7:RedCard
	{
		public R7():base()
		{
			Name = "Pizza Joint";
			MatchNum = new List<int>();
			MatchNum.Add(7);
			Cost = 1;
			Symbol = SymbolType.cup;	
		}
	}		
	public class R8:RedCard
	{
		public R8():base()
		{
			Name = "Hamburger Stand";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			Cost = 1;
			Symbol = SymbolType.cup;	
		}
	}			
	public class R9:RedCard
	{
		public R9():base()
		{
			Name = "Family Restaurant";
			MatchNum = new List<int>();
			MatchNum.Add(9);
			MatchNum.Add(10);
			Cost = 3;
			Symbol = SymbolType.cup;	
		}
	}	
}