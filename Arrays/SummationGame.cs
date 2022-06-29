using System;
using System.IO;

class MAIN
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = n * (n + 1) / 2;

        Console.WriteLine(sum);
    }
}