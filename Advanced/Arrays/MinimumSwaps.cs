class Solution
{
    public int solve(List<int> A, int B)
    {
        //Sliding window
        int count = 0;
        int maxInAnInterval = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] <= B)
            {
                count++;
            }
        }
        //first interval
        for (int i = 0; i < count; i++)
        {
            if (A[i] <= B)
            {
                maxInAnInterval++;
            }
        }

        int temp = maxInAnInterval;

        for (int i = 1; i + count - 1 < A.Count; i++)
        {
            if (A[i - 1] <= B)
            {
                temp--;
            }
            if (A[i + count - 1] <= B)
            {
                temp++;
            }

            maxInAnInterval = Math.Max(maxInAnInterval, temp);
        }

        return (count - maxInAnInterval);
    }
}
