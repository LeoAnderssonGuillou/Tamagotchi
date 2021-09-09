using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tama
    {
        int hunger;
        int boredom;
        List<string> words = new List<string>();
        bool isAlive;
        Random generator = new Random();
        public string name;

        public void Feed()
        {
            Console.WriteLine($"You feed {name}");
            hunger--;
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
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Boredom: {boredom}");
            if (isAlive == true)
            {
                Console.WriteLine("Tamagotchi is alive");
            }
            else
            {
                Console.WriteLine("Tamagotchi is dead");
            }
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