class Solution
{
    public int checkBit(int a, int i)
    {
        return ((a >> i) & 1);
    }
    public int solve(List<int> A, int B)
    {
        for (int i = 0; i < (1 << A.Count); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if (checkBit(i, j) == 1)
                {
                    sum += A[j];
                }
            }
            if (sum == B)
            {
                return 1;
            }
        }

        return 0;
    }
}
