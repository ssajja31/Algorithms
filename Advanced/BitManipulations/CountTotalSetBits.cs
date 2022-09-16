class Solution
{
    public int solve(int A)
    {
        long count = 0;
        A++;
        int bit = 1;
        while (bit <= A)
        {
            int groups = A / bit;

            if (groups % 2 != 0)
            {
                count += (A % bit);
                count %= 1000000007;
            }

            int setBitGroups = groups / 2;
            int setBits = setBitGroups * bit;

            count += setBits;
            count %= 1000000007;

            bit *= 2;
        }

        return (int)count;
    }
}
