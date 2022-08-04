class Solution {
    public bool isAlternatingSubArray(List<int> A, int start, int end)
    {
        for(int i = start; i < end; i++)
        {
            if (A[i] == A[i + 1])
            {
                return false;
            }
        }
        return true;
    }
    public List<int> solve(List<int> A, int B) {
        List<int> result = new List<int>();

        for(int i = 0; i < A.Count - 2*(B); i++)
        {
            int start = i;
            int end = i + (2 * B);

            if (isAlternatingSubArray(A, start, end))
            {
                result.Add(i + B);
            }
        }

        return result;
    }
}
