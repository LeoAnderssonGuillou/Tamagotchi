using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tama Tamagotchi = new Tama();

            Utilities.WriteNice("What is the name of your Tamagotchi?");
            Tamagotchi.name = Console.ReadLine();


            while (Tamagotchi.GetAlive())
            {
                Utilities.WriteNice("What do you want to do?");
                Console.WriteLine("Say hello[1]  Feed[2]  Teach word[3]  Do noting[4]");

                int input = Utilities.GetValidInput();
                switch (input)
                {
                    case 1:
                        Tamagotchi.Hi();
                        Console.Clear();
                        break;
                    case 2:
                        Tamagotchi.Feed();
                        Console.Clear();
                        break;
                    case 3:
                        Utilities.WriteNice("Enter the word you want to teach:");
                        Tamagotchi.Teach(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 4:
                        Utilities.WriteNice("You do nothing");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.WriteLine();
                Tamagotchi.Tick();
                Tamagotchi.PrintStats();
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
