class Solution
{
    public int solve(string A)
    {
        int result = 0;
        for (int i = 0; i < A.Length - 2; i++)
        {
            if (A[i] == 'b' && A[i + 1] == 'o' && A[i + 2] == 'b')
            {
                result++;
                i++;
            }
        }

        return result;
    }
}
