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
                Console.WriteLine("Say hello[1], Feed[2], Teach word[3], Do noting[4]");

                int input = GetValidInput();
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


        static int GetValidInput()
        {
            int action = 1;
            bool success = false;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out action);
                if (success == false || action < 1 || action > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number 1-4");
                    success = false;
                }
            }
            return action;
        }


    }
}
