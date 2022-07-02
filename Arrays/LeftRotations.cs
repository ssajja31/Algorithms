class Solution
{
    public void reverse(List<int> list, int a, int b)
    {
        while (a <= b)
        {
            int temp = list[b];
            list[b] = list[a];
            list[a] = temp;

            a++;
            b--;
        }
    }
    public void rotate(List<int> list, int k)
    {
        k = k % list.Count;
        k = list.Count - k - 1;

        reverse(list, 0, list.Count - 1);
        reverse(list, 0, k);
        reverse(list, k + 1, list.Count - 1);
    }
    public List<List<int>> solve(List<int> A, List<int> B)
    {

        List<List<int>> list = new List<List<int>>();

        for (int i = 0; i < B.Count; i++)
        {
            List<int> temp = new List<int>(A);
            rotate(temp, B[i]);

            list.Add(temp);
        }

        return list;
    }
}
