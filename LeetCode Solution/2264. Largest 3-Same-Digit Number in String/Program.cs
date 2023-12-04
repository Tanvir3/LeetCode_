public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string answer = "";
        int sum = -1;
        for (int i = 1; i < num.Length - 1; i++)
        {
            int added = (num[i - 1] - '0') + (num[i] - '0') + (num[i + 1] - '0');
            if (num[i - 1] == num[i] && num[i] == num[i + 1] && sum < added)
            {
                answer = "";
                answer += num[i - 1];
                answer += num[i];
                answer += num[i + 1];
                sum = added;
            }
        }
        return answer;
    }
}