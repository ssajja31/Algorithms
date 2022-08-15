using System.Text;
class Solution
{
    public string prefixString(string a, string b)
    {
        StringBuilder sb = new StringBuilder("");
        int x = Math.Min(a.Length, b.Length);

        int i = 0;
        while (i < x && a[i] == b[i])
        {
            sb.Append(a[i]);
            i++;
        }

        return sb.ToString();
    }
    public string longestCommonPrefix(List<string> A)
    {
        string prefix = A[0];
        for (int i = 1; i < A.Count; i++)
        {
            prefix = prefixString(prefix, A[i]);
        }

        return prefix;
    }
}
