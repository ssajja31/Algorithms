class Solution
{
    public int solve(List<int> A)
    {
        int count = 1;
        bool flag = A[0] % 2 == 0 ? true : false;

        for (int i = 1; i < A.Count; i++)
        {
            bool innerFlag = A[i] % 2 == 0 ? true : false;
            if (flag != innerFlag)
            {
                count++;
                flag = innerFlag;
            }
        }

        return count;
    }
}
