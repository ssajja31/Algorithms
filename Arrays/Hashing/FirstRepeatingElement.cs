class Solution
{
    public int solve(List<int> A)
    {
        Dictionary<int, int> hm = new Dictionary<int, int>();
        int min = -1;

        for (int i = A.Count - 1; i >= 0; i--)
        {
            if (hm.ContainsKey(A[i]) == true)
            {
                min = i;
                hm[A[i]]++;
            }
            else
            {
                hm.Add(A[i], 1);
            }
        }

        if (min == -1)
        {
            return -1;
        }

        return A[min];
    }
}
