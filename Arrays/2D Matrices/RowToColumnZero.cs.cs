class Solution
{
    public List<List<int>> solve(List<List<int>> A)
    {
        for (int i = 0; i < A.Count; i++)
        {
            bool flag = false;

            for (int j = 0; j < A[0].Count; j++)
            {
                if (A[i][j] == 0)
                {
                    flag = true;
                }
            }

            if (flag)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    if (A[i][j] != 0)
                    {
                        A[i][j] = -1;
                    }
                }
            }
        }

        for (int j = 0; j < A[0].Count; j++)
        {
            bool flag = false;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i][j] == 0)
                {
                    flag = true;
                }
            }

            if (flag)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i][j] != 0)
                    {
                        A[i][j] = -1;
                    }
                }
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            for (int j = 0; j < A[0].Count; j++)
            {
                if (A[i][j] == -1)
                {
                    A[i][j] = 0;
                }
            }
        }

        return A;
    }
}
