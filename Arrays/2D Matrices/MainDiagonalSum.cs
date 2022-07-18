class Solution
{
    public int solve(List<List<int>> A)
    {
        int sum = 0;

        for (int i = 0; i < A.Count; i++)
        {
            sum += A[i][i];
        }

        return sum;
    }
}
