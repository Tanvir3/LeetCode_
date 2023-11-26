public class Solution
{
    public int LargestSubmatrix(int[][] matrix)
    {
        int rowSize = matrix.Length;
        int columnSize = matrix[0].Length;
        int result = 0;

        for (int i = 0; i < rowSize; i++)
        {
            if (i > 0)
                for (int j = 0; j < columnSize; j++)
                {
                    if (matrix[i][j] == 1)
                        matrix[i][j] += matrix[i - 1][j];
                }

            int[] store = new int[columnSize];
            Array.Copy(matrix[i], store, columnSize);
            Array.Sort(store);
            Array.Reverse(store);

            for (int j = 0; j < columnSize; j++)
            {
                int value = store[j] * (j + 1);
                result = Math.Max(result, value);
            }

        }

        return result;
    }
}