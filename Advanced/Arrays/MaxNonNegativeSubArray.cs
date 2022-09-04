class Solution
{
    public List<int> maxset(List<int> A)
    {
        List<int> res = new List<int>();
        long sum = 0;
        int s = 0;
        int e = -1;

        long temp = 0;
        int tempStart = 0;
        int tempEnd = -1;

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] >= 0)
            {
                temp += A[i];
            }
            if (A[i] < 0 || i == A.Count - 1)
            {
                tempEnd = (i == A.Count - 1 && A[i] > 0) ? i : i - 1;
                if (sum == temp)
                {
                    if (e - s < tempEnd - tempStart)
                    {
                        e = tempEnd;
                        s = tempStart;
                    }
                }
                else
                {
                    if (temp > sum)
                    {
                        sum = temp;
                        s = tempStart;
                        e = tempEnd;
                    }
                }

                temp = 0;
                tempStart = i + 1;
            }
        }

        for (int i = s; i <= e; i++)
        {
            res.Add(A[i]);
        }

        return res;
    }
}
