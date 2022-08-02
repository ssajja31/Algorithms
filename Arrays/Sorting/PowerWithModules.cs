class Solution
{
    public int solve(int A, int B, int C)
    {
        long ans = 1;
        for (int i = 0; i < B; i++)
        {
            ans *= A;
            ans = ans % C;
        }

        return (int)(ans % C);
    }
}
