class Solution {
    public int solve(List<int> A) {
        int min = Int32.MaxValue;

        Dictionary<int, int> hm = new Dictionary<int, int>();

        for(int i = 0; i < A.Count; i++)
        {
            if (hm.ContainsKey(A[i]) == true)
            {
                min = Math.Min(min, Math.Abs(hm[A[i]] - i));
                hm[A[i]] = i;
            }
            else
            {
                hm.Add(A[i], i);
            }
        }

        if (min == Int32.MaxValue)
        {
            return -1;
        }
        return min;
    }
}
