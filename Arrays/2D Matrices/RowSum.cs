class Solution
{
    public List<int> solve(List<List<int>> A)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < A.Count; i++)
        {
            int sum = 0;
            for (int j = 0; j < A[0].Count; j++)
            {
                sum += A[i][j];
            }

            result.Add(sum);
        }

        return result;
    }
}
