// Last updated: 12/11/2025, 8:00:54 PM
public class Solution {
    int[] parent;
    int[] rank;
    public int[] FindRedundantConnection(int[][] edges) {
        parent = new int[edges.Length+1];
        rank = new int[edges.Length+1];

        for(int i=1; i<edges.Length+1; i++)
        {
            parent[i] = i;
            rank[i] = 1;
        }

        IList<int> result = new List<int>();
        for(int i=0; i<edges.Length; i++)
        {
            if(!Union(edges[i][0], edges[i][1]))
            {
                result = new List<int>{edges[i][0], edges[i][1]};
            }
        }
        return result.ToArray();
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