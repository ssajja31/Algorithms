class Solution
{
    public int solve(List<char> A)
    {
        for (int i = 0; i < A.Count; i++)
        {
            if (!((A[i] >= 'A' && A[i] <= 'Z') || (A[i] >= 'a' && A[i] <= 'z')))
            {
                return 0;
            }
        }
        return 1;
    }
}
