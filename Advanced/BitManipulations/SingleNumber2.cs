class Solution
{
    public int singleNumber(List<int> A)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            int setBits = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if ((A[j] & 1) == 1)
                {
                    setBits++;
                }
                A[j] = (A[j] >> 1);
            }

            if (setBits % 3 == 1)
            {
                result += (1 << i);
            }
        }

        return result;
    }
}
