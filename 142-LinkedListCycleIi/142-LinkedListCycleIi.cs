// Last updated: 12/11/2025, 8:02:41 PM
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
    
        ListNode slow = head;
        ListNode fast = head;
        ListNode start = head;
        
        while(fast != null && fast.next != null && fast.next.next !=null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if(slow == fast)
            {
                while(slow != start)
                {
                    slow = slow.next;
                    start = start.next;
                }
                return start;
            }
        }
        
        return null;
        
    }
    
    
}