class Solution
{
    public int factorial(int a)
    {
        if (a <= 1)
        {
            return a;
        }

        return factorial(a - 1) * a;
    }
    public int solve(int A)
    {
        return factorial(A);
    }
}
