using System;
using System.IO;
using System.Collections.Generic;

class MAIN
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            List<int> list = new List<int>();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            int n = Convert.ToInt32(Console.ReadLine());

            string line = Console.ReadLine();
            string[] nums = line.Split(' ');

            for (int j = 0; j < n; j++)
            {
                list.Add(Convert.ToInt32(nums[j]));
            }

            for (int j = 0; j < n; j++)
            {
                if (list[j] % 2 != 0)
                {
                    odd.Add(list[j]);
                }
                else
                {
                    even.Add(list[j]);
                }
            }

            for (int j = 0; j < odd.Count; j++)
            {
                Console.Write("{0} ", odd[j]);
            }

            Console.Write("\n");

            for (int j = 0; j < even.Count; j++)
            {
                Console.Write("{0} ", even[j]);
            }

            Console.Write("\n");
        }

    }
}