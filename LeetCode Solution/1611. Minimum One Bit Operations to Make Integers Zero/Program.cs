public class Solution
{
    public int MinimumOneBitOperations(int n)
    {
        if (n == 0) return 0;
        return n ^ MinimumOneBitOperations(n >> 1);
    }
}