class Solution
{
    public int mod(int x)
    {
        x = x % 1000000007;
        if (x >= 0)
        {
            return x;
        }
        return 1000000007 + x;
    }
    public List<int> solve(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
    {
        int n = B.Count;
        List<int> res = new List<int>();

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 1; j < A[0].Count; j++)
            {
                long temp = mod(A[i][j] + A[i][j - 1]);
                A[i][j] = (int)temp;
            }
        }

        for (int i = 0; i < A[0].Count; i++)
        {
            for (int j = 1; j < A.Count; j++)
            {
                long temp = mod(A[j][i] + A[j - 1][i]);
                A[j][i] = (int)temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int tli = B[i] - 1;
            int tlj = C[i] - 1;

            int bri = D[i] - 1;
            int brj = E[i] - 1;

            int temp = A[bri][brj];

            if (tlj > 0)
            {
                long tempVal1 = mod(temp - A[bri][tlj - 1]);
                temp = (int)tempVal1;
            }
            if (tli > 0)
            {
                long tempVal2 = mod(temp - A[tli - 1][brj]);
                temp = (int)tempVal2;
            }
            if (tli > 0 && tlj > 0)
            {
                long tempVal3 = mod(temp + A[tli - 1][tlj - 1]);
                temp = (int)tempVal3;
            }

            res.Add(temp);
        }

        return res;
    }
}
