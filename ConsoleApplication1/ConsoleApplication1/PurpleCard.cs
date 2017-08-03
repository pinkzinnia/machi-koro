using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
	public class PurpleCard:Card
	{
		public PurpleCard()
		{
			FaceColor= ConsoleColor.Magenta;
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