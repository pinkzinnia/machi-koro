using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MachiKoro
{
	public class RanchCard:BlueCard
{
	public RanchCard():base()
	{
		ID="B2";
		MatchNum = new List<int>();
		MatchNum.Add(2);
		Cost = 1;
		Symbol = SymbolType.cow;
	}
}
	public class FlowerOrchardCard:BlueCard
	{ 
		public FlowerOrchardCard() :base()
	
		{
			ID="B4";
			MatchNum = new List<int>();
			MatchNum.Add(4);
			Cost = 2;
			Symbol = SymbolType.wheat;
		}
	}
			public class ForestCard:BlueCard
		{
			public ForestCard() :base()
			{
				ID="B5";
				MatchNum = new List<int>();
				MatchNum.Add(5);
				Cost = 3;
				Symbol = SymbolType.gear;
			}
		}
			public class MackeralBoatCard:BlueCard
			{
				public MackeralBoatCard() :base()
				{
					ID="B8";
					MatchNum = new List<int>();
					MatchNum.Add(8);
					Cost = 2;
					Symbol = SymbolType.boat;
				}
			}
				public class MineCard:BlueCard
				{
					public MineCard() :base()
					{
						ID="B9";
						MatchNum = new List<int>();
						MatchNum.Add(9);
						Cost = 6;
						Symbol = SymbolType.gear;
					}
				}
					public class AppleOrchardCard:BlueCard
				{
					public AppleOrchardCard() :base()
					{
						ID="B10";
						MatchNum = new List<int>();
						MatchNum.Add(10);
						Cost = 3;
						Symbol = SymbolType.wheat;
					}
				}
					public class TunaBoatCard:BlueCard
				{
					public TunaBoatCard() :base()
					{ 
						ID="B12";
						MatchNum = new List<int>();
						MatchNum.Add(12);
						MatchNum.Add(13);
						MatchNum.Add(14);
						Cost = 5;
						Symbol = SymbolType.boat;
					}
				}
				public class StadiumCard:PurpleCard
				{
					public StadiumCard() :base()
					{
						ID="P66";
						MatchNum = new List<int>();
						MatchNum.Add(6);
						Cost = 6;
						Symbol = SymbolType.tower;
					}
				}
				public class TVStationCard:PurpleCard
				{
					public TVStationCard() :base()
					{
						ID="P67";
						MatchNum = new List<int>();
						MatchNum.Add(6);
						Cost = 7;
						Symbol = SymbolType.tower;
					}
				}
				public class BusinessCenterCard:PurpleCard
				{ 
					public BusinessCenterCard() :base()
					{
						ID="P68";
						MatchNum = new List<int>();
						MatchNum.Add(6);
						Cost = 8;
						Symbol = SymbolType.tower;
					}
				}
				public class PublisherCard:PurpleCard
				{
					public PublisherCard() :base()
					{
						ID="P7";
						MatchNum = new List<int>();
						MatchNum.Add(7);
						Cost = 5;
						Symbol = SymbolType.tower;
					}
				}
				public class TaxOfficeCard:PurpleCard
				{
					public TaxOfficeCard() :base()
					{
						ID="P8";
						MatchNum = new List<int>();
						MatchNum.Add(8);
						MatchNum.Add(9);
						Cost = 4;
						Symbol = SymbolType.tower;
					}
				}
	
						
	
}