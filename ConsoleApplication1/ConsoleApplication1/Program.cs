using System;

namespace MachiKoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players?");
            int numberOfPlayer = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("did you say " + numberOfPlayer + " players?");
            Console.WriteLine("What's the name of the first player?");
            Console.ReadKey();
        }

        static void function1()
        {
            Console.ForegroundColor = ConsoleColor.White;
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