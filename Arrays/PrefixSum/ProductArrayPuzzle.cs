class Solution
{
    public List<int> solve(List<int> A)
    {
        long product = 1;
        List<int> result = new List<int>();

        for (int i = 0; i < A.Count; i++)
        {
            product *= A[i];
        }

        for (int i = 0; i < A.Count; i++)
        {
            result.Add(Convert.ToInt32(product / A[i]));
        }

        return result;
    }
}
