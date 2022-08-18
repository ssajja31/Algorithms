class Solution
{
    public int solve(int A)
    {
        if (A == 0)
        {
            return 0;
        }
        else
        {
            int temp = A % 10;
            return temp + solve(A / 10);
        }
    }
}
