class Solution
{
    public int solve(List<int> A)
    {
        int max = A[0];
        int index = 0;
        int secondMax = Int32.MinValue;

        if (A.Count == 0 || A.Count == 1)
        {
            return -1;
        }

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                index = i;
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] > secondMax && A[i] <= max && i != index)
            {
                secondMax = A[i];
            }
        }

        if (secondMax != Int32.MinValue)
        {
            return secondMax;
        }

        return -1;
    }
}
