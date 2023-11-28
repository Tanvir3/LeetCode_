public class Solution
{
    public int NumberOfWays(string corridor)
    {
        bool first = false;
        bool occur = false;
        int plantCount = 0;
        int sofaCount = 0;
        int mod = 1000000007;
        long answer = 1;

        for (int i = 0; i < corridor.Length; i++)
        {
            if (corridor[i] == 'P' && first == true && sofaCount % 2 == 0) plantCount++;
            else if (corridor[i] == 'S')
            {
                sofaCount++;
                if (sofaCount >= 2) occur = true;
                if (sofaCount % 2 == 1 && first && plantCount > 0)
                {
                    answer = (answer * (plantCount + 1)) % mod;
                    plantCount = 0;
                }
                first = true;
            }
        }

        if (sofaCount < 2 || sofaCount % 2 == 1) answer = 0;
        return (int)answer;
    }
}