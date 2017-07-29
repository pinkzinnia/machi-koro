using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MachiKoro
{
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
	}
	
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
	public class P66:PurpleCard
	{
		public P66() :base()
		{
			Name="Stadium";
			MatchNum = new List<int>();
			MatchNum.Add(6);
			Cost = 6;
			Symbol = SymbolType.tower;
		}
	}
	public class P67:PurpleCard
	{
		public P67() :base()
		{
			Name="TV Station";
			MatchNum = new List<int>();
			MatchNum.Add(6);
			Cost = 7;
			Symbol = SymbolType.tower;
		}
	}
	public class P68:PurpleCard
	{ 
		public P68() :base()
		{
			Name="Business Center";
			MatchNum = new List<int>();
			MatchNum.Add(6);
			Cost = 8;
			Symbol = SymbolType.tower;
		}
	}
	public class P7:PurpleCard
	{
		public P7() :base()
		{
			Name="Publisher";
			MatchNum = new List<int>();
			MatchNum.Add(7);
			Cost = 5;
			Symbol = SymbolType.tower;
		}
	}
	public class P8:PurpleCard
	{
		public P8() :base()
		{
			Name="Tax Office";
			MatchNum = new List<int>();
			MatchNum.Add(8);
			MatchNum.Add(9);
			Cost = 4;
			Symbol = SymbolType.tower;
		}
	}
	
						
	
}