class Solution {
    public int solve(List<int> A, int B) {
        int count = 0;
        for(int i = 0; i < A.Count; i++)
        {
            int sum = 0;
            for(int j = i; j < A.Count; j++)
            {
                sum += A[j];

                if (sum < B)
                {
                    count++;
                }
            }
        }
        
        return count;
    }
}
