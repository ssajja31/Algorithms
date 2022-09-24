using System;
using System.Collections.Generic;
using System.Globalization;
class Solution {
    public List<int> solve(int A) {
        List<int> result = new List<int>();

        if (A == 1)
        {
            return new List<int> {0, 1};
        }

        List<int> temp = solve(A-1);

        for(int i = 0; i < temp.Count; i++)
        {
            result.Add(temp[i]);
        }

        for(int i = temp.Count - 1; i >=0; i--)
        {
            result.Add(temp[i] + (1 << (A-1)));
        }

        return result;
    }
}
