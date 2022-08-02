class Solution
{
    public int solve(List<int> A)
    {
        int cost = 0;
        A.Sort();
        A.Reverse();

        for (int i = 0; i < A.Count; i++)
        {
            cost += (i + 1) * A[i];
        }

        return cost;
    }
}
