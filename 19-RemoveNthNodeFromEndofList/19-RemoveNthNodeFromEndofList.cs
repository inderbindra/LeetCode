// Last updated: 1/2/2026, 8:26:13 PM
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
13    public ListNode RemoveNthFromEnd(ListNode head, int n) {
14        ListNode node = new ListNode(0, head);
15        ListNode left = node; // Assign the same node
16        ListNode right = head;
17
18        while(n > 0 && right != null)
19        {
20            right = right.next;
21            n--;
22        }
23
24        while(right != null)
25        {
26            left = left.next;
27            right = right.next;
28        }
29
30        left.next = left.next.next;
31        return node.next;
32    }
33}