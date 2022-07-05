class Solution {
    public int solve(List<int> A) {
        int max = A[0];
        int time = 0;

        for(int i = 0; i < A.Count; i++)
        {
            max = Math.Max(max, A[i]);
        }

        for(int i = 0; i < A.Count; i++)
        {
            time += max - A[i];
        }

        return time;
    }
}
