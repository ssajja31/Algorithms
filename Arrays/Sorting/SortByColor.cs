class Solution
{
    public List<int> sortColors(List<int> A)
    {
        int low = 0;
        int mid = 0;
        int high = A.Count - 1;

        while (mid <= high)
        {
            if (A[mid] == 0)
            {
                int temp = A[low];
                A[low] = A[mid]; ;
                A[mid] = temp;

                mid++;
                low++;
            }
            else if (A[mid] == 1)
            {
                mid++;
            }
            else
            {
                int temp = A[high];
                A[high] = A[mid];
                A[mid] = temp;

                high--;
            }
        }

        return A;
    }
}
