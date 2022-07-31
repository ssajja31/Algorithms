class Solution
{
    public int findMod(string A, int B)
    {
        long result = 0;
        long temp = 1;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            result += (Convert.ToInt32(A[i].ToString()) * temp) % B;
            temp = (temp * 10) % B;
        }

        return (int)(result % B);
    }
}
