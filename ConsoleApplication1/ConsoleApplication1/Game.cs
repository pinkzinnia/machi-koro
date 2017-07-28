using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
   public class Game
    {
		int currentPlayerIndex ;
        public Game (List<string> playerNames)
        {
			int currentPlayerIndex = 0;
           ResetGame(playerNames);
        }
		
		public void Play()
		{
			
			int diceNumber = Convert.ToInt32(Console.ReadLine());
			foreach(var player in Players)
			{
				foreach(Card card in player.Cards)
				{
					if(card is BlueCard && card.MatchNum.Contains(diceNumber))
					{
						card.PayRule();
					}
				}
			}
			
			//green
			
				foreach(Card card in Players[currentPlayerIndex].Cards)
				{
					if(card is GreenCard && card.MatchNum.Contains(diceNumber))
					{
						card.PayRule();
					}
				}
			
			//red
			foreach(var player in Players)
			{
				if(player != Players[currentPlayerIndex])
				{
				foreach(Card card in player.Cards)
				{
					if(card is BlueCard && card.MatchNum.Contains(diceNumber))
					{
						card.PayRule();
					}
				}
				}
			}
			//purple
				foreach(Card card in Players[currentPlayerIndex].Cards)
				{
					if(card is PurpleCard && card.MatchNum.Contains(diceNumber))
					{
						card.PayRule();
					}
				}
				
				Console.WriteLine("Which card do you want to buy?");
				string cardtype = Console.ReadLine();
				
				
		}
		
		private void ResetGame(List<string> playerNames)
		{
			Players = new List<Player>();
			Player onePlayer;
			foreach(string playerName in playerNames)
			{
				onePlayer = new Player(playerName);
				Players.Add(onePlayer);
			}
			
			Console.WriteLine("Let the game start!");
			
			DisplayPlayer();
		}
		public void DisplayPlayer()
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
