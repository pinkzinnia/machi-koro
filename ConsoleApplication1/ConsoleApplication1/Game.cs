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
				Console.WriteLine("Player" + index);
				if(index == currentPlayerIndex)
					Console.WriteLine(Players[index].Name + " is the current player");
				Players[index].Print();
			}
        }
        public List<Player> Players { get; set; }
        public int CurentPlayerIndex { get; set; }

    }
}
