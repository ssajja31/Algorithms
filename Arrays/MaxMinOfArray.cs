using System;
using System.IO;
using System.Collections.Generic;

class MAIN
{
    public static void Main(string[] args)
    {

        List<int> list = new List<int>();

        string line = Console.ReadLine();
        string[] nums = line.Split(' ');

        int n = Convert.ToInt32(nums[0]);

        for (int i = 0; i < n; i++)
        {
            list.Add(Convert.ToInt32(nums[i + 1]));
        }

        int min = list[0];
        int max = list[0];

        for (int i = 0; i < n; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
            if (list[i] < min)
            {
                min = list[i];
            }
        }

        Console.WriteLine("{0} {1}", max, min);
    }
}