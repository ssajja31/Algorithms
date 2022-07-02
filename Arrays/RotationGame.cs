using System;
using System.IO;
using System.Collections.Generic;

class MAIN
{

    public static List<int> ReverseList(List<int> list, int i, int j)
    {
        while (i <= j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;

            ++i;
            --j;
        }

        return list;
    }

    public static List<int> RotateList(List<int> list, int k)
    {
        k = k % list.Count;

        list = ReverseList(list, 0, list.Count - 1);
        list = ReverseList(list, 0, k - 1);
        list = ReverseList(list, k, list.Count - 1);

        return list;
    }

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

        int b = Convert.ToInt32(Console.ReadLine());

        list = RotateList(list, b);

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", list[i]);
        }
    }
}