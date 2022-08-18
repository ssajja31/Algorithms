class Solution
{
    public int isPalindrome(string a, int s, int e)
    {
        if (s > e)
        {
            return 1;
        }

        if (a[s] == a[e])
        {
            return isPalindrome(a, ++s, --e);
        }

        return 0;
    }
    public int solve(string A)
    {
        return isPalindrome(A, 0, A.Length - 1);
    }
}
