// Last updated: 12/11/2025, 8:00:00 PM
public class Solution {
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        UnionFind aliceUF = new UnionFind(n);
        UnionFind bobUF = new UnionFind(n);
        int count=0;
        // First Union all the common edges which is Type 3, so that we only increment count by 1 for both alice & bob.        
        for(int i=0; i<edges.Length; i++)
        {
            if(edges[i][0] == 3)
            {
                if(!(aliceUF.Union(edges[i][1], edges[i][2]) | bobUF.Union(edges[i][1], edges[i][2])))
                {
                    count++;
                }
            }
        }
        for(int i=0; i<edges.Length; i++)
        {
            if(edges[i][0] == 1)
            {
                if(!aliceUF.Union(edges[i][1], edges[i][2]))
                {
                    count++;
                }
            }
            if(edges[i][0] == 2)
            {
                if(!bobUF.Union(edges[i][1], edges[i][2]))
                {
                    count++;
                }
            }
        }
        return (aliceUF.IsCompletelyConnected() && bobUF.IsCompletelyConnected()) ? count : -1;
    }
}
public class UnionFind
{
    int[] parent;
    int[] rank;
    int noOfVertices = 0;
    public UnionFind(int n)
    {
        parent = new int[n+1];
        rank = new int[n+1];
        noOfVertices = n;
        InitializeParentAndRank();
    }
    private void InitializeParentAndRank()
    {
        for(int i=0; i<parent.Length; i++)
        {
            parent[i] = i;
            rank[i] = 1;
        }
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
    public bool Union(int n1, int n2)
    {
        int p1 = Find(n1);
        int p2 = Find(n2);

        if(p1 == p2)
        {
            Console.WriteLine(n1 + "," + n2);
            return false;
        }
        else
        {
            if(rank[p1] > rank[p2])
            {
                parent[p2] = p1;
                rank[p1] += rank[p2];
            }
            else
            {
                parent[p1] = p2;
                rank[p2] += rank[p1];
            }
        }
        return true;
    }
    public bool IsCompletelyConnected()
    {
        int maxRank = rank.Max();
        return (noOfVertices == maxRank);
    }
}