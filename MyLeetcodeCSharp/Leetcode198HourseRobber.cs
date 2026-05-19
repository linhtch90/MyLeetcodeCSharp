namespace MyLeetcodeCSharp;

public class Leetcode198HourseRobber
{
    private int[] memo;
    private int[] nums;

    public int Rob(int[] nums)
    {
        this.nums = nums;
        memo = new int[nums.Length];
        Array.Fill(memo, -1);
        return RobRecursive(0);
    }

    private int RobRecursive(int n)
    {
        if (n > nums.Length - 1) return 0;

        if (memo[n] != -1) return memo[n];

        var skipFirst = RobRecursive(n + 1);
        var keepFirst = nums[n] + RobRecursive(n + 2);
        var result = Math.Max(skipFirst, keepFirst);
        memo[n] = result;
        return result;
    }
}