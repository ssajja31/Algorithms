class Solution
{
    public int solve(int A)
    {
        int num = 0;
        int temp = 1;
        while (A > 0)
        {
            temp *= 5;
            if ((A & 1) == 1)
            {
                num += temp;
            }

            A = A >> 1;
        }

        return num;
    }
}
