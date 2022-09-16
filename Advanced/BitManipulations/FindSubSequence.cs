class Solution
{
    public string solve(string A, string B)
    {
        int k = 0;
        char ch = A[k];

        for (int i = 0; i < B.Length; i++)
        {
            if (k == A.Length)
            {
                return "YES";
            }
            else
            {
                ch = A[k];
            }

            if (B[i] == ch)
            {
                k++;
            }
        }

        return k == A.Length ? "YES" : "NO";
    }
}
