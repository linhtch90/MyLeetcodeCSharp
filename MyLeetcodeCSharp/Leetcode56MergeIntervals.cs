namespace MyLeetcodeCSharp;

public class Leetcode56MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
        {
            return intervals;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new();
        int[] current = intervals[0];
        for (int i = 1; i < intervals.Length; i++)
        {
            int[] next = intervals[i];
            if (current[1] >= next[0])
            {
                current[1] = Math.Max(current[1], next[1]);
            }
            else
            {
                result.Add(current);
                current = next;
            }
        }

        result.Add(current);
        return result.ToArray();
    }
}