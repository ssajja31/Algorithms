class Solution
{
    public int solve(List<int> A, int B)
    {
        bool isPresent = false;
        int count = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] == B)
            {
                isPresent = true;
            }

            if (A[i] > B)
            {
                count++;
            }
        }

        if (isPresent)
        {
            return count;
        }

        return -1;
    }
}
