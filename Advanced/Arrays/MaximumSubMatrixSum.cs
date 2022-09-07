class Solution {
    public int solve(List<List<int>> A) {
        int sum = Int32.MinValue;

        for(int i = 0; i < A.Count; i++)
        {
            for(int j = 1; j < A[0].Count; j++)
            {
                A[i][j] += A[i][j-1];
            }
        }

        for(int i = 0; i < A[0].Count; i++)
        {
            for(int j = i; j < A[0].Count; j++)
            {
                List<int> temp = new List<int>();

                for(int k = 0; k < A.Count; k++)
                {
                    if (i == 0)
                    {
                        temp.Add(A[k][j]);
                    }
                    else
                    {
                        temp.Add(A[k][j] - A[k][i-1]);
                    }
                } 

                int tempSum = Int32.MinValue;
                int sumSoFar = 0;
                int maxElement = temp[0];

                for(int l = 0; l < temp.Count; l++)
                {
                    sumSoFar = Math.Max(sumSoFar + temp[l], 0);
                    tempSum = Math.Max(tempSum, sumSoFar);
                    maxElement = Math.Max(maxElement, temp[l]);
                }  

                if (tempSum == 0)
                {
                    tempSum = maxElement;
                }

                sum = Math.Max(sum, tempSum);
            }
        }

        return sum;
    }
}
