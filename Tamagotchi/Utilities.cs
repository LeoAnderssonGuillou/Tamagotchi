using System;
using System.Threading;

public class Utilities
{
    public static void WriteNice(string text)
    {
        char[] textArray = text.ToCharArray();
        foreach (char ch in textArray)
        {
            Console.Write(ch);
            Thread.Sleep(15);
        }

        Console.WriteLine();
    }


    public static int GetValidInput()
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