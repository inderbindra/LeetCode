// Last updated: 12/11/2025, 8:02:40 PM
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
    public void ReorderList(ListNode head) {
        ListNode slow = new ListNode(0, head);
        ListNode fast = new ListNode(0, head);
        
        // Find Mid Node
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode secondList = slow.next;
        slow.next = null;
        
        //Reverse SecondList
        ListNode curr = secondList;
        ListNode prev = null, node = null;
        while(curr != null)
        {
            node = curr.next;
            curr.next = prev;
            prev = curr;
            curr = node;
        }
        secondList = prev;
        // Merge the list nodes alternatively
        ListNode firstList = head;
        ListNode firstNext, secondNext;

        while(secondList != null)
        {
            firstNext = firstList.next;
            secondNext = secondList.next;
            firstList.next = secondList;
            secondList.next = firstNext;
            firstList = firstNext;
            secondList = secondNext;
        }
    }
}