class Solution
{
    public int solve(List<int> A, int B)
    {
        long count = 0;
        Dictionary<int, int> hm = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++)
        {
            int m = A[i] + B;
            int k = A[i] - B;

            if (hm.ContainsKey(m) == true)
            {
                count += (long)hm[m];
            }
            if (hm.ContainsKey(k) == true)
            {
                count += (long)hm[k];
            }

            count = count % 1000000007;

            if (hm.ContainsKey(A[i]) == true)
            {
                hm[A[i]]++;
            }
            else
            {
                hm.Add(A[i], 1);
            }
        }

        return (int)count;
    }
}
