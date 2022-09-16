class Solution
{
    public int checkBit(int a, int i)
    {
        return ((a >> i) & 1);
    }
    public int solve(List<int> A)
    {
        int max = 0;

        for (int i = 31; i >= 0; i--)
        {
            int count = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if (checkBit(A[j], i) == 1)
                {
                    count++;
                }
            }

            if (count >= 4)
            {
                for (int k = 0; k < A.Count; k++)
                {
                    if (checkBit(A[k], i) == 0)
                    {
                        A[k] = 0;
                    }
                }

                max += (1 << i);
            }
        }

        return max;
    }
}
