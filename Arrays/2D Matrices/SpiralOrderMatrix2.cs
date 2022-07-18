class Solution
{
    public List<List<int>> generateMatrix(int A)
    {
        List<List<int>> result = new List<List<int>>();

        for (int x = 0; x < A; x++)
        {
            List<int> temp = new List<int>(new int[A]);
            result.Add(temp);
        }

        int a = 0;
        int k = A - 1;
        int i = 0;
        int j = 0;

        while (k > 0)
        {
            for (int x = 1; x <= k; x++)
            {
                result[i][j] = ++a;
                j++;
            }

            for (int x = 1; x <= k; x++)
            {
                result[i][j] = ++a;
                i++;
            }

            for (int x = 1; x <= k; x++)
            {
                result[i][j] = ++a;
                j--;
            }

            for (int x = 1; x <= k; x++)
            {
                result[i][j] = ++a;
                i--;
            }

            k = k - 2;
            i++;
            j++;
        }

        if (A % 2 != 0)
        {
            result[i][j] = ++a;
        }

        return result;
    }
}
