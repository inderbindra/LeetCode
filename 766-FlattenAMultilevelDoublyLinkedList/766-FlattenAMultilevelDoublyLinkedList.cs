// Last updated: 12/11/2025, 8:00:49 PM
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        Traverse(head);
        return head;
    }
    private Node Traverse(Node head)
    {
        Node node = head;
        Node tempNode, parentNode;
        while(node != null && (node.child != null || node.next != null))
        {
            if(node.child != null)
            {
                parentNode = node;
                tempNode = node.next;
                node.next = node.child;
                node.child = null;          // Setting the child node to null.
                node = node.next;           // Moving the curr node to child node.
                node.prev = parentNode;     // Setting parent node as previous node.
                node = Traverse(node);
                node.next = tempNode;
                if(tempNode != null)
                {
                    tempNode.prev = node;       // Setting current node as tempNode's prev node.
                }
            }
            if(node.next != null)
            {
                node = node.next;
            }
        }
        return node;
    }
}