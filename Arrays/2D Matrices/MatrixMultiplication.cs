class Solution
{
    public List<List<int>> solve(List<List<int>> A, List<List<int>> B)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < A.Count; i++)
        {
            List<int> temp = new List<int>(new int[B[0].Count]);
            result.Add(temp);
        }

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < B[0].Count; j++)
            {
                for (int k = 0; k < B.Count; k++)
                {
                    result[i][j] += A[i][k] * B[k][j];
                }
            }
        }

        return result;
    }
}
