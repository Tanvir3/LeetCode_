public class Solution
{
    public int DeleteGreatestValue(int[][] grid)
    {

        int answer = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            Array.Sort(grid[i]);
            Array.Reverse(grid[i]);
        }

        int rowSize = grid.Length;
        int columnSize = grid[0].Length;

        for (int z = 0; z < columnSize; z++)
        {
            int[] array = new int[rowSize];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = z; j <= z; j++)
                    array[i] = grid[i][j];
            }

            int max = 0;
            for (int i = 0; i < grid.Length; i++)
                max = Math.Max(max,array[i]);

            answer += max;
        }

        return answer;
    }
}