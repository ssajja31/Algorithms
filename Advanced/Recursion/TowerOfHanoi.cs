class Solution
{
    public void hanoiRecursion(int n, int s, int t, int d, List<List<int>> res)
    {
        if (n == 0)
        {
            return;
        }

        hanoiRecursion(n - 1, s, d, t, res);

        res.Add(new List<int> { n, s, d });

        hanoiRecursion(n - 1, t, s, d, res);
    }

    public List<List<int>> towerOfHanoi(int A)
    {
        List<List<int>> final = new List<List<int>>();

        hanoiRecursion(A, 1, 2, 3, final);

        return final;
    }
}
