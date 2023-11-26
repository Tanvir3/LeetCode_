public class Solution
{
    public int[] GetSumAbsoluteDifferences(int[] nums)
    {
        int[] result = new int[nums.Length];
        int[] previous = new int[nums.Length];
        int[] next = new int[nums.Length];
        int value = nums.Length;

        previous[0] = 0;
        for (int i = 1; i < nums.Length; i++)
            previous[i] = previous[i - 1] + (i * (nums[i] - nums[i - 1]));

        next[value - 1] = 0;
        for (int i = value - 2, j = 1; i >= 0; i--, j++)
            next[i] = next[i + 1] + (j * (nums[i + 1] - nums[i]));

        for (int i = 0; i < nums.Length; i++, value--)
        {
            Console.WriteLine($"{previous[i]} {next[i]}");
            result[i] = previous[i] + next[i];
        }

        return result;
    }
}