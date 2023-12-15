public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        string answer = null;
        var map = new Dictionary<string, int>();
        for (int i = 0; i < paths.Count; i++)
            map[paths[i][0]] = 1;
        for (int i = 0; i < paths.Count; i++)
            if (!map.ContainsKey(paths[i][1]))
            {
                answer = paths[i][1];
                break;
            }
        return answer;
    }
}