using System.Text;
class Solution
{
    public string solve(string A)
    {
        StringBuilder s = new StringBuilder(A);
        int i = 0;
        int j = A.Length - 1;

        while (i < j)
        {
            char ch = s[i];
            s[i] = s[j];
            s[j] = ch;

            i++;
            j--;
        }

        return s.ToString();
    }
}
