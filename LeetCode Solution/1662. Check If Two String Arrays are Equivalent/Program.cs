public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string answer = "";
        for(int i=0; i<word1.Length; i++)
        {
            for (int j = 0; j < word1[i].Length; j++)
                answer += word1[i][j];
        }
        return true;
    }
}