class Solution
{
    public long solve(int A, List<int> B)
    {
        long total = (long)A * (A + 1) / 2;
        long count = 0;
        long temp = 0;
        for (int i = 0; i < A; i++)
        {
            if (B[i] == 0)
            {
                temp++;
            }
            else
            {
                count += (temp) * (temp + 1) / 2;
                temp = 0;
            }
        }

        return total - count - (temp) * (temp + 1) / 2;
    }
}
