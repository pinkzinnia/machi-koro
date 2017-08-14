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
		public override void PayRule(Player currentPlayer, Player cardOwner, List<Player> players)
		{
			foreach(Player player in players)
			{
				player.Money -=2;
				cardOwner.Money +=2;
				Console.WriteLine(cardOwner.Name + "got 2 coins from" + player.Name);
			}
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
		public override void PayRule(Player currentPlayer, Player cardOwner, List<Player> players)
		{
			Player playerFound = null;
			
			do
			{
			
			
				Console.WriteLine("Who do you want to steal five coins from?");
				string PlayerName = Console.ReadLine();
				
				foreach(Player player in players)
				{
					if(player.Name==PlayerName)
					{
						playerFound = player;
						break;
					}
				}
			}
			while(playerFound== null);
			
			playerFound.Money -=5;
			cardOwner.Money +=5;
			Console.WriteLine(playerFound.Name + "gave" + cardOwner.Name + "5 coins.");
		
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
		public override void PayRule(Player currentPlayer, Player cardOwner, List<Player> players)
		{
			Player traderPlayer = Player.FoundPlayerByName(players, "Who do you want to trade properties with?");
			
			Card traderCard = null;
			do
			{
				traderCard= Card.FoundCardByName(traderPlayer.Cards, "What property would you like to get from" + traderPlayer.Name + "? NO TOWER ESTABLISHMENTS!");
				if(traderCard.Symbol== SymbolType.tower)
				{
					traderCard = null;
				}
			}
			while(traderCard == null);
			
			Card currentPlayerCard = null;
			do
			{
				currentPlayerCard= Card.FoundCardByName(currentPlayer.Cards, "What property would you like to exchange ? NO TOWER ESTABLISHMENTS!");
				if(currentPlayerCard.Symbol == SymbolType.tower)
				{
					currentPlayerCard = null;
				}
			}
			while(currentPlayerCard == null);
			
			traderPlayer.Cards.Add(currentPlayerCard);
			traderPlayer.Cards.Remove(traderCard);
			
			currentPlayer.Cards.Add(traderCard);
			currentPlayer.Cards.Remove(currentPlayerCard);
			Console.Write(currentPlayer.Name + "gave" + traderPlayer.Name + " a " + currentPlayerCard + " in exchange for a " + traderCard);
			
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
		public override void PayRule(Player currentPlayer, Player cardOwner,List<Player> players)
		{
			
			foreach(Player player in players)
			{
				int countOfCupOrBread =0;
			
				foreach(Card card in player.Cards)
				{
					if(card.Symbol == SymbolType.cup || card.Symbol == SymbolType.bread)
					{
						countOfCupOrBread +=1;
					}
				}
				cardOwner.Money += countOfCupOrBread;
				player.Money -=countOfCupOrBread;
			 	Console.WriteLine(cardOwner.Name + " got "+countOfCupOrBread+" coin(s) from " + player.Name);
			}
		
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
		public override void PayRule(Player currentPlayer, Player cardOwner, List<Player> players)
		{
			foreach(Player player in players)
			{
				if(player.Money>=10)
				{
					cardOwner.Money +=Convert.ToInt32(.5 * player.Money);
					player.Money -=Convert.ToInt32(.5 * player.Money);
					Console.WriteLine(cardOwner.Name + "got" + (.5 * player.Money) + "from other players.");
				}
	
			}			
		}
	}
}