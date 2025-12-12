// Last updated: 12/11/2025, 8:00:52 PM
public class Solution {
    int[] rowDir = new int[]{1, -1, 0, 0};
    int[] colDir = new int[]{0, 0, 1, -1};
    int maxArea = 0, rows =0, cols=0;
    HashSet<(int r, int c)> visitedSet;
    public int MaxAreaOfIsland(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        visitedSet = new();
        for(int r=0; r < rows; r++)
        {
            for(int c=0; c < cols; c++)
            {
                if(grid[r][c] == 1 && !visitedSet.Contains((r, c)))
                {
                    int area = DFS(grid, r, c);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        return maxArea;
    }
    private int DFS(int[][] grid, int row, int col)
    {
        if(row < 0 || row >= rows || col < 0 || col >= cols || 
        grid[row][col] == 0 || 
        visitedSet.Contains((row, col)))
        {
            return 0;
        }
        int newRow =0, newCol=0, area=1;        
        visitedSet.Add((row, col));
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            area += DFS(grid, newRow, newCol);
        }
        return area;
    }
}