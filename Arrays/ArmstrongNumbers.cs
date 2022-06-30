using System;
using System.IO;

class MAIN
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int quo = i;
            int rem = 0;
            int sum = 0;

            while (quo > 0)
            {
                rem = quo % 10;
                quo = quo / 10;

                sum += (rem * rem * rem);
            }

            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}