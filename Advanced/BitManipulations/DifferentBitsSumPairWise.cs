class Solution
{
    public int cntBits(List<int> A)
    {
        long result = 0;

        for (int i = 0; i < 32; i++)
        {
            int sets = 0;

            for (int j = 0; j < A.Count; j++)
            {
                if ((A[j] & 1) == 1)
                {
                    sets++;
                }

                A[j] = A[j] >> 1;
            }

            result += (long)sets * (A.Count - sets);
            result %= 1000000007;
        }

        result = (result * 2) % 1000000007; ;

        return (int)(result);
    }
}
