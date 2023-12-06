public class Solution
{
    public int TotalMoney(int n)
    {
        int portion = (n / 7);
        n %= 7;
        int sum = 0;
        for (int i = 1; i <= portion; i++)
            sum += (21 + (i * 7));
        for (int i = 1; i <= n; i++)
            sum += (portion + i);
        return sum;
    }
}