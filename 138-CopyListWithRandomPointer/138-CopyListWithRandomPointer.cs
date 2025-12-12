// Last updated: 12/11/2025, 8:02:45 PM
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        Dictionary<Node, Node> hashMap = new();
        Node newNode;
        Node node = head;
        while(node != null)
        {
            hashMap.Add(node, new Node(node.val));
            node = node.next;
        }
        node = head;
        while(node != null)
        {
            newNode = hashMap[node];
            if(node.next != null)
            {
                newNode.next = hashMap[node.next];
            }
            if(node.random != null)
            {
                newNode.random = hashMap[node.random];
            }
            node = node.next;
        }
        return hashMap.Count > 0 ? hashMap[head] : null;
    }
}