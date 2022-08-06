class Solution {
    public List<char> to_lower(List<char> A) {
        for(int i = 0; i < A.Count; i++)
        {
            if (A[i] >= 'A' && A[i] <= 'Z')
            {
                A[i] = (char)(A[i] + 32);
            }
        }
        return A;
    }
}
