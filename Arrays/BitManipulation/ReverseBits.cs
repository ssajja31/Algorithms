using System.Collections.Generic;
class Solution
{
    public long solve(long A)
    {
        List<long> result = new List<long>();
        long temp = A;
        long res = 0;

        for (int i = 0; i < 32; i++)
        {
            result.Add(temp & 1);
            temp = temp >> 1;
        }

        for (int i = 0; i < 32; i++)
        {
            res = res << 1;
            res = res | result[i];
        }

        return res;
    }
}
