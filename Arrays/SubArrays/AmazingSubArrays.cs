class Solution
{
    public int solve(string A)
    {
        int n = A.Length;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            if (A[i] == 'A' || A[i] == 'E' || A[i] == 'I' || A[i] == 'O' || A[i] == 'U' ||
                A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u')
            {
                result += n - i;
                result = result % 10003;
            }
        }

        return result % 10003;
    }
}
