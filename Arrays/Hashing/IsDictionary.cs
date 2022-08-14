class Solution {
    public int comparator(string a, string b, Dictionary<char, int> hm)
    {
        int m = a.Length;
        int n = b.Length;
        int i = 0; 
        int j = 0;

        while (i < m || j < n)
        {
            if (hm[a[i]] > hm[b[j]])
            {
                return 1;
            }
            else if (hm[a[i]] < hm[b[j]])
            {
                return -1;
            }
            else
            {
                i++;
                j++;

                if (i >= m && j < n)
                {
                    return -1;
                }
                else if (i < m && j >= n)
                {
                    return 1;
                }
            }
        }

        return -1;
    }
    public int solve(List<string> A, string B) {
        Dictionary<char, int> hm = new Dictionary<char, int>();

        for(int i = 0; i < 26; i++)
        {
            hm.Add(B[i], i);
        }

        for(int i = 1; i < A.Count; i++)
        {
            if (comparator(A[i-1], A[i], hm) == 1)
            {
                return 0;
            }
        }

        return 1;
    }
}
