class Solution
{
    public int solve(List<int> A, List<int> B)
    {
        int sum = Int32.MaxValue;
        for (int i = 1; i < A.Count - 1; i++)
        {
            int minleftSum = Int32.MaxValue;
            int minRightSum = Int32.MaxValue;
            for (int j = 0; j < i; j++)
            {
                if (A[j] < A[i])
                {
                    minleftSum = Math.Min(minleftSum, B[j]);
                }
            }

            for (int k = i + 1; k < A.Count; k++)
            {
                if (A[k] > A[i])
                {
                    minRightSum = Math.Min(minRightSum, B[k]);
                }
            }

            if (minleftSum != Int32.MaxValue && minRightSum != Int32.MaxValue)
            {
                sum = Math.Min(sum, B[i] + minleftSum + minRightSum);
            }
        }

        if (sum == Int32.MaxValue)
        {
            return -1;
        }
        return sum;
    }
}
