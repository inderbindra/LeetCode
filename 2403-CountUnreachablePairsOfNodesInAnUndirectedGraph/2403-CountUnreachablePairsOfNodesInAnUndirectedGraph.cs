// Last updated: 12/11/2025, 7:59:49 PM
public class Solution {
    public long CountPairs(int n, int[][] edges) {
        IDictionary<int, IList<int>> pairs = new Dictionary<int, IList<int>>();
        foreach(var edge in edges)
        {
            if(pairs.ContainsKey(edge[0]))
            {
                pairs[edge[0]].Add(edge[1]);
            }
            else
            {
                pairs.Add(edge[0], new List<int> {edge[1]});
            }
            if(pairs.ContainsKey(edge[1]))
            {
                pairs[edge[1]].Add(edge[0]);
            }
            else
            {
                pairs.Add(edge[1], new List<int> {edge[0]});
            }
        }

        long totalPairs =0;
        long remainingNodes = 0, connectedNodes = 0;
        bool[] visited = new bool[n];
        for(int node=0; node<n; node++)
        {
            if(!visited[node])            
            {
                connectedNodes = DFS(node, pairs, visited);
                remainingNodes = n - connectedNodes;
                totalPairs += (remainingNodes * connectedNodes);
            }
        }
        return totalPairs/2;
    }

    long DFS(int node, IDictionary<int, IList<int>> pairs, bool[] visited)
    {
        long connectedNodes = 0;
        if(visited[node])
        {
            return connectedNodes;
        }
        connectedNodes++;
        visited[node] = true;
        if(pairs.ContainsKey(node))
        {
            for(int i=0; i<pairs[node].Count; i++)
            {
                connectedNodes += DFS(pairs[node][i], pairs, visited);
            }
        }
        return connectedNodes;
    }
}