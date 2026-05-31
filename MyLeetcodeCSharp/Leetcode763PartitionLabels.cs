namespace MyLeetcodeCSharp;

public class Leetcode763PartitionLabels
{
    public IList<int> PartitionLabels(string s)
    {
        List<int> result = new();
        if (string.IsNullOrWhiteSpace(s))
        {
            return result;
        }

        int[] lastOccurence = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            lastOccurence[s[i] - 'a'] = i;
        }

        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            end = Math.Max(end, lastOccurence[s[i] - 'a']);
            if (i == end)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }

        return result;
    }
}