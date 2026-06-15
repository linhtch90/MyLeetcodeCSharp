namespace MyLeetcodeCSharp;

public class Leetcode191NumberOfOneBits
{
    public int HammingWeight(int n)
    {
        int count = 0;
        if (n != 0)
        {
            n &= n - 1;
            count++;
        }

        return count;
    }
}