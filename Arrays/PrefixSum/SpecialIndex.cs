class Solution
{
    public int getSum(List<int> list, int i, int j)
    {
        if (i == 0)
        {
            return list[j];
        }
        else
        {
            return list[j] - list[i - 1];
        }
    }

    public int solve(List<int> A)
    {
        int count = 0;

        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        even.Add(A[0]);
        odd.Add(0);

        for (int i = 1; i < A.Count; i++)
        {
            if (i % 2 == 0)
            {
                even.Add(even[i - 1] + A[i]);
                odd.Add(odd[i - 1]);
            }
            else
            {
                even.Add(even[i - 1]);
                odd.Add(odd[i - 1] + A[i]);
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            long evenSum = 0;
            long oddSum = 0;

            if (i == A.Count - 1)
            {
                evenSum = getSum(even, 0, i - 1);
                oddSum = getSum(odd, 0, i - 1);

            }
            else if (i == 0)
            {
                evenSum = getSum(odd, 0, A.Count - 1);
                oddSum = getSum(even, 1, A.Count - 1);
            }
            else
            {
                evenSum = getSum(even, 0, i - 1) + getSum(odd, i + 1, A.Count - 1);
                oddSum = getSum(odd, 0, i - 1) + getSum(even, i + 1, A.Count - 1);
            }

            if (evenSum == oddSum)
            {
                count++;
            }
        }

        return count;
    }
}
