class Solution
{
    public int solve(List<int> A, int B)
    {
        int count = 0;

        for (int i = 0; i < A.Count; i++)
        {
            int sum = 0;
            for (int j = i; j < A.Count; j++)
            {
                int size = j - i + 1;
                sum += A[j];
                if (size % 2 == 0 && sum < B)
                {
                    count++;
                }
                else if (size % 2 != 0 && sum > B)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
