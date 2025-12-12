// Last updated: 12/11/2025, 8:00:10 PM
public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        IDictionary<int, IList<(int to, double probability)>> adjMap = new Dictionary<int, IList<(int, double)>>();
        int i=0;
        for(i=0; i<edges.Length; i++)
        {
            adjMap.TryAdd(edges[i][0], new List<(int, double)>());
            adjMap[edges[i][0]].Add((edges[i][1], succProb[i]));
            adjMap.TryAdd(edges[i][1], new List<(int, double)>());
            adjMap[edges[i][1]].Add((edges[i][0], succProb[i]));
        }
        HashSet<int> visitedSet = new HashSet<int>();
        PriorityQueue<int, double> queue = new PriorityQueue<int, double>();
        queue.Enqueue(start_node, -1);
        int queueLength = 0, node;
        double prob = 0;
        while(queue.Count > 0)
        {
            queueLength = queue.Count;
            for(i=0; i<queueLength; i++)
            {
                queue.TryDequeue(out node, out prob);
                visitedSet.Add(node);
                if(node == end_node)
                {
                    return Math.Abs(prob);
                }
                if(adjMap.ContainsKey(node))
                {
                    for(int j=0; j<adjMap[node].Count; j++)
                    {
                        double newProb = adjMap[node][j].probability * prob;
                        if(!visitedSet.Contains(adjMap[node][j].to))
                        {
                            queue.Enqueue(adjMap[node][j].to, newProb);
                        }
                    }
                }
            }
        }
        return 0;
    }
}