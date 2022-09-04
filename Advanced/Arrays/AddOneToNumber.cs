class Solution {
    public List<int> plusOne(List<int> A) {
        List<int> res = new List<int>();
        int carry = 1;
        int count = 0;

        for(int i = 0; i < A.Count; i++)
        {
            if (A[i] == 0)
            {
                count++;
            }
            else
            {
                break;
            }
        }

        for(int i = A.Count - 1; i >= count; i--)
        {
            int temp = carry + A[i];
            carry = temp/10;
            res.Add(temp % 10);
        }

        if (carry > 0)
        {
            res.Add(carry);
        }

        res.Reverse();
        return res;
    }
}
