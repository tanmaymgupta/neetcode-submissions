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
        ListNode iterator = head;
        ListNode prev = null;
        ListNode next;
        while(iterator != null)
        {
            next = iterator.next;
            iterator.next=prev;
            prev = iterator;
            iterator = next;
        }
        return prev;
    }
}


