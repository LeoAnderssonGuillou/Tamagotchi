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
}