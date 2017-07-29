using System;
using System.Collections.Generic;
using System.Drawing;
namespace MachiKoro
{
    class Program
    {
        static void Main(string[] args)
        {
           
			List<string> playernames=new List<string>(); 
			Console.WriteLine("Who are the players?");
			string input;
			input= Console.ReadLine();
			
			while(!string.IsNullOrEmpty(input))
			{
				playernames.Add(input);
				input=Console.ReadLine();
			}
			/*
			Console.WriteLine("There are " + playernames.Count + " players;");
			foreach(string s in playernames) {
				Console.Write(s + "; ");}
			*/
			Game game = new Game(playernames);
			do{
				
				game.ResetGame();
				game.Play();
				
				Console.WriteLine("Do you want to play another game?");
			}
			while(Console.ReadLine().ToLower() == "yes" );
			
			Console.ReadKey();
			
        }

        static void function1()
        {
            function2();
            Console.WriteLine("Hello");
        }

        static void function2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello");
        }

    }

    class Person
    {
        string Name { get; set; }
        int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayName(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("My name is " + Name);
        }

        public void DisplayAge()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I'm " + Age + " years old");
        }


    }

  
}