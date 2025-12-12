// Last updated: 12/11/2025, 8:01:33 PM
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        l1 = ReverseList(l1);
        l2 = ReverseList(l2);
        int v1, v2, sum=0, carry=0;
        ListNode newNode = new ListNode();
        ListNode newHead = newNode;
        while(l1 != null || l2 != null || carry >0)
        {
            v1 = l1 != null ? l1.val : 0;
            v2 = l2 != null ? l2.val : 0;
            sum = v1 + v2 + carry;
            carry = sum/10;
            sum = sum %10;
            newNode.next = new ListNode(sum);
            newNode = newNode.next;
            l1 = l1 != null && l1.next != null ? l1.next : null;
            l2 = l2 != null && l2.next != null ? l2.next : null;
        }
        return ReverseList(newHead.next);
    }
    private ListNode ReverseList(ListNode head)
    {
        ListNode curr = head;
        ListNode prev = null;
        ListNode node = null;
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
