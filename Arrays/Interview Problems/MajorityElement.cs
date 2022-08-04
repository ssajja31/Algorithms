class Solution
{
    public int findCandidate(List<int> A)
    {
        int count = 1;
        int index = 0;
        for (int i = 1; i < A.Count; i++)
        {
            if (A[index] == A[i])
            {
                count++;
            }
            else
            {
                count--;

                if (count == 0)
                {
                    index = i;
                    count = 1;
                }
            }
        }
        return A[index];
    }
    public int majorityElement(List<int> A)
    {
        int candidate = findCandidate(A);
        int count = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] == candidate)
            {
                count++;
            }
        }

        if (count > A.Count / 2)
        {
            return candidate;
        }

        return -1;
    }
}
