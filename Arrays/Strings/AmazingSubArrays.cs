class Solution
{
    public int solve(string A)
    {
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u' ||
            A[i] == 'A' || A[i] == 'E' || A[i] == 'O' || A[i] == 'I' || A[i] == 'U')
            {
                int temp = ((A.Length - i) % 10003);
                result += temp;
                result = result % 10003;
            }
        }

        return result % 10003;
    }
}
