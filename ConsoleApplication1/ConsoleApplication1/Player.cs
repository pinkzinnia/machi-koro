using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
    public class Player
    {
		public Player(string name)
		{
			Name = name;
			LandmarkCount = 1;
			Money = 3;
			CanRole2Dices = false;
			Cards = new List<Card>();
			Cards.Add(new B1());
			Cards.Add(new G2());
			Cards.Add(new Y0());
			
		}
        public string Name { get; set; }
        public int LandmarkCount { get; set; }

        public int Money { get; set; } 

        public List<Card> Cards { get; set; }

        public bool CanRole2Dices { get; set; }
		
		public void Print()
		{
			Console.WriteLine("Player Name: " + Name);
			Console.WriteLine("Landmark Count: " + LandmarkCount);
			Console.WriteLine("Money: " + Money);
			Console.WriteLine("Can Role 2 Dices: " + CanRole2Dices);
			Console.Write("Cards: ");
			foreach(Card card in Cards)
			{
				card.Print();
			}
		
		}
    }
}
