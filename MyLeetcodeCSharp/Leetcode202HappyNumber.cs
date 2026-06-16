namespace MyLeetcodeCSharp;

public class Leetcode202HappyNumber
{
    public bool IsHappy(int n)
    {
        int slow = n;
        int fast = n;
        do
        {
            slow = Compute(slow);
            fast = Compute(Compute(fast));
        } while (slow != fast);

        return slow == 1;
    }

    private int Compute(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int r = n % 10;
            sum += r * r;
            n /= 10;
        }

        return sum;
    }
}