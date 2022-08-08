class Solution
{
    public int colorful(int A)
    {
        List<int> temp = new List<int>();
        HashSet<int> hs = new HashSet<int>();

        while (A > 0)
        {
            temp.Add(A % 10);
            A = A / 10;
        }

        for (int i = 0; i < temp.Count; i++)
        {
            int product = 1;
            for (int j = i; j < temp.Count; j++)
            {
                product *= temp[j];

                if (hs.Contains(product) == true)
                {
                    return 0;
                }
                else
                {
                    hs.Add(product);
                }
            }
        }

        return 1;
    }
}
