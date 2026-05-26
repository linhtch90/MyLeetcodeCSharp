namespace MyLeetcodeCSharp;

public class Leetcode45JumpGameII
{
    public int Jump(int[] nums)
    {
        int furthest = 0;
        int count = 0;
        int currentEnd = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(furthest, i + nums[i]);
            if (i == currentEnd)
            {
                count++;
                currentEnd = furthest;

                if (currentEnd >= nums.Length - 1)
                {
                    break;
                }
            }
        }

        return count;
    }
}