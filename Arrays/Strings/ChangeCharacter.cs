class Solution
{
    public int solve(string A, int B)
    {
        int res = 0;
        List<int> temp = new List<int>(new int[26]);

        for (int i = 0; i < A.Length; i++)
        {
            temp[A[i] - 97]++;
        }

        temp.Sort();

        int k = 0;
        while (B > 0 && k < 25)
        {
            if (temp[k] < B)
            {
                B -= temp[k];
                temp[k] = 0;
            }
            else
            {
                temp[k] -= B;
                B = 0;
            }
            k++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (temp[i] > 0)
            {
                res++;
            }
        }

        return res;
    }
}
