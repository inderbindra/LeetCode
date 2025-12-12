// Last updated: 12/11/2025, 8:02:18 PM
public class TrieNode
{
    public Dictionary<char, TrieNode> Children;
    public bool IsEndOfWord;
    public TrieNode()
    {
        this.Children = new();
        this.IsEndOfWord = false;
    }
}

public class Solution {
    TrieNode root;
    int rows, cols;
    int[] rowDir = new int[]{1, -1, 0, 0};
    int[] colDir = new int[]{0, 0, 1, -1};
    HashSet<(int, int)> visitedSet;
    HashSet<string> result;
    public IList<string> FindWords(char[][] board, string[] words) {
        rows = board.Length;
        cols = board[0].Length;
        visitedSet = new();
        result = new();
        this.root = new();
        AddWords(words);
        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                if(this.root.Children.ContainsKey(board[r][c]))
                {
                    //Console.WriteLine("Called From Main --- R = " + r + " C = " + c);
                    DFS(board, r, c, this.root, new StringBuilder());
                }
            }
        }
        return result.ToList();
    }
    private void AddWords(string[] words)
    {
        TrieNode node;
        for(int i=0; i<words.Length; i++)
        {
            node = this.root;
            for(int k=0; k<words[i].Length; k++)
            {
                if(!node.Children.ContainsKey(words[i][k]))
                {
                    node.Children.Add(words[i][k], new TrieNode());
                }
                node = node.Children[words[i][k]];
            }
            node.IsEndOfWord = true;
        }
    }

    private void DFS(char[][] board, int row, int col, TrieNode node, StringBuilder str)
    {
        //Console.WriteLine("Row = " + row + " Col = " + col);
        if(node.IsEndOfWord)
        {
            result.Add(str.ToString());
            node.IsEndOfWord = false;
        }
        if(row <0 || row >= rows || col <0 || col >= cols ||
        !node.Children.ContainsKey(board[row][col]) ||
        visitedSet.Contains((row, col)))
        {
            //Console.WriteLine("Row = " + row + " Col = " + col);
            return;
        }
        visitedSet.Add((row, col));
        str.Append(board[row][col]);
        node = node.Children[board[row][col]];

        int newRow=0, newCol=0;
        for(int i=0; i<rowDir.Length; i++)
        {
            newRow = row + rowDir[i];
            newCol = col + colDir[i];
            DFS(board, newRow, newCol, node, str);
        }
        visitedSet.Remove((row, col));
        str.Remove(str.Length -1, 1);
    }
}