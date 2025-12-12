// Last updated: 12/11/2025, 8:01:38 PM
public class Solution {
    int rows, cols;
    int[] rowDir = new int[] {1, -1, 0 ,0};
    int[] colDir = new int[] {0, 0, 1, -1};
    HashSet<(int row, int col)> visitedSet;
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        rows = heights.Length;
        cols = heights[0].Length;
        visitedSet = new();
        IList<IList<int>> result = new List<IList<int>>();
        (bool canFlowPacific, bool canFlowAtlantic) status = (false, false);
        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                status = FindFlow(heights, r, c, int.MaxValue);
                if(status.canFlowPacific && status.canFlowAtlantic)
                {
                    result.Add(new List<int>{r, c});
                }
            }
        }
        return result;
    }
    private (bool canFlowPacific, bool canFlowAtlantic) FindFlow(int[][] heights, int row, int col, int prevVal)
    {
        if(row < 0 || col < 0)
        {
            return (true, false);
        }
        if(row >= rows || col >= cols)
        {
            return (false, true);
        }
        if(heights[row][col] > prevVal || visitedSet.Contains((row, col)))
        {
            return (false, false);
        }
        visitedSet.Add((row, col));
        int newRow, newCol;
        (bool canFlowPacific, bool canFlowAtlantic) result = (false, false), status = (false, false);
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            status = FindFlow(heights, newRow, newCol, heights[row][col]);
            
            result.canFlowPacific = result.canFlowPacific || status.canFlowPacific;
            result.canFlowAtlantic = result.canFlowAtlantic || status.canFlowAtlantic;
            if(result.canFlowPacific && result.canFlowAtlantic)
            {
                break;
            }
        }
        visitedSet.Remove((row, col));
        return result;
    }
}