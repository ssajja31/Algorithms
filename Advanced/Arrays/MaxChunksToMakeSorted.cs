class Solution
{
    public int solve(List<int> A)
    {
        int i = 0;
        int max = -1;
        int chunks = 0;

        while (i < A.Count)
        {
            max = Math.Max(max, A[i]);

            if (max == i)
            {
                chunks++;
            }
            i++;
        }

        return chunks;
    }
}
