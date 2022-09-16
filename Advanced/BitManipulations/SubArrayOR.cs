class Solution
{
    public int checkBit(int a, int i)
    {
        return ((a >> i) & 1);
    }
    public int solve(List<int> A)
    {
        long sum = 0;
        long subArrays = (long)A.Count * (A.Count + 1) / 2;

        for (int i = 0; i < 32; i++)
        {
            long count = 0;
            long tempSum = 0;
            for (int j = 0; j < A.Count; j++)
            {
                int temp = checkBit(A[j], i);

                if (temp == 0)
                {
                    count++;
                }
                else
                {
                    tempSum += (long)count * (count + 1) / 2;
                    tempSum %= 1000000007;
                    count = 0;
                }
            }

            tempSum += (long)count * (count + 1) / 2;
            tempSum %= 1000000007;

            long x = subArrays - tempSum;
            x %= 1000000007;

            sum += x * (1 << i);
            sum %= 1000000007;
        }

        return (int)sum;
    }
}
