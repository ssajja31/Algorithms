class Solution
{
    public int solve(string A)
    {
        int count = 0;
        int result = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 'A')
            {
                count++;
            }
            else if (A[i] == 'G')
            {
                result += count;
                result = result % 1000000007;
            }
        }

        return result % 1000000007;
    }
}