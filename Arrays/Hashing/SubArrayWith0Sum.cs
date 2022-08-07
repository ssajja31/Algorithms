class Solution
{
    public int solve(List<int> A)
    {
        HashSet<long> hs = new HashSet<long>();
        long sum = 0;

        for (int i = 0; i < A.Count; i++)
        {
            sum += A[i];

            if (sum == 0)
            {
                return 1;
            }

            if (hs.Contains(sum) == true)
            {
                return 1;
            }
            else
            {
                hs.Add(sum);
            }
        }

        return 0;
    }
}
