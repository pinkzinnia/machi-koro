using System;
using System.Collections.Generic;
using System.Drawing;

namespace MachiKoro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> playernames = new List<string>();
                Console.WriteLine("Who are the players?");
                //Console.WriteLine("Who are the players?");
                string input;
                input = Console.ReadLine();

                while (!string.IsNullOrEmpty(input))
                {
                    playernames.Add(input);
                    input = Console.ReadLine();
                }

                Game game = new Game(playernames);
                do
                {

                    game.ResetGame();
                    game.Play();

                    Console.WriteLine("Do you want to play another game?");
                }
                while (Console.ReadLine().ToLower() == "yes");

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            { Console.ReadKey(); }
        }

    }
/*
    static class Singleton
    {
        static SpeechSynthesizer _reader;
        public static SpeechSynthesizer reader
        {
            get
            {
                if (_reader == null)
                    _reader = new SpeechSynthesizer();
                return _reader;
            }

            }


    }
*/

  
}