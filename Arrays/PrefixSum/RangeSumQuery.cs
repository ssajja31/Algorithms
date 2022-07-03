class Solution
{
    public List<long> rangeSum(List<int> A, List<List<int>> B)
    {
        List<long> result = new List<long>();
        List<long> prefixList = new List<long>();

        prefixList.Add(A[0]);

        for (int i = 1; i < A.Count; i++)
        {
            prefixList.Add(A[i] + prefixList[i - 1]);
        }

        for (int i = 0; i < B.Count; i++)
        {
            List<int> row = B[i];
            int l = row[0] - 1;
            int r = row[1] - 1;

            long sum = 0;
            if (l == 0)
            {
                sum = prefixList[r];
            }
            else
            {
                sum = prefixList[r] - prefixList[l - 1];
            }

            result.Add(sum);
        }

        return result;
    }
}
