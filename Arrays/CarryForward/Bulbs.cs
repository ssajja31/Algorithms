class Solution
{
    public int bulbs(List<int> A)
    {
        int count = 0;
        for (int i = 0; i < A.Count; i++)
        {
            if (count % 2 != 0)
            {
                A[i] = 1 - A[i];
            }

            if (A[i] == 0)
            {
                count++;
            }
        }

        return count;
    }
}
