using System;
using System.IO;

class MAIN  {
    public static int gcd(int a, int b)
    {
        int l;
        int s;
        if (a > b)
        {
            l = a;
            s = b;
        }
        else
        {
            s = a;
            l = b;
        }

        while (s > 0)
        {
            int temp = l % s;
            l = s;
            s = temp;
        }

        return l;

    }
    public static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < t; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int g = gcd(a, b);

            Console.WriteLine(a * b/g);
        }
    }
}