class Solution
{
    public void rotate(List<List<int>> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                int temp = a[j][i];
                a[j][i] = a[i][j];
                a[i][j] = temp;
            }
        }

        for (int i = 0; i < a.Count; i++)
        {
            int j = 0;
            int k = a[0].Count - 1;

            while (j < k)
            {
                int temp = a[i][j];
                a[i][j] = a[i][k];
                a[i][k] = temp;

                j++;
                k--;
            }
        }
    }
}