class Solution {
    public int maxSubArray(List<int> A) {
        int maxEndingHere = 0;
        int maxSoFar = 0;
        int maxElement = A[0];

        for(int i = 0; i < A.Count; i++)
        {
            maxEndingHere = Math.Max(maxEndingHere + A[i], 0);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            maxElement = Math.Max(maxElement, A[i]);
        }

        if (maxSoFar == 0)
        {
            return maxElement;
        }

        return maxSoFar;
    }
}
