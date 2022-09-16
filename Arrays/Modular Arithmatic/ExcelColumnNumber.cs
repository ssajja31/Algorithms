class Solution
{
    public int titleToNumber(string A)
    {
        int res = 0;

        for (int i = 0; i < A.Length; i++)
        {
            int temp = A[i] + 1 - 'A';
            res = (res * 26) + temp;
        }

        return res;
    }
}
