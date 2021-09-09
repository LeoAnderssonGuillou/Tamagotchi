using System.Threading.Tasks;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tama Tamagotchi = new Tama();

            Console.WriteLine("What is the name of your Tamagotchi?");
            Tamagotchi.name = Console.ReadLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Say hello[1], Feed[2], Teach word[3], Do noting[4]");

            int input = GetValidInput();
            switch (input)
            {
                case 1:
                    Tamagotchi.Hi();
                    break;
                case 2:
                    Tamagotchi.Feed();
                    break;
                case 3:
                    Console.WriteLine("Enter the word you want to teach:");
                    Tamagotchi.Teach(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("You do nothing");
                    break;
            }
            Tamagotchi.Tick();
            Tamagotchi.PrintStats();






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
