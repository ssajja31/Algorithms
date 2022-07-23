class Solution
{
    public List<int> solve(List<int> A)
    {
        int start = 0;
        int end = 0;
        int count = 0;
        List<int> result = new List<int>();

        int i = 0;
        int j = 0;
        int temp = 0;
        while (i < A.Count && j < A.Count)
        {
            if (A[j] >= 0)
            {
                temp = j - i + 1;
                if (count < temp)
                {
                    count = temp;
                    start = i;
                    end = j;
                }
                j++;
            }
            else
            {
                i = ++j;
            }
        }

        for (int k = start; k <= end; k++)
        {
            result.Add(A[k]);
        }

        return result;
    }
}
