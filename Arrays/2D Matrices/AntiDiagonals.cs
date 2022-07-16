class Solution
{
    public List<List<int>> diagonal(List<List<int>> A)
    {
        List<List<int>> result = new List<List<int>>();

        int rowL = A.Count;
        int colL = A[0].Count;

        for (int j = 0; j < colL; j++)
        {
            int temp = j;
            int i = 0;
            List<int> rowList = new List<int>(new int[colL]);

            while (i < rowL && temp >= 0)
            {
                rowList[i] = A[i][temp];
                i++;
                temp--;
            }

            result.Add(rowList);
        }

        for (int i = 1; i < rowL; i++)
        {
            int temp = i;
            int j = colL - 1;
            int index = 0;
            List<int> rowList = new List<int>(new int[colL]);

            while (temp < rowL && j >= 0)
            {
                rowList[index++] = A[temp][j];
                temp++;
                j--;
            }

            result.Add(rowList);
        }

        return result;
    }
}
