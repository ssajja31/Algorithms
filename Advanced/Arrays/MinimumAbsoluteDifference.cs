class Solution {
    public int maxArr(List<int> A) {
        int min1 = Int32.MaxValue;
        int min2 = Int32.MaxValue;
        int max1 = Int32.MinValue;
        int max2 = Int32.MinValue;

        for(int i = 0; i < A.Count; i++)
        {
            min1 = Math.Min(min1, A[i] + i);
            min2 = Math.Min(min2, A[i] - i);

            max1 = Math.Max(max1, A[i] + i);
            max2 = Math.Max(max2, A[i] - i);
        }

        return Math.Max(max1 - min1, max2 - min2);
    }
}
