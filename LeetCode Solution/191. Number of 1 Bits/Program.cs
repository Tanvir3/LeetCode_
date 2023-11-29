public class Solution
{
    public int HammingWeight(uint n)
    {
        int count = 0;
        string binaryString = Convert.ToString(n, 2);
        for (int i = 0; i < binaryString.Length; i++)
            count += ((int)(binaryString[i] - '0'));
        return count;
    }
}