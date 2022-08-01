class Solution
{
    public int noOfFactors(int a)
    {
        int count = 0;
        for (int i = 1; i * i <= a; i++)
        {
            if (a % i == 0)
            {
                count = count + 2;
            }
            if (i * i == a)
            {
                count--;
            }
        }
        return count;
    }
    public int comparator(int a, int b)
    {
        int aFac = noOfFactors(a);
        int bFac = noOfFactors(b);

        if (aFac < bFac)
        {
            return -1;
        }
        else if (aFac == bFac && a < b)
        {
            return -1;
        }
        return 1;
    }
    public List<int> solve(List<int> A)
    {
        A.Sort(comparator);
        return A;
    }
}
