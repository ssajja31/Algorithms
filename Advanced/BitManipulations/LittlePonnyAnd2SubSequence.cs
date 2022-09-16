class Solution
{
    public string solve(string A)
    {
        char first = 'z';
        char second = 'z';
        int index = 0;

        for (int i = 0; i < A.Length - 1; i++)
        {
            if (first > A[i])
            {
                first = A[i];
                index = i;
            }
        }

        for (int i = index + 1; i < A.Length; i++)
        {
            if (second >= A[i])
            {
                second = A[i];
            }
        }

        string res = "";
        res += ((char)first);
        res += (char)second;

        return res;
    }
}
