public class Solution
{
    public int KnightDialer(int n)
    {
        long[] array = new long[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        long[] temp = new long[10];
        long mod = 1000000007;
        long sum = 0;

        for (int i = 1; i < n; i++)
        {
            temp[0] = (array[4] + array[6]) % mod;
            temp[1] = (array[6] + array[8]) % mod;
            temp[2] = (array[7] + array[9]) % mod;
            temp[3] = (array[4] + array[8]) % mod;
            temp[4] = (array[3] + array[9] + array[0]) % mod;
            temp[6] = (array[1] + array[7] + array[0]) % mod;
            temp[7] = (array[2] + array[6]) % mod;
            temp[8] = (array[1] + array[3]) % mod;
            temp[9] = (array[2] + array[4]) % mod;

            Buffer.BlockCopy(temp, 0, array, 0, temp.Length * sizeof(long));
        }

        for (int i = 0; i < array.Length; i++)
            sum += (array[i] % mod);

        return (int)(sum % mod);
    }
}