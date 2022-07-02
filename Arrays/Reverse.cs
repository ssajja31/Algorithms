class Solution
{
    public List<int> solve(List<int> A)
    {
        List<int> reverse = new List<int>();

        for (int i = A.Count - 1; i >= 0; i--)
        {
            reverse.Add(A[i]);
        }

        return reverse;
    }
}
