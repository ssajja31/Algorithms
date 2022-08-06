class Solution
{
    public bool isAlphaNumberic(char ch)
    {
        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
        {
            return true;
        }
        return false;
    }
    public int solve(List<char> A)
    {
        for (int i = 0; i < A.Count; i++)
        {
            if (!isAlphaNumberic(A[i]))
            {
                return 0;
            }
        }
        return 1;
    }
}
