class Solution
{
    public int solve(List<int> A)
    {
        int result = 0;

        for (int i = 0; i < A.Count; i++)
        {
            while (A[i] != i)
            {
                int temp = A[i];
                A[i] = A[temp];
                A[temp] = temp;

                result++;
            }
        }

        return result;
    }
}
