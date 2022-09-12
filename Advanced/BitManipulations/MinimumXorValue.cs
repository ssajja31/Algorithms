class Solution
{
    public int findMinXor(List<int> A)
    {
        int min = Int32.MaxValue;
        A.Sort();

        for (int i = 0; i < A.Count - 1; i++)
        {
            min = Math.Min(min, A[i] ^ A[i + 1]);
        }

        return min;
    }
}
