// Last updated: 1/1/2026, 3:57:46 PM
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
13    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
14        if(list1 == null && list2 == null)
15        {
16            return null;
17        }
18        ListNode node = new ListNode();
19        ListNode head = new ListNode(0, node);
20
21        while(list1 != null && list2 != null)
22        {
23            if(list1.val < list2.val)
24            {
25                node.val = list1.val;
26                list1 = list1.next;
27            }
28            else
29            {
30                node.val = list2.val;
31                list2 = list2.next;
32            }
33            node.next = new ListNode();
34            node = node.next;
35        }
36        if(list1 != null)
37        {
38            node.val = list1.val;
39            node.next = list1.next;
40        }
41        if(list2 != null)
42        {
43            node.val = list2.val;
44            node.next = list2.next;
45        }
46        return head.next;
47    }
48}