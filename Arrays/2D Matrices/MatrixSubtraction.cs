class Solution
{
    public List<List<int>> solve(List<List<int>> A, List<List<int>> B)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < A.Count; i++)
        {
            List<int> temp = new List<int>();

            for (int j = 0; j < A[0].Count; j++)
            {
                temp.Add(A[i][j] - B[i][j]);
            }

            result.Add(temp);
        }

        return result;
    }
}
