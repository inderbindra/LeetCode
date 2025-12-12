// Last updated: 12/11/2025, 8:01:02 PM
public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        Dictionary<int, List<int>> hashMap = new();
        int rows = mat.Length;
        int cols = mat[0].Length;

        for(int r=0; r<rows; r++)
        {
            for(int c=0; c<cols; c++)
            {
                hashMap.TryAdd(r+c, new List<int>());
                hashMap[(r+c)].Add(mat[r][c]);
            }
        }

        bool flip = true;
        List<int> result = new List<int>();
        for(int r=0; r<hashMap.Keys.Count; r++)
        {
            if(flip)
            {
                hashMap[r].Reverse();
            }
            for(int i=0; i<hashMap[r].Count; i++)
            {
                result.Add(hashMap[r][i]);
            }
            flip = !flip;
        }
        return result.ToArray();
    }
}