class Solution
{
    public int solve(List<List<int>> A, int B)
    {
        int i = 0;
        int j = A[0].Count - 1;
        int res = Int32.MaxValue;

        while (i < A.Count && j >= 0)
        {
            if (A[i][j] == B)
            {
                int temp = ((i + 1) * 1009) + (j + 1);
                res = Math.Min(res, temp);

                j--;
            }
            else if (A[i][j] < B)
            {
                i++;
            }
            else if (A[i][j] > B)
            {
                j--;
            }
        }

        if (res == Int32.MaxValue)
        {
            return -1;
        }
        return res;
    }
}
