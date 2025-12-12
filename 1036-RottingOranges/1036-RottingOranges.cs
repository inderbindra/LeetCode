// Last updated: 12/11/2025, 8:00:23 PM
public class Solution {
    public int OrangesRotting(int[][] grid) {
        int[] rowDir = new int[]{1, -1, 0, 0};
        int[] colDir = new int[]{0, 0, 1, -1};
        int noOfFreshOranges = 0;
        int rows= grid.Length, cols= grid[0].Length;
        Queue<(int row, int col)> queue = new();
        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                if(grid[r][c] == 2)
                {
                    queue.Enqueue((r, c));
                }
                else if(grid[r][c] == 1)
                {
                    noOfFreshOranges++;
                }
            }
        }
        if(noOfFreshOranges == 0)
        {
            return 0;
        }
        int queueLength =0, time=-1, newRow, newCol;
        (int row, int col)cell = (0, 0);

        while(queue.Count > 0)
        {
            queueLength = queue.Count;
            for(int i=0; i<queueLength; i++)
            {
                cell = queue.Dequeue();
                for(int k=0; k<rowDir.Length; k++)
                {
                    newRow = cell.row + rowDir[k];
                    newCol = cell.col + colDir[k];

                    if(newRow >=0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] == 1)
                    {
                        queue.Enqueue((newRow, newCol));
                        grid[newRow][newCol] = 2;
                        noOfFreshOranges--;
                    }
                }
            }
            time++;
        }
        return noOfFreshOranges == 0 ? time: -1;
    }
}