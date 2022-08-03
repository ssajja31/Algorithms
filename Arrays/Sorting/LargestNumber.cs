using System.Text;
class Solution {
    public int comparator(int a, int b)
    {
        string l1 = a.ToString();
        string l2 = b.ToString();

       return (l1 + l2).CompareTo(l2 + l1) > 0 ? -1 : 1;
    }
    public string largestNumber(List<int> A) {
        
        StringBuilder result = new StringBuilder("");
        A.Sort(comparator);

        if (A[0] == 0)
        {
            return "0";
        }

        for(int i = 0; i < A.Count; i++)
        {
            result.Append(A[i].ToString());
        }

        return result.ToString();
    }
}
