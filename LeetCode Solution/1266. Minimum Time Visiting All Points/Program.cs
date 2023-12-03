public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int sum = 0;
        int currentX = points[0][0], currentY = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            int x = Math.Abs(currentX - points[i][0]);
            int y = Math.Abs(currentY - points[i][1]);
            sum += Math.Max(x, y);
            currentX = points[i][0];
            currentY = points[i][1];
        }
        return sum;
    }
}