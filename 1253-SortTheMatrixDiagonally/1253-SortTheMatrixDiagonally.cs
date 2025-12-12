// Last updated: 12/11/2025, 8:00:17 PM
public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        for(int r=0; r<mat.Length; r++)        
        {
            SortDiagonals(mat, r, 0);
        }
        for(int c=0; c<mat[0].Length; c++)        
        {
            SortDiagonals(mat, 0, c);
        }
        return mat;
    }
    private void SortDiagonals(int[][] mat, int row, int col)
    {
        PriorityQueue<int, int> pq = new();
        int newRow = row, newCol = col;

        while(newRow < mat.Length && newCol < mat[0].Length)
        {
            pq.Enqueue(mat[newRow][newCol], mat[newRow][newCol]);
            newRow++;
            newCol++;
        }
        newRow = row;
        newCol = col;
        while(newRow < mat.Length && newCol < mat[0].Length)
        {
            mat[newRow][newCol] = pq.Dequeue();
            newRow++;
            newCol++;
        }
    }
}