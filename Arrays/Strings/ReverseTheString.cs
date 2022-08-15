using System.Text;
class Solution
{
    public void reverse(StringBuilder a, int i, int j)
    {
        while (i < j)
        {
            char temp = a[i];
            a[i] = a[j];
            a[j] = temp;

            i++;
            j--;
        }
    }
    public string solve(string A)
    {
        StringBuilder sb = new StringBuilder(A.Trim());
        StringBuilder res = new StringBuilder("");

        reverse(sb, 0, sb.Length - 1);

        int l = 0;
        int r = 0;

        while (r <= sb.Length)
        {
            if (r == sb.Length || sb[r] == ' ')
            {
                reverse(sb, l, r - 1);
                l = r + 1;
                r = l;
            }
            else
            {
                r++;
            }
        }

        int k = 0;
        bool flag = false;

        while (k < sb.Length)
        {
            while (k < sb.Length && sb[k] == ' ')
            {
                flag = true;
                k++;
            }

            if (flag)
            {
                flag = false;
                k--;
            }

            res.Append(sb[k++]);
        }
        return res.ToString();
    }
}
