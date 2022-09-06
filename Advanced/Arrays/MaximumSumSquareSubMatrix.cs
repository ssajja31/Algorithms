class Solution
{
    public int solve(List<List<int>> A, int B)
    {
        int result = Int32.MinValue;
        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 1; j < A[0].Count; j++)
            {
                A[i][j] += A[i][j - 1];
            }
        }

        for (int i = 0; i < A[0].Count; i++)
        {
            for (int j = 1; j < A.Count; j++)
            {
                A[j][i] += A[j - 1][i];
            }
        }

        for (int i = 0; i + B - 1 < A.Count; i++)
        {
            for (int j = 0; j + B - 1 < A[0].Count; j++)
            {
                int x = i + B - 1;
                int y = j + B - 1;

                int temp = A[x][y];
                if (i > 0)
                {
                    temp -= A[i - 1][y];
                }
                if (j > 0)
                {
                    temp -= A[x][j - 1];
                }
                if (i > 0 && j > 0)
                {
                    temp += A[i - 1][j - 1];
                }

                result = Math.Max(temp, result);
            }
        }

        return result;
    }
}
