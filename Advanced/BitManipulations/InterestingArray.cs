class Solution
{
    public string solve(List<int> A)
    {
        int count = 0;
        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] % 2 != 0)
            {
                count++;
            }
        }

        if (count % 2 == 0)
        {
            return "Yes";
        }

        return "No";
    }
}
