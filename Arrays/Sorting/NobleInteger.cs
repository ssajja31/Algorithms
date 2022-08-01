class Solution {
    public int solve(List<int> A) {
        A.Sort();
        A.Reverse();

        if (A[0] == 0)
        {
            return 1;
        }

        for(int i = 1; i < A.Count; i++)
        {
            if (A[i] != A[i-1] && A[i] == i)
            {
                return 1;
            }
        }

        return -1;
    }
}
