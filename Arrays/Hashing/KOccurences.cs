class Solution
{
    public int getSum(int A, int B, List<int> C)
    {
        long sum = 0;
        bool flag = false;
        Dictionary<int, int> hm = new Dictionary<int, int>();
        for (int i = 0; i < C.Count; i++)
        {
            if (hm.ContainsKey(C[i]) == true)
            {
                hm[C[i]]++;
            }
            else
            {
                hm.Add(C[i], 1);
            }
        }

        for (int i = 0; i < C.Count; i++)
        {
            if (hm.ContainsKey(C[i]) == true && hm[C[i]] == B)
            {
                flag = true;
                sum += (long)C[i];
                hm[C[i]]--;
            }
            sum = sum % 1000000007;
        }

        if (!flag)
        {
            return -1;
        }
        return (int)(sum % 1000000007);
    }
}
