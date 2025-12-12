// Last updated: 12/11/2025, 8:02:24 PM
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode node = null;
        ListNode prev = null;
        while(curr != null)
        {
            node = curr.next;
            curr.next = prev;
            prev = curr;
            curr = node;
        }
        return prev;
    }
}