// Last updated: 1/6/2026, 8:25:51 PM
1/*
2// Definition for a Node.
3public class Node {
4    public int val;
5    public IList<Node> neighbors;
6
7    public Node() {
8        val = 0;
9        neighbors = new List<Node>();
10    }
11
12    public Node(int _val) {
13        val = _val;
14        neighbors = new List<Node>();
15    }
16
17    public Node(int _val, List<Node> _neighbors) {
18        val = _val;
19        neighbors = _neighbors;
20    }
21}
22*/
23
24public class Solution {
25    Dictionary<Node, Node> hashMap = new();
26    public Node CloneGraph(Node node) {
27        if(node == null)
28        {
29            return null;
30        }
31        DFS(node);
32        return hashMap[node];
33    }
34
35    private void DFS(Node node)
36    {
37        if(node == null || hashMap.ContainsKey(node))
38        {
39            return;
40        }
41
42        Node newNode = new Node(node.val);
43        hashMap.TryAdd(node, newNode);
44        if(node.neighbors != null)
45        {
46            for(int i=0; i<node.neighbors.Count; i++)
47            {
48                DFS(node.neighbors[i]);
49                newNode.neighbors.Add(hashMap[node.neighbors[i]]);
50            }
51        }
52    }
53}