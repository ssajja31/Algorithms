using System.Text;

class Solution
{
    public string reverse(StringBuilder A)
    {
        int i = 0;
        int j = A.Length - 1;

        while (i < j)
        {
            char ch = A[i];
            A[i] = A[j];
            A[j] = ch;

            i++;
            j--;
        }

        return A.ToString();
    }
    public string addBinary(string A, string B)
    {
        StringBuilder str = new StringBuilder("");

        int i = A.Length - 1;
        int j = B.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0)
        {
            int temp = carry;

            if (i >= 0)
            {
                temp += Convert.ToInt32(A[i].ToString());
            }

            if (j >= 0)
            {
                temp += Convert.ToInt32(B[j].ToString());
            }

            carry = temp / 2;
            str.Append((char)((temp % 2) + '0'));

            i--;
            j--;
        }

        if (carry != 0)
        {
            str.Append((char)((carry) + '0'));
        }

        return reverse(str);
    }
}
