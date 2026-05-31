namespace MyLeetcodeCSharp;

public class Leetcode253MeetingRoomsII
{
    public int MinMeetingRooms(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0)
        {
            return 0;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> minHeap = new();
        minHeap.Enqueue(intervals[0][1], intervals[0][1]);
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= minHeap.Peek())
            {
                minHeap.Dequeue();
            }

            minHeap.Enqueue(intervals[i][1], intervals[i][1]);
        }

        return minHeap.Count;
    }
}