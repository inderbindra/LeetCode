// Last updated: 12/11/2025, 8:02:06 PM
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
    public bool IsPalindrome(ListNode head) {
        
        Stack<ListNode> stack = new Stack<ListNode>();
        
        ListNode temp = head;
        
        while(temp != null)
        {
            stack.Push(temp);
            temp = temp.next;
        }
        
        while(head != null)
        {
            if(head.val != stack.Pop().val)
            {
                return false;
            }
            head = head.next;
        }
        
        return true;
    }
    
}