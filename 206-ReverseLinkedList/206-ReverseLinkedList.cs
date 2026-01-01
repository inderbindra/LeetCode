// Last updated: 1/1/2026, 3:43:07 PM
1/**
2 * Definition for singly-linked list.
3 * public class ListNode {
4 *     public int val;
5 *     public ListNode next;
6 *     public ListNode(int val=0, ListNode next=null) {
7 *         this.val = val;
8 *         this.next = next;
9 *     }
10 * }
11 */
12public class Solution {
13    public ListNode ReverseList(ListNode head) {
14        ListNode currentNode = head;
15        ListNode previousNode = null, node=null;
16
17        while(currentNode != null)
18        {
19            node = currentNode.next;
20            currentNode.next = previousNode;
21            previousNode = currentNode;
22            currentNode = node;
23        }
24        return previousNode;
25    }
26}