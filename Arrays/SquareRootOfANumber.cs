class Solution
{
    public int solve(int a)
    {
        for (int i = 1; i * i <= a; i++)
        {
            if (i * i == a)
            {
                return i;
            }
        }

        return -1;
    }
}
