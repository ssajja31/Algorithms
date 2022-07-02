class Solution
{
    public int solve(List<int> A)
    {
        int even = Int32.MinValue;
        int odd = Int32.MaxValue;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] % 2 == 0 && A[i] > even)
            {
                even = A[i];
            }
            else if (A[i] % 2 != 0 && A[i] < odd)
            {
                odd = A[i];
            }
        }

        return even - odd;
    }
}
