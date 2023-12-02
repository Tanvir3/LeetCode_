public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        int[] store = new int[26];
        int answer = 0;
        for (int i = 0; i < chars.Length; i++)
            store[chars[i] - 'a']++;

        foreach (var word in words)
        {
            int[] temp = new int[26];
            bool flag = true;
            for (int i = 0; i < word.Length; i++)
                temp[word[i] - 'a']++;

            Console.WriteLine(word);
            for (int i = 0; i < 26; i++)
                if (store[i] < temp[i])
                {
                    flag = false;
                    break;
                }
            if (flag) answer += word.Length;
        }
        return answer;
    }
}