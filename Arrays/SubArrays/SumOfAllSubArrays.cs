class Solution
{
    public long subarraySum(List<int> A)
    {
        long sum = 0;
        for (int i = 0; i < A.Count; i++)
        {
            sum += ((long)A[i] * (i + 1) * (A.Count - i));
        }

        return sum;
    }
}
