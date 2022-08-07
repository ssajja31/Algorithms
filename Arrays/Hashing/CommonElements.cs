class Solution
{
    public List<int> solve(List<int> A, List<int> B)
    {
        Dictionary<int, int> hm = new Dictionary<int, int>();
        List<int> result = new List<int>();

        for (int i = 0; i < B.Count; i++)
        {
            if (hm.ContainsKey(B[i]) == true)
            {
                hm[B[i]]++;
            }
            else
            {
                hm.Add(B[i], 1);
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            if (hm.ContainsKey(A[i]) == true && hm[A[i]] > 0)
            {
                hm[A[i]]--;
                result.Add(A[i]);
            }
        }

        return result;
    }
}
