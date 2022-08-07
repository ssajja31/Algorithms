using System.Text;

class Solution
{
    public string solve(string A)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder res = new StringBuilder(A);

        res.Append(res);
        A = res.ToString();

        for (int i = 0; i < A.Length; i++)
        {
            char ch = A[i];

            if (ch < 'A' || ch > 'Z')
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    result.Append('#');
                }
                else
                {
                    result.Append(ch);
                }
            }
        }

        return result.ToString();
    }
}
