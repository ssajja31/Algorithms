class Solution
{
    // Solution - a xor b = c then a xor c = b and b xor c = a
    public int solve(List<int> A, int B)
    {
        Dictionary<int, int> hm = new Dictionary<int, int>();
        int count = 0;
        for (int i = 0; i < A.Count; i++)
        {
            int k = A[i] ^ B;

            if (hm.ContainsKey(k) == true)
            {
                count += hm[k];
            }

            if (hm.ContainsKey(A[i]) == true)
            {
                hm[A[i]]++;
            }
            else
            {
                hm.Add(A[i], 1);
            }
        }

        return count;
    }
}
