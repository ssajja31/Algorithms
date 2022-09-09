using System;
using System.Collections.Generic;
// first argumnet is list of intervals in which A[i][0] denotes start time and A[i][1] denotes end time of 'i' interval.
// second argument denotes start time of merge interval and 
// third argument denotes end time of merge interval
// must condition (B<C) 
// You  have to return list of intervals 
class Solution
{
    public List<List<int>> solve(List<List<int>> A, int B, int C)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < A.Count; i++)
        {
            List<int> temp = A[i];
            int x = temp[0];
            int y = temp[1];

            if (y < B)
            {
                result.Add(temp);
            }
            else if (C < x)
            {
                int t = temp[0];
                temp[0] = B;
                B = t;

                t = temp[1];
                temp[1] = C;
                C = t;

                result.Add(temp);
            }
            else
            {
                B = Math.Min(x, B);
                C = Math.Max(y, C);
            }
        }

        List<int> list = new List<int>();
        list.Add(B);
        list.Add(C);

        result.Add(list);

        return result;
    }
}