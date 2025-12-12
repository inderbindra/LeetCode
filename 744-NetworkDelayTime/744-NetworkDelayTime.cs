// Last updated: 12/11/2025, 8:00:50 PM
public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        Dictionary<int, List<(int Destination, int Time)>> adjList = new();

        for(int i=0; i<times.Length; i++)    
        {
            adjList.TryAdd(times[i][0], new List<(int Destination, int Time)>());
            adjList[times[i][0]].Add((times[i][1], times[i][2]));
        }
                    //Point, Time
        PriorityQueue<int, int> pq = new();
        pq.Enqueue(k, 0);
        int[] nodes = new int[n+1];
        Array.Fill(nodes, int.MaxValue);
        HashSet<int> visitedSet = new();
        int point=0, time=0, nextPoint=0, nextTime=0;
        while(pq.Count > 0)
        {
            if(pq.TryDequeue(out point, out time))
            {
                if(!visitedSet.Contains(point))
                {
                    visitedSet.Add(point);
                    nodes[point] = Math.Min(nodes[point], time);
                    if(visitedSet.Count == n)
                    {
                        return nodes[point];
                    }
                    if(adjList.ContainsKey(point))
                    {
                        for(int j=0; j<adjList[point].Count; j++)
                        {
                            nextPoint = adjList[point][j].Destination;
                            nextTime = time + adjList[point][j].Time;
                            if(!visitedSet.Contains(nextPoint))
                            {
                                if(nodes[nextPoint] > nextTime)
                                {
                                    pq.Enqueue(nextPoint, nextTime);
                                }
                            }
                        }
                    }
                }
            }
        }
        return -1;
    }
}