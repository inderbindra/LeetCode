// Last updated: 12/11/2025, 8:01:52 PM
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
    public ListNode OddEvenList(ListNode head) {
        
        ListNode temp = head;
        ListNode evenH = null, evenT = null, oddH = null, oddT = null;
        
        int index = 1;
        
        while(temp != null)
        {
            if(index % 2==0) //Even Item
            {
                if(evenH == null)
                {
                    evenH = temp;
                    evenT = temp;
                }
                else
                {
                    evenT.next = temp;
                    evenT = evenT.next;
                }
            }
            else    //Odd Items
            {
                if(oddH == null)
                {
                    oddH = temp;
                    oddT = temp;
                }
                else
                {
                    oddT.next = temp;
                    oddT = oddT.next;
                }
            }
            
            temp = temp.next;
            index++;
        }
        
        if(evenT != null)   // This condition is required if the Linked list has only 1 node.
        {
            evenT.next = null;
        }
        
        if(oddT != null)    // This condition is required if the Linked list has only 0 node.
        {
            oddT.next = evenH;
        }
        
        return oddH;
    }
}