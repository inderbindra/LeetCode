// Last updated: 12/11/2025, 8:02:39 PM
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
   
    public ListNode SortList(ListNode head)
    {
        ListNode left, right, temp;
        
        //Base Case
        if(head == null || head.next == null)
        {
            return head;
        }
        
        //Get the middle node in the linked list to divide the list in half
        right = GetMiddleNode(head);
        temp = right.next;
        right.next = null;

        left = head;
        right = temp;

        left = SortList(left);      //Sort Left List
        right = SortList(right);    //Sort Right List

        return MergeList(left, right);  // Merge the linked list
    }

    public ListNode GetMiddleNode(ListNode node)
    {
        ListNode slow = node, fast = node.next;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode MergeList(ListNode left, ListNode right)
    {
        ListNode head = new ListNode();
        ListNode tail = head;

        while(left != null && right != null)
        {
            if (left.val < right.val)
            {
                tail.next = left;
                left = left.next;
            }
            else
            {
                tail.next = right;
                right = right.next;
            }
            tail = tail.next;
        }

        if(left != null)
        {
            tail.next = left;
        }

        if(right != null)
        {
            tail.next = right;
        }

        return head.next;

    }
}