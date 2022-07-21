class Solution
{
    public int solve(string A)
    {
        int result = 0;
        int count = 0;
        int index = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == '1')
            {
                count++;
            }
        }

        if (count == A.Length)
        {
            return count;
        }

        int r = 0;
        for (int i = 0; i < A.Length; i++)
        {
            int l = 0;
            if (A[i] == '0')
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (A[j] == '1')
                    {
                        l++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == '1')
                    {
                        r++;
                    }
                    else
                    {
                        break;
                    }
                }

                index = i + 1;

                if (count > l + r)
                {
                    result = l + r + 1;
                }
                else
                {
                    result = l + r;
                }

                break;
            }
        }

        for (int i = index; i < A.Length; i++)
        {
            int l = r;
            if (A[i] == '0')
            {
                r = 0;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == '1')
                    {
                        r++;
                    }
                    else
                    {
                        break;
                    }
                }
                int temp = 0;

                if (count > l + r)
                {
                    temp = l + r + 1;
                }
                else
                {
                    temp = l + r;
                }

                result = Math.Max(result, temp);
            }
        }

        return result;
    }
}
