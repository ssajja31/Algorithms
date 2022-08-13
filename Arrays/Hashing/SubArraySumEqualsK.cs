class Solution
{
    public int solve(List<int> A, int B)
    {
        List<int> pf = new List<int>();
        Dictionary<int, int> hm = new Dictionary<int, int>();
        int count = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (i == 0)
            {
                pf.Add(A[i]);
            }
            else
            {
                pf.Add(A[i] + pf[i - 1]);
            }

            if (pf[i] == B)
            {
                count++;
            }

            int k = pf[i] - B;

            if (hm.ContainsKey(k) == true)
            {
                count += hm[k];
            }

            if (hm.ContainsKey(pf[i]) == true)
            {
                hm[pf[i]]++;
            }
            else
            {
                hm.Add(pf[i], 1);
            }
        }

        return count;
    }
}
