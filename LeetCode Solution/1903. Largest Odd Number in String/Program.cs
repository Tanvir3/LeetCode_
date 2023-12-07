public class Solution
{
    public string LargestOddNumber(string num)
    {
        string answer = "";
        int position = -1;
        for (int i = num.Length - 1; i >= 0; i--)
            if ((int)(num[i] - '0') % 2 == 1)
            {
                position = i;
                break;
            }
        if (position == num.Length - 1) answer = num;
        else answer = num.Remove(position + 1);
        return answer;
    }
}