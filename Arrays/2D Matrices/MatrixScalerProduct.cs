class Solution
{
    public List<List<int>> solve(List<List<int>> A, int B)
    {
        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < A[0].Count; j++)
            {
                A[i][j] *= B;
            }
        }

        return A;
    }
}
