namespace MyLeetcodeCSharp;

public class Leetcode312BurstBalloons
{
    public int MaxCoins(int[] nums)
    {
        int n = nums.Length;
        int[] balloons = new int[n + 2];
        balloons[0] = 1;
        balloons[n + 1] = 1;
        for (int i = 0; i < n; i++)
        {
            balloons[i + 1] = nums[i];
        }

        int[,] memo = new int[n + 2, n + 2];
        for (int i = 0; i < n + 2; i++)
        {
            for (int j = 0; j < n + 2; j++)
            {
                memo[i, j] = -1;
            }
        }

        return Solve(balloons, 0, n + 1, memo);
    }

    private int Solve(int[] balloons, int left, int right, int[,] memo)
    {
        if (left + 1 == right)
        {
            return 0;
        }

        if (memo[left, right] != -1)
        {
            return memo[left, right];
        }

        int maxCoins = 0;
        for (int i = left + 1; i < right; i++)
        {
            int coins = balloons[left] * balloons[i] * balloons[right];
            int total = Solve(balloons, left, i, memo) + Solve(balloons, i, right, memo) + coins;
            maxCoins = Math.Max(maxCoins, total);
        }

        return memo[left, right] = maxCoins;
    }
}