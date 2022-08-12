class Solution
{
    public List<int> twoSum(List<int> A, int B)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> hm = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++)
        {
            if (hm.ContainsKey(B - A[i]) == true)
            {
                result.Add(hm[B - A[i]] + 1);
                result.Add(i + 1);
                break;
            }
            else if (hm.ContainsKey(A[i]) == false)
            {
                hm.Add(A[i], i);
            }
        }

        return result;
    }
}
