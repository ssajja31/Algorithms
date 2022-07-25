class Solution
{
    public string solve(List<int> A)
    {
        int sum = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] % 2 == 1)
            {
                sum += A[i];
            }
        }

        if (sum % 2 == 1)
        {
            return "No";
        }
        else
        {
            return "Yes";
        }
    }
}
