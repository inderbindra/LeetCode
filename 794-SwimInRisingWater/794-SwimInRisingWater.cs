// Last updated: 12/11/2025, 8:00:42 PM
public class Solution {
    public int SwimInWater(int[][] grid) {
        int rows= grid.Length;
        int cols = grid[0].Length;

        int[] rowDir = new int[]{1, -1, 0, 0};
        int[] colDir = new int[]{0, 0, 1, -1};
        HashSet<(int, int)> visitedSet = new();

        int time=0, currTime=0, newRow, newCol;
        PriorityQueue<(int row, int col), int> pq = new();
        pq.Enqueue((0, 0), grid[0][0]);
        visitedSet.Add((0, 0));
        (int row, int col)cell = (0, 0);

        while(pq.Count > 0)
        {
            while(pq.TryPeek(out cell, out currTime) && currTime <= time)
            {
                pq.Dequeue();
                if(cell.row == rows-1 && cell.col == cols-1)
                {
                    return time;
                }
                for(int i=0; i<rowDir.Length; i++)
                {
                    newRow = cell.row + rowDir[i];
                    newCol = cell.col + colDir[i];
                    if(newRow >= 0 && newRow < rows && 
                        newCol >= 0 && newCol < cols &&
                        !visitedSet.Contains((newRow, newCol)))
                    {
                        visitedSet.Add((newRow, newCol));
                        pq.Enqueue((newRow, newCol), grid[newRow][newCol]);
                    }
                }
            }
            time++;
        }
        return time;
    }
}