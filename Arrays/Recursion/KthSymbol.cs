class Solution
{
    public int solve(int A, int B)
    {
        if (A == 1 && B == 1)
        {
            return 0;
        }
        else
        {
            int parent = solve(A - 1, (B + 1) / 2);
            if (B % 2 != 0)
            {
                if (parent == 1)
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                if (parent == 1)
                {
                    return 0;
                }
                return 1;
            }
        }
    }
}
