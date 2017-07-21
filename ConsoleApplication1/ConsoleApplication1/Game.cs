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
           Players = new List<Player>();
			Player onePlayer;
			foreach(string playerName in playerNames)
			{
				onePlayer = new Player(playerName);
				Players.Add(onePlayer);
			}
			
			Console.WriteLine("Let the game start!");
			
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
