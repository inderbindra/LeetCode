// Last updated: 1/3/2026, 2:33:26 PM
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
13    public ListNode MergeKLists(ListNode[] lists) {
14        if(lists.Length == 0)
15        {
16            return null;
17        }
18        ListNode node = lists[0];
19        for(int i=1; i<lists.Length; i++)
20        {
21            node = MergeList(node, lists[i]);
22        }
23        return node;
24    }
25
26    private ListNode MergeList(ListNode l1, ListNode l2)
27    {
28        if(l1 == null && l2 == null)
29        {
30            return null;
31        }
32        ListNode node = new ListNode();
33        ListNode head = new ListNode(0, node);
34
35        while(l1 != null && l2 != null)
36        {
37            if(l1.val < l2.val)
38            {
39                node.val = l1.val;
40                l1 = l1.next;
41            }
42            else
43            {
44                node.val = l2.val;
45                l2 = l2.next;
46            }
47            node.next = new ListNode();
48            node = node.next;
49        }
50
51        if(l1 != null)
52        {
53            node.val = l1.val;
54            node.next = l1.next;
55        }
56        if(l2 != null)
57        {
58            node.val = l2.val;
59            node.next = l2.next;
60        }
61        return head.next;
62    }
63}