class Solution
{
    public int solve(List<int> A)
    {
        A.Sort();
        int diff = A[1] - A[0];

        for (int i = 2; i < A.Count; i++)
        {
            if (A[i] - A[i - 1] != diff)
            {
                return 0;
            }
        }

        return 1;
    }
}
