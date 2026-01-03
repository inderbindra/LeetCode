// Last updated: 1/2/2026, 8:02:44 PM
1/**
2 * Definition for singly-linked list.
3 * public class ListNode {
4 *     public int val;
5 *     public ListNode next;
6 *     public ListNode(int x) {
7 *         val = x;
8 *         next = null;
9 *     }
10 * }
11 */
12public class Solution {
13    public bool HasCycle(ListNode head) {
14        ListNode slow = head;    
15        ListNode fast = head;
16
17        while(fast != null && fast.next != null)
18        {
19            slow = slow.next;
20            fast = fast.next.next;
21            if(slow == fast)
22            {
23                return true;
24            }
25        }
26        return false;
27    }
28}