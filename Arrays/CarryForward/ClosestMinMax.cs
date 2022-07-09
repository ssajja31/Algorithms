class Solution
{
    public int solve(List<int> A)
    {
        int result = A.Count;
        int max = A[0];
        int min = A[0];
        int maxi = -1;
        int mini = -1;

        for (int i = 1; i < A.Count; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
            else if (A[i] < min)
            {
                min = A[i];
            }
        }

        if (max == min)
        {
            return 1;
        }

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] == min)
            {
                mini = i;
            }
            else if (A[i] == max)
            {
                maxi = i;
            }

            if (mini != -1 && maxi != -1)
            {
                result = Math.Min(result, Math.Abs(maxi - mini) + 1);
            }
        }

        return result;
    }
}
