// Last updated: 12/11/2025, 7:59:56 PM
public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        int[] answer = new int[queries.Length];
        int intervalSize=0, i=0, k=0;
        int[][] queryIndex = new int[queries.Length][];

        for(i=0; i<queries.Length; i++)
        {
            queryIndex[i] = new int[2]{queries[i], i};
        }
        Array.Sort(queryIndex, (a, b)=> a[0] - b[0]);
        Array.Sort(intervals, (a, b)=> a[0] - b[0]);

        PriorityQueue<(int intervalSize, int intervalRight), int> pq = new();
        foreach(var query in queryIndex)
        {
            while(k < intervals.Length && intervals[k][0] <= query[0])
            {
                intervalSize = intervals[k][1] - intervals[k][0] + 1;
                pq.Enqueue((intervalSize, intervals[k][1]), intervalSize);
                k++;
            }
            while(pq.Count > 0 && pq.Peek().intervalRight < query[0])
            {
                pq.Dequeue();
            }
            answer[query[1]] = pq.Count > 0 ? pq.Peek().intervalSize : -1;
        }
        return answer;
    }
}