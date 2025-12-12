// Last updated: 12/11/2025, 8:02:47 PM
public class Solution {
    int rows, cols;
    int[] rowDir = new int[] {1, -1, 0, 0};
    int[] colDir = new int[] {0, 0, 1, -1};
    public void Solve(char[][] board) {
        rows = board.Length;
        cols = board[0].Length;
        MarkUnsurroundedArea(board, 'O');
        Replace(board, 'O', 'X');
        Replace(board, '#', 'O');
    }
    private void MarkUnsurroundedArea(char[][] board, char source)
    {
        for(int r=0; r<rows; r++)
        {
            if(board[r][0] == source)
            {
                DFS(board, r, 0, '#');
            }
            if(board[r][cols-1] == source)
            {
                DFS(board, r, cols-1, '#');
            }
        }
        for(int c=0; c<cols; c++)
        {
            if(board[0][c] == source)
            {
                DFS(board, 0, c, '#');
            }
            if(board[rows-1][c] == source)
            {
                DFS(board, rows-1, c, '#');
            }
        }
    }
    private void DFS(char[][] board, int row, int col, char c)
    {
        if(row < 0 || row >= rows || col < 0 || col >= cols || 
        board[row][col] != 'O')
        {
            return;
        }
        board[row][col] = c;
        int newRow=0, newCol=0;
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            DFS(board, newRow, newCol, c);
        }
    }
    private void Replace(char[][] board, char source, char replacement)
    {
        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                if(board[r][c] == source)
                {
                    board[r][c] = replacement;
                }
            }
        }
    }
}