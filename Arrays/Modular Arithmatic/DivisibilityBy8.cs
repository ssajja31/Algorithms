class Solution
{
    public int solve(string A)
    {
        if (A.Length < 3)
        {
            int number = Convert.ToInt32(A);
            return number % 8 == 0 ? 1 : 0;
        }

        int temp = 1;
        int index = A.Length - 1;
        int num = 0;
        while (temp <= 100)
        {
            int value = Convert.ToInt32(A[index--].ToString()) * temp;

            num += value;

            temp *= 10;
        }

        return num % 8 == 0 ? 1 : 0;
    }
}
