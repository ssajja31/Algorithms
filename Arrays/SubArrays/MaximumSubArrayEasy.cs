class Solution
{
    public int maxSubarray(int A, int B, List<int> C)
    {
        int result = 0;

        for (int i = 0; i < C.Count; i++)
        {
            int sum = 0;
            for (int j = i; j < C.Count; j++)
            {
                sum += C[j];

                if (sum >= result && sum <= B)
                {
                    result = sum;
                }
            }
        }

        return result;
    }
}
