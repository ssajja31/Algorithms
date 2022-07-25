class Solution
{
    public int compressBits(List<int> A)
    {
        int result = 0;

        for (int i = 0; i < A.Count; i++)
        {
            result = result ^ A[i];
        }

        return result;
    }
}
