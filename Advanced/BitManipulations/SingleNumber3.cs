class Solution
{
    public List<int> solve(List<int> A)
    {
        int xor = 0;
        for (int i = 0; i < A.Count; i++)
        {
            xor ^= A[i];
        }

        int position = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((xor & 1) == 1)
            {
                position = i;
                break;
            }

            xor = (xor >> 1);
        }

        int sets = 0;
        int unsets = 0;

        for (int i = 0; i < A.Count; i++)
        {
            if (((A[i] >> position) & 1) == 1)
            {
                sets ^= A[i];
            }
            else
            {
                unsets ^= A[i];
            }
        }

        List<int> result = new List<int>();
        result.Add(Math.Min(sets, unsets));
        result.Add(Math.Max(sets, unsets));

        return result;
    }
}
