class Solution {
    public List<int> solve(List<List<int>> A) {
        List<int> result = new List<int>();

        for(int i = 0; i < A[0].Count; i++)
        {
            result.Add(A[0][i]);
        }

        for(int i = 0; i < A.Count; i++)
        {
            List<int> temp = new List<int>(A[i]);

            for(int j = 0; j < temp.Count; j++)
            {
                result[j] += temp[j];
            }
        }

        return result;
    }
}
