using System.Text;

class Solution {
    public string addBinary(string A, string B) {
        int i = A.Length - 1;
        int j = B.Length - 1;
        List<char> result = new List<char>();
        StringBuilder ans = new StringBuilder();

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
            result.Add((char)((temp % 2) + '0'));

            --i;
            --j;
        }

        if (carry != 0)
        {
            result.Add((char)((carry) + '0'));
        }

        for(int k = result.Count - 1; k >= 0; k--)
        {
            ans.Append(result[k]);
        }

        return ans.ToString();
    }
}
