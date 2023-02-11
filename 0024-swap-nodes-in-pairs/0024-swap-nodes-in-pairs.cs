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
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null)  return head;
        ListNode t = head.next.next;
        t = SwapPairs(t);
        head.next.next = head;
        head = head.next;
        head.next.next = t;
        return head;
    }
}