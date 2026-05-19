namespace MyLeetcodeCSharp;

public class Leetcode300LongestIncreasingSubsequence
{
    private int[] memo;
    private int[] nums;

    public int LengthOfLIS(int[] nums)
    {
        this.nums = nums;
        memo = new int[nums.Length];
        Array.Fill(memo, -1);

        var max = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, LISRecursive(i));
        }

        return max;
    }

    private int LISRecursive(int i)
    {
        if (memo[i] != -1) return memo[i];

        var max = 1;
        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] > nums[i])
            {
                max = Math.Max(max, 1 + LISRecursive(j));
            }
        }

        memo[i] = max;
        return max;
    }
}