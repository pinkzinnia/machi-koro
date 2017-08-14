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
			
			CityHall= true;
			TrainStation = false;
			RadioTower = false;
			AmusementPark = false;
			ShoppingMall = false;
			Airport = false;
			Harbor = false;
			
			Cards = new List<Card>();
			Cards.Add(new B1());
			Cards.Add(new G2());
			Cards.Add(new Y0());
			
		}
        public string Name { get; set; }
        public int LandmarkCount { get; set; }

        public int Money { get; set; } 

        public List<Card> Cards { get; set; }
		public bool CityHall {get; set;}
        public bool TrainStation { get; set; }
		public bool RadioTower {get;set;}
		public bool AmusementPark {get;set;}
		public bool ShoppingMall {get;set;}
		public bool Airport {get; set;}
		public bool Harbor {get;set;}
		
		
		public void Print()
		{
			Console.WriteLine("Player Name: " + Name);
			Console.WriteLine("Landmark Count: " + LandmarkCount);
			Console.WriteLine("Money: " + Money);
			Console.Write("Cards: ");
			foreach(Card card in Cards)
			{
				card.Print();
			}
		
		}
		
		public int CardsCount(string cardID)
		{
			int count = 0;
			foreach(Card card in Cards)
			{
				if(card.GetType().ToString().Replace("MachiKoro.","") == cardID )
				{
					count += 1;
					
				} 
			}
			return count;
		}
		public static Player FoundPlayerByName(List<Player> players, string question)
		{
			Player playerFound = null;
			do
			{
				Console.WriteLine(question);
				string traderName = Console.ReadLine();
				
				foreach(Player player in players)
				{
					if(player.Name==traderName)
					{
						playerFound = player;
						break;
					} 
				}
			}
			while(playerFound == null);
			
			return playerFound;
		}
    }
}
