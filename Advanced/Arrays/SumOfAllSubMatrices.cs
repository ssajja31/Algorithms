class Solution
{
    public int solve(List<List<int>> A)
    {
        long sum = 0;

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < A[0].Count; j++)
            {
                sum += ((long)A[i][j] * (i + 1) * (j + 1) * (A.Count - i) * (A[0].Count - j));
            }
        }

        return (int)sum;
    }
}
