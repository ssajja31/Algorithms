using System;
using System.IO;

class MAIN
{
    public static void printReverse(string s, int n)
    {
        if (n < 0)
        {
            return;
        }

        Console.Write(s[n]);
        printReverse(s, --n);
    }
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        printReverse(s, s.Length - 1);
    }
}