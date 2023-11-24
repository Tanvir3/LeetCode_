public class Solution
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        Array.Reverse(piles);
        int count = 0;
        int amount = (piles.Length / 3) * 2;
        for (int i = 1; i < amount; i += 2)
            count += piles[i];
        return count;
    }
}