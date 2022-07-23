class Solution
{
    public int solve(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        //top 
        if (F >= D)
        {
            return 0;
        }
        //bottom
        if (B >= H)
        {
            return 0;
        }
        //left
        if (G <= A)
        {
            return 0;
        }
        if (C <= E)
        {
            return 0;
        }

        return 1;
    }
}
