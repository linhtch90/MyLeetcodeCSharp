namespace MyLeetcodeCSharp;

public class Leetcode134GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int totalGas = 0;
        int currentGas = 0;
        int startIndex = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            totalGas += gas[i] - cost[i];
            currentGas += gas[i] - cost[i];
            if (currentGas < 0)
            {
                startIndex = i + 1;
                currentGas = 0;
            }
        }

        return totalGas < 0 ? -1 : startIndex;
    }
}