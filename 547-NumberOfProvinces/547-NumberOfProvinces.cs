// Last updated: 12/11/2025, 8:01:00 PM
public class Solution {
    int[] parent;
    int[] rank;
    public int FindCircleNum(int[][] isConnected) {
        parent = new int[isConnected.Length];
        rank = new int[isConnected.Length];

        for(int i=0; i<parent.Length; i++)
        {
            parent[i] = i;
            rank[i] = 1;
        }

        int noOfProvince = isConnected.Length;
        for(int r=0; r<isConnected.Length; r++)
        {
            for(int c=0; c<isConnected[r].Length; c++)
            {
                if(isConnected[r][c] == 1)
                {
                    noOfProvince -= Union(r, c);
                }
            }
        }
        return noOfProvince;
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

    private int Union(int n1, int n2)
    {
        int p1 = Find(n1);
        int p2 = Find(n2);

        if(p1 == p2)
        {
            return 0;
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
        return 1;
    }
}