using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        }
    }
}