class Solution {
    public int diffPossible(List<int> A, int B) {
        HashSet<int> hs = new HashSet<int>();

        for(int i = 0; i < A.Count; i++)
        {
            int x = A[i] - B;
            int y = A[i] + B;

            if (hs.Contains(A[i]) == true)
            {
                return 1;
            }
            else
            {
                hs.Add(x);
                hs.Add(y);
            }
        }

        return 0;
    }
}
