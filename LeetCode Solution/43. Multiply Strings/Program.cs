public class Solution
{
    public string Multiply(string num1, string num2)
    {
        int maxPosition = (num1.Length * num2.Length) + 1;
        int[] multiply_dig = new int[maxPosition];
        int[] add = new int[maxPosition];
        string answer = "";

        for (int i = 0; i < maxPosition; i++)
            add[i] = 0;

        for (int i = num2.Length - 1, startPosition = maxPosition - 1; i >= 0; i--, startPosition--)
        {
            for (int j = 0; j < maxPosition; j++)
                multiply_dig[j] = 0;
            int carry = 0;
            int position = startPosition;

            for (int j = num1.Length - 1; j >= 0; j--)
            {
                int value = ((num1[j] - '0') * (num2[i] - '0')) + carry;
                multiply_dig[position] = (value % 10);
                position--;
                carry = value / 10;
            }
            while (carry != 0)
            {
                multiply_dig[position] = carry % 10;
                position--;
                carry /= 10;
            }

            carry = 0;
            for (int j = maxPosition - 1; j >= 0; j--)
            {
                int value = add[j] + multiply_dig[j] + carry;
                add[j] = value % 10;
                carry = value / 10;
            }
        }

        bool flag = false;
        for (int i = 0; i < maxPosition; i++)
        {
            if (add[i] == 0 && !flag) continue;
            else
            {
                answer += ((char)(add[i] + '0'));
                flag = true;
            }

        }

        if (answer == "") return "0";
        return answer;
    }
}