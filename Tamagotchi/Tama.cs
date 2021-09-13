using System.Net;
using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tama
    {
        int hunger;
        int boredom;
        List<string> words = new List<string>();
        bool isAlive = true;
        Random generator = new Random();
        public string name;

        public void Setup()
        {
            words.Add("hi");
        }

        public void Feed()
        {
            Console.WriteLine($"You feed {name}");
            hunger -= 2;
        }

        public void Hi()
        {
            Console.WriteLine($"You say hi to {name}");
            Console.WriteLine("It says " + words[generator.Next(0, words.Count)] + " back!");
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 9 || boredom > 9)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            if (hunger < 0)
            {
                hunger = 0;
            }
            if (boredom < 0)
            {
                boredom = 0;
            }
            PrintStat("Hunger: ", hunger);
            PrintStat("Boredom:", boredom);

            if (isAlive == true)
            {
                Console.WriteLine("Tamagotchi is alive");
            }
            else
            {
                Console.WriteLine("Tamagotchi is dead");
            }
        }

        public void PrintStat(string name, int value)
        {
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 10 - value; i++)
            {
                Console.Write("██");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < value; i++)
            {
                Console.Write("██");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public bool GetAlive()
        {
            if (isAlive == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ReduceBoredom()
        {
            boredom -= 2;
        }

    }
}