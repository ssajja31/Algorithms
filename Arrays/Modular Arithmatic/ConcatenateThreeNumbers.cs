class Solution
{
    public int solve(int A, int B, int C)
    {
        int t1 = 0;
        in
t2 = 0;
        int t3 = 0;

        if (A >= B && A >= C)
        {
            t3 = A;
            t2 = Math.Max(B, C);
            t1 = Math.Min(B, C);
        }
        else if (B >= A && B >= C)
        {
            t3 = B;
            t2 = Math.Max(A, C);
            t1 = Math.Min(A, C);
        }
        else if (C >= A && C >= B)
        {
            t3 = C;
            t2 = Math.Max(A, B);
            t1 = Math.Min(A, B);
        }

        string s = t1.ToString() + t2.ToString() + t3.ToString();

        return Convert.ToInt32(s);
    }
}

