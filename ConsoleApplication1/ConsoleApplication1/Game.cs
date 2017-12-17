using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
   public class Game
    {
		int currentPlayerIndex {get { return round % PlayerNames.Count; }}
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
				
				//Airport
				if(Players[currentPlayerIndex].Airport)
				{
					Console.WriteLine("Dp you want to build anything? Type 1 if yes, 0 if not.");
					if(Convert.ToBoolean(Console.ReadLine()))
					{
						CurrentPlayerBuyACard();
					}
					else
					{
						Players[currentPlayerIndex].Money += 10;
					}
				}
				else
				{
					CurrentPlayerBuyACard();
				}


                round = round +1;
								
				DisplayPlayer();
				
				Console.WriteLine(); // add a blank line
			}
			while(Players[currentPlayerIndex].LandmarkCount<7);
            Console.WriteLine(Players[currentPlayerIndex] +" is the champion!!!");
		} 
		
		public int RollADice()
		{
			int diceNumber = 0;
			do{
                Console.WriteLine(Players[currentPlayerIndex].Name + ", please roll the dice, and type in the dice number");
			
				if(!Int32.TryParse(Console.ReadLine(),out diceNumber))
                    Console.WriteLine("it's not a number!");	
				
				if((Players[currentPlayerIndex].TrainStation && diceNumber>12)
					||
					(!Players[currentPlayerIndex].TrainStation && diceNumber>6)
					)
				{
                    Console.WriteLine("Cheater! you can't have rolled this number!");	
					diceNumber= 0;
				}
			}
			while(diceNumber ==0);
			
			return diceNumber;
		}
		private void CurrentPlayerRoleADice()
		{
			
			int diceNumber = RollADice();
			
			//RadioTower
			if(Players[currentPlayerIndex].RadioTower)
			{
				Console.WriteLine("Do you want to re-roll? Type 1 if yes, 0 if not.");
				if(Convert.ToBoolean(Console.ReadLine()))
				{
					diceNumber = RollADice();
				}
				
			}
			
			//AmusementPark
			if(Players[currentPlayerIndex].AmusementPark && diceNumber % 2 == 0 )
			{
				Console.WriteLine("Did you roll doubles? Type 1 if yes, 0 if not.");
				if(Convert.ToBoolean(Console.ReadLine()))
				{
					diceNumber = RollADice();
				}
				
			}
			
			if(Players[currentPlayerIndex].Harbor && diceNumber >=10)
			{
				Console.WriteLine("Do you want to add 2 to the dice total? Type 1 if yes, 0 is no.");
				if(Convert.ToBoolean(Console.ReadLine()))
				{
					diceNumber +=2;
				}
			}
			
				//blue
				foreach(Player player in Players)
				{
					foreach(Card card in player.Cards)
					{
						if(card is BlueCard && card.MatchNum.Contains(diceNumber))
						{
                            Console.WriteLine(player.Name + " has a " + card.Name);
							card.PayRule(Players[currentPlayerIndex],player, Players);
							
							
						}
					}
				}
			
				//green
				foreach(Card card in Players[currentPlayerIndex].Cards)
				{
					if(card is GreenCard && card.MatchNum.Contains(diceNumber))
					{
                        Console.WriteLine(Players[currentPlayerIndex].Name + " has a " + card.Name);
						card.PayRule(Players[currentPlayerIndex],Players[currentPlayerIndex], Players);
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
                            Console.WriteLine(player.Name + " has a " + card.Name);
							card.PayRule(Players[currentPlayerIndex],player, Players);
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
						card.PayRule(Players[currentPlayerIndex],Players[currentPlayerIndex], Players);
					}
				}
		}
		
		private void CurrentPlayerBuyACard()
		{
			if(Players[currentPlayerIndex].CityHall && Players[currentPlayerIndex].Money ==0)
			{
				Players[currentPlayerIndex].Money +=1;
			}
			
			Card cardPicked;
			Card cardToBuy = null;
			string cardtype;
			do
			{
				Type CardType;
				do
				{
                    Console.WriteLine(Players[currentPlayerIndex].Name + " please type in the card name that you want to buy:");
					cardtype = Console.ReadLine();
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
                    Console.WriteLine(Players[currentPlayerIndex].Name+ ", You don't have enough money to buy this card.");
				}
			}
			while(cardToBuy ==null);
				
			Players[currentPlayerIndex].Money = Players[currentPlayerIndex].Money - cardToBuy.Cost;
			Players[currentPlayerIndex].Cards.Add(cardToBuy);
			switch(cardtype)
			{
				case "Y2":
					Players[currentPlayerIndex].Harbor = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				case "Y30":
					Players[currentPlayerIndex].Airport = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				case "Y10":
					Players[currentPlayerIndex].ShoppingMall = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				case "Y16":
					Players[currentPlayerIndex].AmusementPark = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				case "Y4":
					Players[currentPlayerIndex].TrainStation = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				case "Y22":
					Players[currentPlayerIndex].RadioTower = true;
					Players[currentPlayerIndex].LandmarkCount++;
					break;
				default:
					break;
			}
				
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
