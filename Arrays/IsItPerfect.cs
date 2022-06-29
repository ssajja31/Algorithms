using System;
using System.IO;
using System.Collections.Generic;

class MAIN  {
    public static int SumOfPositiveDivisors(int n)
    {
        int sum = 1;

        for(int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i + n/i;
            }

            if (i * i == n)
            {
                sum -= i;
            }
        }

        return sum;
    }

    public static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> arrayList = new List<int>();

        for(int i = 0; i < n; i++)
        {
            arrayList.Add(Convert.ToInt32(Console.ReadLine()));
        }

        for(int i = 0; i < n; i++)
        {
            if (arrayList[i] == SumOfPositiveDivisors(arrayList[i]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}