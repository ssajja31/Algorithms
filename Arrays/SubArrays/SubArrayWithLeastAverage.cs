class Solution
{
    public int solve(List<int> A, int B)
    {
        int sum = 0;
        int result = Int32.MaxValue;
        int index = 0;

        for (int i = 0; i < B; i++)
        {
            sum += A[i];
        }

        result = sum;
        for (int i = B; i < A.Count; i++)
        {
            sum -= A[i - B];
            sum += A[i];

            if (result > sum)
            {
                result = sum;
                index = i - B + 1;
            }
        }

        return index;
    }
}
