class Solution
{
    public int power(int A, int B, int C)
    {
        if (B == 0 && A == 0)
        {
            return 0;
        }
        else if (B == 0)
        {
            return 1;
        }

        long p = pow(A, B / 2, C);

        if (B % 2 == 0)
        {
            return (int)((p * p) % C);
        }
        else
        {
            return (int)((((p * p) % C) * A) % C);
        }
    }
    public int pow(int A, int B, int C)
    {
        int p = power(A, B, C);

        if (p < 0)
        {
            return p + C;
        }

        return p;
    }
}
