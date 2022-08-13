class Solution
{
    public int solve(List<int> A, int B)
    {
        Dictionary<int, int> hm = new Dictionary<int, int>();
        long count = 0;

        for (int i = 0; i < A.Count; i++)
        {
            int k = B - A[i];

            if (hm.ContainsKey(k) == true)
            {
                count += (long)hm[k];
                count = count % 1000000007;
            }

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
