// Last updated: 1/2/2026, 8:17:14 PM
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
13    public void ReorderList(ListNode head) {
14
15        ListNode l1Head = head;
16        ListNode slow = head;
17        ListNode fast = head;
18
19        // 1. Find the middle node of the Linked List
20        while(fast != null && fast.next != null)
21        {
22            slow = slow.next;
23            fast = fast.next.next;
24        }
25        
26        // 2. Reverse the second half of the Linked List
27        ListNode l2Head = ReverseList(slow.next);
28
29        // 3. Disconnect the first half of Linked List from the second half.
30        slow.next = null;
31
32        ListNode node1, node2;
33
34        // 4. Merge two Linked List Alternatively.
35        while(l2Head != null)
36        {
37            node1 = l1Head.next;
38            node2 = l2Head.next;
39            l1Head.next = l2Head;
40            l2Head.next = node1;
41            l1Head = node1;
42            l2Head = node2;
43        }
44    }
45
46    private ListNode ReverseList(ListNode head)
47    {
48        ListNode curr = head;
49        ListNode next = null;
50        ListNode prev = null;
51
52        while(curr != null)
53        {
54            next = curr.next;
55            curr.next = prev;
56            prev = curr;
57            curr = next;
58        }
59        return prev;
60    }
61}