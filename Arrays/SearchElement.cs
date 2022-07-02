using System;
using System.IO;
using System.Collections.Generic;

class MAIN
{

    public static bool IsNumberPresent(List<int> a, int b)
    {
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] == b)
            {
                Console.WriteLine("1");
                return true;
            }
        }

        return false;
    }

    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string line = Console.ReadLine();
            List<int> arrayList = new List<int>();

            string[] nums = line.Split(' ');
            int n = Convert.ToInt32(nums[0]);

            for (int j = 0; j < n; j++)
            {
                arrayList.Add(Convert.ToInt32(nums[j + 1]));
            }

            int b = Convert.ToInt32(Console.ReadLine());

            if (!IsNumberPresent(arrayList, b))
            {
                Console.WriteLine("0");
            }
        }
    }
}