// Last updated: 12/11/2025, 7:59:58 PM
public class Solution {
    int[] parent;
    int[] rank;
    public int MinCostConnectPoints(int[][] points) {
        if(points.Length == 1)
        {
            return 0;
        }
        List<(int From, int To, int Distance)> edges = new();
        int distance = 0;
        for(int i=0; i<points.Length; i++)
        {
            for(int j=i+1; j<points.Length; j++)
            {
                distance = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                edges.Add((i, j, distance));
            }
        }
        edges = edges.OrderBy(i=> i.Distance).ToList();

        parent = new int[points.Length];
        rank = new int[points.Length];

        for(int i=0; i<points.Length; i++)
        {
            parent[i] = i;
            rank[i] = 1;
        }
        int cost = 0;
        for(int i=0; i<edges.Count; i++)
        {
            if(Union(edges[i].From, edges[i].To))
            {
                //Console.WriteLine("From = " + edges[i].From + " To = " + edges[i].To + " distance = " + edges[i].Distance);
                cost += edges[i].Distance;
            }   
        }
       return cost; 
    }
    private int Find(int n)
    {
        int p = parent[n];
        while(p != parent[p])
        {
            parent[p] = parent[parent[p]];
            p = parent[p];
        }
        return p;
    }
    private bool Union(int n1, int n2)
    {
        int p1 = Find(n1);
        int p2 = Find(n2);

        if(p1 == p2)
        {
            return false;
        }
        else if(rank[p1] > rank[p2])
        {
            parent[p2] = p1;
            rank[p1] += rank[p2];
        }
        else
        {
            parent[p1] = p2;
            rank[p2] += rank[p1];
        }
        return true;
    }
}