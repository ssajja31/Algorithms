class Solution
{
    public int solve(List<int> A)
    {
        int size = 0;
        List<long> pf = new List<long>();
        Dictionary<long, int> hm = new Dictionary<long, int>();
        bool flag = false;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] == 0)
            {
                flag = true;
            }

            if (i == 0)
            {
                pf.Add(A[i]);
            }
            else
            {
                pf.Add(pf[i - 1] + A[i]);
            }

            if (hm.ContainsKey(pf[i]) == true)
            {
                size = Math.Max(size, i - hm[pf[i]]);
            }
            else
            {
                hm.Add(pf[i], i);
            }
        }

        if (flag)
        {
            size = Math.Max(1, size);
        }
        if (hm.ContainsKey(0) == true)
        {
            size = Math.Max(size, hm[0] + 1);
        }

        return size;
    }
}
