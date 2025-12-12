// Last updated: 12/11/2025, 7:59:59 PM
public class Solution {

    public int MinimumEffortPath(int[][] heights) {
        PriorityQueue<(int row, int col), int> pq = new();
        int diff =0, rows = heights.Length, cols = heights[0].Length, newRow, newCol, newDiff, queueLength;
        int[][] directions = new int[4][]
        { 
            new int[2] { 1, 0},
            new int[2] {-1, 0},
            new int[2] {0, 1},
            new int[2] {0, -1}
        };
        HashSet<(int row, int col)> visitedSet = new HashSet<(int, int)>();
        pq.Enqueue((0, 0), 0);

        while(pq.Count > 0)
        {
            queueLength = pq.Count;
            for(int i=0; i<queueLength; i++)
            {
                pq.TryDequeue(out var item, out diff);
                if(visitedSet.Contains((item.row, item.col)))
                {
                    continue;
                }
                visitedSet.Add((item.row, item.col));
                if((item.row, item.col) == (rows-1, cols-1))
                {
                    return diff;
                }
                for(int j=0; j<directions.Length; j++)
                {
                    newRow = item.row + directions[j][0];
                    newCol = item.col + directions[j][1];
                    
                    if(newRow < 0 || newCol <0 || newRow >= rows || newCol >= cols ||
                        visitedSet.Contains((newRow, newCol)))
                    {
                        continue;
                    }
                    newDiff = Math.Max(diff, Math.Abs(heights[item.row][item.col] - heights[newRow][newCol]));
                    pq.Enqueue((newRow, newCol), newDiff);
                }
            }
            
        }
        return diff;
    }
}