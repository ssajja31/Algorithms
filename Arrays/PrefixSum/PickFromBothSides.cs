class Solution {
    public int solve(List<int> A, int B) {
        int leftSum = 0;
        int sum = Int32.MinValue;

        for(int i = 0; i < B; i++)
        {
            leftSum += A[i];
        }

        sum = leftSum;
        
        for(int i = A.Count - 1, temp = B - 1; temp >= 0; i--, temp--)
        {
            leftSum = leftSum - A[temp] + A[i];
            sum = Math.Max(sum, leftSum);
        }

        return sum;
    }
}
