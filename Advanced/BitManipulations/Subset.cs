class Solution
{
    public bool checkBit(int a, int i)
    {
        return ((a >> i) & 1) == 1 ? true : false;
    }

    public int comparator(List<int> A, List<int> B)
    {
        int i = 0;
        int j = 0;

        while (i < A.Count && j < B.Count)
        {
            if (A[i] < B[j])
            {
                return -1;
            }
            else if (A[i] > B[j])
            {
                return 1;
            }

            i++;
            j++;
        }

        if (A.Count < B.Count)
        {
            return -1;
        }
        return 1;
    }

    public List<List<int>> subsets(List<int> A)
    {
        A.Sort();
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < (1 << A.Count); i++)
        {
            List<int> temp = new List<int>();

            for (int j = 0; j < A.Count; j++)
            {
                if (checkBit(i, j))
                {
                    temp.Add(A[j]);
                }
            }

            result.Add(temp);
        }

        result.Sort(comparator);

        return result;
    }
}
