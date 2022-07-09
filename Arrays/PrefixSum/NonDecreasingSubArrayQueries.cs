class Solution
{
    public List<int> solve(List<int> A, List<List<int>> B)
    {
        List<int> result = new List<int>();
        List<int> pf = new List<int>();
        pf.Add(1);

        for (int i = 1; i < A.Count; i++)
        {
            if (A[i - 1] <= A[i])
            {
                pf.Add(pf[i - 1] + 1);
            }
            else
            {
                pf.Add(pf[i - 1]);
            }
        }

        for (int i = 0; i < B.Count; i++)
        {
            int l = B[i][0];
            int r = B[i][1];

            if (l == r)
            {
                result.Add(1);
            }
            else
            {
                int sum = pf[r - 1] - pf[l - 1];
                int diff = r - l;

                if (sum == diff)
                {
                    result.Add(1);
                }
                else
                {
                    result.Add(0);
                }
            }
        }

        return result;
    }
}