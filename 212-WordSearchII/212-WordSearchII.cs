// Last updated: 1/6/2026, 5:22:34 PM
1public class TrieNode
2{
3    public Dictionary<char, TrieNode> Children;
4    public bool IsEndOfWord;
5    public TrieNode()
6    {
7        this.Children = new();
8        this.IsEndOfWord = false;
9    }
10}
11
12public class Solution {
13    TrieNode root;
14    int rows, cols;
15    int[] rowDir = new int[]{1, -1, 0, 0};
16    int[] colDir = new int[]{0, 0, 1, -1};
17    HashSet<(int, int)> visitedSet;
18    HashSet<string> result;
19    public IList<string> FindWords(char[][] board, string[] words) {
20        rows = board.Length;
21        cols = board[0].Length;
22        visitedSet = new();
23        result = new();
24        this.root = new();
25        AddWords(words);
26        for(int r=0; r<rows; r++)
27        {
28            for(int c=0; c<cols; c++)
29            {
30                if(this.root.Children.ContainsKey(board[r][c]))
31                {
32                    //Console.WriteLine("Called From Main --- R = " + r + " C = " + c);
33                    DFS(board, r, c, this.root, new StringBuilder());
34                }
35            }
36        }
37        return result.ToList();
38    }
39    private void AddWords(string[] words)
40    {
41        TrieNode node;
42        for(int i=0; i<words.Length; i++)
43        {
44            node = this.root;
45            for(int k=0; k<words[i].Length; k++)
46            {
47                if(!node.Children.ContainsKey(words[i][k]))
48                {
49                    node.Children.Add(words[i][k], new TrieNode());
50                }
51                node = node.Children[words[i][k]];
52            }
53            node.IsEndOfWord = true;
54        }
55    }
56
57    private void DFS(char[][] board, int row, int col, TrieNode node, StringBuilder str)
58    {
59        //Console.WriteLine("Row = " + row + " Col = " + col);
60        if(node.IsEndOfWord)
61        {
62            result.Add(str.ToString());
63            node.IsEndOfWord = false;
64        }
65        if(row <0 || row >= rows || col <0 || col >= cols ||
66        !node.Children.ContainsKey(board[row][col]) ||
67        visitedSet.Contains((row, col)))
68        {
69            //Console.WriteLine("Row = " + row + " Col = " + col);
70            return;
71        }
72        visitedSet.Add((row, col));
73        str.Append(board[row][col]);
74        node = node.Children[board[row][col]];
75
76        int newRow=0, newCol=0;
77        for(int i=0; i<rowDir.Length; i++)
78        {
79            newRow = row + rowDir[i];
80            newCol = col + colDir[i];
81            DFS(board, newRow, newCol, node, str);
82        }
83        visitedSet.Remove((row, col));
84        str.Remove(str.Length -1, 1);
85    }
86}