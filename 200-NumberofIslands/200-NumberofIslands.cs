// Last updated: 1/6/2026, 8:03:53 PM
1public class Solution {
2    int rows, cols;
3    int[] rowDir = {1, -1, 0, 0};
4    int[] colDir = {0, 0, 1, -1};
5    HashSet<(int r, int c)> visitedSet;
6    public int NumIslands(char[][] grid) {
7        rows = grid.Length;
8        cols = grid[0].Length;
9        visitedSet = new();
10
11        int noOfIslands = 0;
12        for(int r=0; r<rows; r++)
13        {
14            for(int c=0; c<cols; c++)
15            {
16                if(grid[r][c] == '1' && !visitedSet.Contains((r, c)))
17                {
18                    noOfIslands++;
19                    DFS(grid, r, c);
20                }
21            }
22        }
23        return noOfIslands;
24    }
25
26    private void DFS(char[][] grid, int row, int col)
27    {
28        if(row < 0 || row >= rows || col < 0 || col >= cols ||
29        visitedSet.Contains((row, col)) ||
30        grid[row][col] == '0')
31        {
32            return;
33        }
34
35        visitedSet.Add((row, col));
36        int newRow, newCol;
37
38        for(int i=0; i<rowDir.Length; i++)
39        {
40            newRow = row + rowDir[i];
41            newCol = col + colDir[i];
42
43            DFS(grid, newRow, newCol);
44        }
45    }
46}