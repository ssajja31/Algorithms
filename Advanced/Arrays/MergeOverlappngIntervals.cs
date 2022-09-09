using System.Collections.Generic;
using System;

public class Interval
{
    public int start;
    public int end;
    public Interval() { start = 0; end = 0; }
    public Interval(int s, int e) { start = s; end = e; }
}

class Solution
{
    public int comparator(Interval interval1, Interval interval2)
    {
        if (interval1.start == interval2.start)
        {
            return interval1.end > interval2.end ? 1 : -1;
        }

        return interval1.start > interval2.start ? 1 : -1;
    }
    public List<Interval> merge(List<Interval> intervals)
    {
        List<Interval> result = new List<Interval>();
        intervals.Sort(comparator);

        Interval temp = intervals[0];

        for (int i = 1; i < intervals.Count; i++)
        {
            int a = temp.start;
            int b = temp.end;

            int c = intervals[i].start;
            int d = intervals[i].end;

            if (b < c)
            {
                result.Add(temp);
                temp = intervals[i];
            }
            else
            {
                temp.start = Math.Min(a, c);
                temp.end = Math.Max(b, d);
            }
        }

        result.Add(temp);

        return result;
    }
}