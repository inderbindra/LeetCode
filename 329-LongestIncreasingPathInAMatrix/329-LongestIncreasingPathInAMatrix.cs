// Last updated: 12/11/2025, 8:01:50 PM
public class Solution {
    int rows, cols;
    int[] rowDir = new int[] {1, -1, 0, 0};
    int[] colDir = new int[] {0, 0, 1, -1};
    Dictionary<(int r, int c), int> dp;
    public int LongestIncreasingPath(int[][] matrix) {
        rows = matrix.Length;
        cols = matrix[0].Length;
        dp = new();
        int path=0, maxPath=0;
        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                path = DFS(matrix, r, c, int.MinValue);
                maxPath = Math.Max(maxPath, path);
            }
        }
        return maxPath;
    }
    private int DFS(int[][] matrix, int row, int col, int prevVal)
    {
        if(row < 0 || row >= rows || col < 0 || col >= cols ||
          matrix[row][col] <= prevVal)
        {
            return 0;
        }
        if(dp.ContainsKey((row, col)))
        {
            return dp[(row, col)];
        }
        int path = 0, maxPath = 0;
        int newRow =0, newCol = 0;
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            path = 1 + DFS(matrix, newRow, newCol, matrix[row][col]);
            maxPath = Math.Max(maxPath, path);
        }
        dp[(row, col)] = maxPath;
        return maxPath;
    }
}