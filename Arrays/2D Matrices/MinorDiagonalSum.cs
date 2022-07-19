class Solution {
    public int solve(List<List<int>> A) {
        int i = A.Count - 1;
        int j = 0;
        int sum = 0;

        while (i >= 0 && j < A[0].Count)
        {
            sum += A[i][j];

            i--;
            j++;
        }

        return sum;
    }
}
