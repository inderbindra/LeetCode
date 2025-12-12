// Last updated: 12/11/2025, 8:00:28 PM
public class Solution {
   int er = 0, ec = 0, totZeros = 0, m = 0, n = 0;
        public int UniquePathsIII(int[][] grid)
        {
            er = 0; ec = 0; totZeros = 0; m = 0; n = 0;
            m = grid.Length;
            n = grid[0].Length;

            int sr = 0, sc = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        sr = i;
                        sc = j;
                    }
                    else if (grid[i][j] == 2)
                    {
                        er = i;
                        ec = j;
                    }
                    else if (grid[i][j] == 0)
                    {
                        totZeros++;
                    }
                }
            }

            int res = DFS(grid, sr, sc, totZeros);

            return res;
        }

        public int DFS(int[][] grid, int r, int c, int totZeros)
        {
            int outputPaths = 0;

            if (r < 0 || c < 0 || r >= m || c >= n || grid[r][c] == -1)
            {
                return 0;
            }

            else if (grid[r][c] == 2)
            {
                if (totZeros == -1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            grid[r][c] = -1;
            totZeros--;

            outputPaths = DFS(grid, r, c + 1, totZeros) +
                                DFS(grid, r + 1, c, totZeros) +
                                DFS(grid, r, c - 1, totZeros) +
                                DFS(grid, r - 1, c, totZeros);

            grid[r][c] = 0;
            totZeros++;

            return outputPaths;
        }
}