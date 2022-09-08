class Solution
{
    public int solve(List<List<int>> A)
    {
        int row = -1;

        int i = 0;
        int j = A.Count - 1;

        while (i < A.Count && j >= 0)
        {
            if (A[i][j] == 1)
            {
                j--;
                row = i;
            }
            else
            {
                i++;
            }
        }

        return row;
    }
}
