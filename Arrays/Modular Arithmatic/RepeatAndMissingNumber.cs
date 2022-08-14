class Solution
{
    public List<int> repeatedNumber(List<int> A)
    {
        List<int> result = new List<int>();
        long s1 = 0;
        long s2 = 0;
        long s3 = 0;
        long s4 = 0;

        s1 = (long)A.Count * (A.Count + 1) / 2;

        for (int i = 0; i < A.Count; i++)
        {
            s2 += (long)A[i];
        }

        for (int i = 0; i < A.Count; i++)
        {
            s3 += (long)(i + 1) * (i + 1);
        }

        for (int i = 0; i < A.Count; i++)
        {
            s4 += (long)A[i] * A[i];
        }

        long m = s2 - s1;
        long n = s4 - s3;

        int x = (int)((n / m) + m) / 2;
        int y = (int)(x - m);

        result.Add(x);
        result.Add(y);

        return result;

    }
}
