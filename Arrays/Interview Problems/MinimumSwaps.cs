class Solution
{
    public int solve(List<int> A, int B)
    {
        int count = 0;
        int result = 0;
        int max = 0;
        int temp = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] <= B)
            {
                count++;
            }
        }

        for (int i = 0; i < count; i++)
        {
            if (A[i] <= B)
            {
                max++;
            }
        }
        temp = max;

        for (int i = 1; i <= A.Count - count; i++)
        {
            if (A[i - 1] <= B)
            {
                temp--;
            }
            if (A[count + i - 1] <= B)
            {
                temp++;
            }
            max = Math.Max(temp, max);
        }

        return count - max;
    }
}
