class Solution
{
    public List<int> dNums(List<int> A, int B)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> hm = new Dictionary<int, int>();

        if (B > A.Count)
        {
            return result;
        }

        for (int i = 0; i < B; i++)
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

        result.Add(hm.Count);

        int k = B;
        int m = 0;

        while (k < A.Count)
        {
            if (hm.ContainsKey(A[k]) == true)
            {
                hm[A[k]]++;
            }
            else
            {
                hm.Add(A[k], 1);
            }

            if (hm[A[m]] > 1)
            {
                hm[A[m]]--;
            }
            else
            {
                hm.Remove(A[m]);
            }

            k++;
            m++;

            result.Add(hm.Count);
        }

        return result;
    }
}
