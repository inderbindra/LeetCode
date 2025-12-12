// Last updated: 12/11/2025, 8:00:31 PM
public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> pq = new();
        double distance = 0.0;
        int[][] result = null;
        for(int i=0; i<points.Length; i++)
        {
            distance = Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
            pq.Enqueue(points[i], -distance);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        result = new int[pq.Count][];
        for(int i=0; i<result.Length; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}