class Solution
{
    public int solve(List<int> A)
    {
        long leftSum = 0;
        long rightSum = 0;

        for (int i = 0; i < A.Count; i++)
        {
            rightSum += A[i];
        }

        for (int i = 0; i < A.Count; i++)
        {
            rightSum -= A[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += A[i];
        }

        return -1;

    }
}
