// Last updated: 12/11/2025, 8:02:46 PM
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<int, Node> hashMap;
    public Node CloneGraph(Node node) {
        hashMap = new();
        return Clone(node);
    }
    private Node Clone(Node node)
    {
        Node newNode = null;
        if(node != null)
        {
            if(!hashMap.ContainsKey(node.val))
            {
                newNode = new Node(node.val);
                hashMap.Add(node.val, newNode);
                if(node.neighbors.Count > 0)
                {
                    for(int i=0; i<node.neighbors.Count; i++)
                    {
                        newNode.neighbors.Add(Clone(node.neighbors[i]));
                    }
                }
            }
            else
            {
                newNode = hashMap[node.val];
            }
        }
        return newNode;
    }
}