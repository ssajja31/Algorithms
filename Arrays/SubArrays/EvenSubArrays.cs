class Solution
{
    public bool IsPossible(List<int> A, int i, int j, int n)
    {
        if (A[i] % 2 == 0 && A[j] % 2 == 0 && n % 2 == 0)
        {
            return true;
        }

        return false;
    }
    public string solve(List<int> A)
    {
        int n = A.Count;

        if (n % 2 != 0)
        {
            return "NO";
        }

        if (IsPossible(A, 0, n - 1, n))
        {
            return "YES";
        }

        return "NO";
    }
}

