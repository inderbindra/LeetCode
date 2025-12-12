// Last updated: 12/11/2025, 8:00:07 PM
public class Solution {
    public int CountNegatives(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // Console.WriteLine("Rows = " + rows);
        // Console.WriteLine("Cols = " + cols);

        int r = 0, c = cols-1, total = 0;

        while(c >= 0 && r < rows)
        {
            if(grid[r][c] < 0)
            {
                total += rows - r;
                c--;
            }
            else
            {
                r++;
            }
        }
        return total;
    }
}


