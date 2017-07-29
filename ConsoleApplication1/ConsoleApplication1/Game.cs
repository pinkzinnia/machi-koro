using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
   public class Game
    {
		int currentPlayerIndex {get { return round % 3; }}
		int round;
		List<string> PlayerNames; 
        public Game (List<string> playerNames)
        {
			PlayerNames = playerNames;
		
        }
		
		public void Play()
		{
			
			do 
			{
				Console.WriteLine(); // add a blank line
				
				CurrentPlayerRoleADice();
				
				CurrentPlayerBuyACard();
				
				round = round +1;
								
				DisplayPlayer();
				
				Console.WriteLine(); // add a blank line
			}
			while(Players[currentPlayerIndex].LandmarkCount<7);
			Console.WriteLine(Players[currentPlayerIndex] +" won!");
		}
		
		private void CurrentPlayerRoleADice()
		{
			int diceNumber = 0;
			do{
				Console.WriteLine(Players[currentPlayerIndex].Name + ", please roll the dice, and type in the dice number");
			
				if(!Int32.TryParse(Console.ReadLine(),out diceNumber))
					Console.WriteLine("it's not a number!");	
				
				if((Players[currentPlayerIndex].CanRole2Dices && diceNumber>12)
					||
					(!Players[currentPlayerIndex].CanRole2Dices && diceNumber>6)
					)
				{
					Console.WriteLine("Cheater, you can't have rolled this number!");	
					diceNumber= 0;
				}
			}
			while(diceNumber ==0);
				//blue
				foreach(Player player in Players)
				{
					foreach(Card card in player.Cards)
					{
						if(card is BlueCard && card.MatchNum.Contains(diceNumber))
						{
							Console.WriteLine(player.Name + " has a " + card.GetType().ToString());
							card.PayRule(Players[currentPlayerIndex],player);
						}
					}
				}
			
				//green
				foreach(Card card in Players[currentPlayerIndex].Cards)
				{
					if(card is GreenCard && card.MatchNum.Contains(diceNumber))
					{
						Console.WriteLine(Players[currentPlayerIndex].Name + " has a " + card.GetType().ToString());
						card.PayRule(Players[currentPlayerIndex],Players[currentPlayerIndex]);
					}
				}
			
				//red
				foreach(var player in Players)
				{
					if(player != Players[currentPlayerIndex])
					{
					foreach(Card card in player.Cards)
					{
						if(card is RedCard && card.MatchNum.Contains(diceNumber))
						{
							Console.WriteLine(player.Name + " has a " + card.GetType().ToString());
							card.PayRule(Players[currentPlayerIndex],player);
						}
					}
					}
				}
				
				//purple
				foreach(Card card in Players[currentPlayerIndex].Cards)
				{
					if(card is PurpleCard && card.MatchNum.Contains(diceNumber))
					{
						Console.WriteLine(Players[currentPlayerIndex].Name + " has a " + card.GetType().ToString());
						card.PayRule(Players[currentPlayerIndex],Players[currentPlayerIndex]);
					}
				}
		}
		
		private void CurrentPlayerBuyACard()
		{
			Card cardPicked;
			Card cardToBuy = null;
			
			do
			{
				Type CardType;
				do
				{
					Console.WriteLine(Players[currentPlayerIndex].Name + " please type in the card name that you want to buy:");
					string cardtype = Console.ReadLine();
					CardType = Type.GetType("MachiKoro."+ cardtype);
					
					if(CardType ==null)
						Console.WriteLine(cardtype + " is not a valid card.");
				}
				while (CardType ==null);
				
				var firstConstructor = CardType.GetConstructors()[0];
					
				cardPicked = (Card)(Activator.CreateInstance(CardType));
				if(Players[currentPlayerIndex].Money >= cardPicked.Cost)
				{
					cardToBuy = cardPicked;
					
				}
				else
				{
					Console.WriteLine("You don't have enough money to buy this card");
				}
			}
			while(cardToBuy ==null);
				
			Players[currentPlayerIndex].Money = Players[currentPlayerIndex].Money - cardToBuy.Cost;
			Players[currentPlayerIndex].Cards.Add(cardToBuy);
				
		}
		public void ResetGame()
		{
			
			round = 0;
			Players = new List<Player>();
			Player onePlayer;
			foreach(string playerName in PlayerNames)
			{
				onePlayer = new Player(playerName);
				Players.Add(onePlayer);
			}
			
			Console.WriteLine("Let the game start!");
			
			DisplayPlayer();
		}
		private void DisplayPlayer()
		{
			for(int index = 0; index<Players.Count; index ++)
			{
				Console.WriteLine("");
				Console.WriteLine("");
				
				if(index == currentPlayerIndex) // highlight the current player's profile
				{
					Console.BackgroundColor = ConsoleColor.White; 
					Console.ForegroundColor = ConsoleColor.Black; 
				}
						
				Players[index].Print();
				
				Console.BackgroundColor= ConsoleColor.Black; // change back to the default background color for other players
				Console.ForegroundColor = ConsoleColor.White; // change back to the default foreground color for other players
			}
		}
        public List<Player> Players { get; set; }
        public int CurentPlayerIndex { get; set; }
		
		private void DisplayPlayersProfile()
		{
		}

    }
}
