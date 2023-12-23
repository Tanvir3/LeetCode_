public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var store = new HashSet<string>();
        int x = 0;
        int y = 0;
        store.Add("0,0");
        foreach (var direction in path)
        {
            if (direction == 'S') x--;
            else if (direction == 'N') x++;
            else if (direction == 'W') y--;
            else if (direction == 'E') y++;
            string currentDirection = $"{x},{y}";
            if (store.Contains(currentDirection)) return true;
            store.Add(currentDirection);
        }
        return false;
    }
}