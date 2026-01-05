// Last updated: 1/5/2026, 4:00:39 PM
1public class Solution {
2    int rows, cols;
3    int[] rowDir = {1, -1, 0, 0};
4    int[] colDir = {0, 0, 1, -1};
5    HashSet<(int, int)> visitedSet;
6
7    public bool Exist(char[][] board, string word) {
8        rows = board.Length;
9        cols = board[0].Length;
10        visitedSet = new();
11
12        bool result = false;
13        for(int r=0; r<rows; r++)
14        {
15            for(int c=0; c<cols; c++)
16            {
17                if(word[0] == board[r][c])
18                {
19                    result = DFS(board, r, c, word, 0);
20                    //Console.WriteLine("Result = " + result);
21                    if(result)
22                    {
23                       return true;
24                    }
25                }
26            }
27        }
28        return false;
29    }
30
31    private bool DFS(char[][] board, int r, int c, string word, int index)
32    {
33        //Console.WriteLine("Row = "+ r + ", Col = "+ c + " , index = " + index);
34        if(index >= word.Length)
35        {
36            //Console.WriteLine("Case True -> Row = "+ r + ", Col = "+ c + " , index = " + index);
37            return true;
38        }
39        if(r < 0 || r >= rows || c < 0 || c >= cols ||
40           visitedSet.Contains((r, c)) || 
41           word[index] != board[r][c])
42        {
43            return false;
44        }
45        visitedSet.Add((r, c));
46        index++;
47
48        int newRow, newCol;
49        bool result = false;
50        for(int i=0; i<rowDir.Length; i++)
51        {
52            newRow = r + rowDir[i];
53            newCol = c + colDir[i];
54
55            result = DFS(board, newRow, newCol, word, index);
56            if(result)
57            {
58                break;
59            }
60        }
61        visitedSet.Remove((r, c));
62        return result;
63    }
64}