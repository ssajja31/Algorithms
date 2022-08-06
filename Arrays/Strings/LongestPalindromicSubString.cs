using System.Text;

class Solution
{
    public string getPalindromeSubString(string A, int s, int e)
    {
        StringBuilder res = new StringBuilder("");
        while (s >= 0 && e < A.Length && A[s] == A[e])
        {
            s--;
            e++;
        }

        for (int i = s + 1; i < e; i++)
        {
            res.Append(A[i]);
        }

        return res.ToString();
    }
    public string longestPalindrome(string A)
    {
        string result = "";

        for (int i = 0; i < A.Length; i++)
        {
            string temp1 = getPalindromeSubString(A, i - 1, i + 1);
            string temp2 = getPalindromeSubString(A, i, i + 1);

            string temp = temp1.Length > temp2.Length ? temp1 : temp2;
            if (result.Length < temp.Length)
            {
                result = temp;
            }
        }

        return result;
    }
}
