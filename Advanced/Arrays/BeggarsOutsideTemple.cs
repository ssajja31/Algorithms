class Solution
{
    public List<int> solve(int A, List<List<int>> B)
    {
        List<int> res = new List<int>(new int[A]);

        for (int i = 0; i < B.Count; i++)
        {
            List<int> temp = B[i];
            int l = temp[0] - 1;
            int r = temp[1];
            int amount = temp[2];

            res[l] += amount;
            if (r < A)
            {
                res[r] -= amount;
            }
        }

        for (int i = 1; i < A; i++)
        {
            res[i] = res[i - 1] + res[i];
        }

        return res;
    }
}
