using System;

namespace BoxTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
			Console.WriteLine("Test starting... \n");
            Game1 game = new Game1();
            game.Run();
        }
    }
}

