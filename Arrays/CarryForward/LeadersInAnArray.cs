class Solution
{
    public List<int> solve(List<int> A)
    {
        int max = 0;
        List<int> result = new List<int>();

        for (int i = A.Count - 1; i >= 0; i--)
        {
            if (A[i] > max)
            {
                result.Add(A[i]);
                max = A[i];
            }
        }

        return result;
    }
}
