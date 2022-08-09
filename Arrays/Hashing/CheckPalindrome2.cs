class Solution
{
    public int solve(string A)
    {
        Dictionary<char, int> hm = new Dictionary<char, int>();
        int count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (hm.ContainsKey(A[i]) == true)
            {
                hm[A[i]]++;
            }
            else
            {
                hm.Add(A[i], 1);
            }
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (hm[A[i]] % 2 != 0)
            {
                hm[A[i]]--;
                count++;
            }
            if (count > 1)
            {
                return 0;
            }
        }

        return 1;
    }
}
