// Last updated: 12/11/2025, 8:02:25 PM
public class Solution {
    int rows, cols;
    HashSet<(int row, int col)> visitedSet;
    int[] rowDir = new int[] {1, -1, 0, 0};
    int[] colDir = new int[]{0, 0, 1, -1};

    public int NumIslands(char[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        visitedSet = new();
        int noOfIslands = 0;
        for(int r=0; r<rows; r++)    
        {
            for(int c=0; c<cols; c++)
            {
                if(grid[r][c] == '1' && !visitedSet.Contains((r, c)))
                {
                    DFS(grid, r, c);
                    noOfIslands++;
                }
            }
        }
        return noOfIslands;
    }
    private void DFS(char[][] grid, int row, int col)
    {
        if(row < 0 || row >= rows || col < 0 || col >= cols ||
        grid[row][col] == '0' ||
        visitedSet.Contains((row, col)))
        {
            return;
        }
        visitedSet.Add((row, col));
        int newRow, newCol;
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            DFS(grid, newRow, newCol);
        }
    }
}