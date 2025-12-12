// Last updated: 12/11/2025, 8:00:12 PM
public class Solution {
    
    int[] res = null;
    public int[] FindBall(int[][] grid) {
     
        res = Enumerable.Repeat(-1, grid[0].Length).ToArray();
        
        for(int j=0; j<grid[0].Length; j++)
        {
            DFS(0, j, grid, j);
        }
        
        return res;
    }
    
    void DFS(int row, int col, int[][] grid, int startIndex)
    {
        if(row == grid.Length)
        {
            res[startIndex] = col;
            return;
        }
        
        if(grid[row][col] == 1)
        {
            if((col + 1) < grid[0].Length && grid[row][col+1] == 1)
            {
                DFS(row+1, col+1, grid, startIndex);
            }
        }
        
        if(grid[row][col] == -1)
        {
            if((col-1) >= 0 && grid[row][col-1] == -1)
            {
                DFS(row+1, col-1, grid, startIndex);
            }
        }
    }
}