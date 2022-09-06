class Solution
{
    public long solve(List<List<int>> A)
    {
        List<List<long>> res = new List<List<long>>();
        long result = Int32.MinValue;

        for (int i = 0; i < A.Count; i++)
        {
            List<long> temp = new List<long>();
            for (int j = 0; j < A[0].Count; j++)
            {
                temp.Add((long)A[i][j]);
            }

            res.Add(temp);
        }

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 1; j < A[0].Count; j++)
            {
                res[i][j] += res[i][j - 1];
            }
        }

        for (int i = 0; i < A[0].Count; i++)
        {
            for (int j = 1; j < A.Count; j++)
            {
                res[j][i] += res[j - 1][i];
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < A[0].Count; j++)
            {
                long temp = res[A.Count - 1][A[0].Count - 1];

                if (j > 0)
                {
                    temp -= res[A.Count - 1][j - 1];
                }
                if (i > 0)
                {
                    temp -= res[i - 1][A[0].Count - 1];
                }
                if (i > 0 && j > 0)
                {
                    temp += res[i - 1][j - 1];
                }

                result = Math.Max(result, temp);
            }
        }

        return result;
    }
}
