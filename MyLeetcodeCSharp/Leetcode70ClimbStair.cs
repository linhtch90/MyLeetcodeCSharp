namespace MyLeetcodeCSharp;

public class Leetcode70ClimbStair
{
    private readonly Dictionary<int, int> map = new();

    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;

        if (map.ContainsKey(n)) return map[n];

        var result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        map[n] = result;
        return result;
    }
}