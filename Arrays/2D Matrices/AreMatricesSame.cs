class Solution
{
    public int solve(List<List<int>> A, List<List<int>> B)
    {
        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < A[0].Count; j++)
            {
                if (A[i][j] != B[i][j])
                {
                    return 0;
                }
            }
        }

        return 1;
    }
}
