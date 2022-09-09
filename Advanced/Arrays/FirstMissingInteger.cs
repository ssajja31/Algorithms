class Solution
{
    public int firstMissingPositive(List<int> A)
    {
        for (int i = 0; i < A.Count; i++)
        {
            while (A[i] <= A.Count && A[i] > 0 && A[i] != i + 1)
            {
                int v = A[i];
                if (A[i] != A[v - 1])
                {
                    A[i] = A[v - 1];
                    A[v - 1] = v;
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] != i + 1)
            {
                return i + 1;
            }
        }

        return A.Count + 1;
    }
}
