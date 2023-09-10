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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        int n = right - left, i = 1;
        int[] a = new int[n+1];
        ListNode c = head;
        while(c != null) {
            if(i > right)  break;
            if(i >= left) {
                a[i - left] = c.val;
            }
            c = c.next;
            i++;
        }
        Array.Reverse(a);
        c = head;
        i = 1;
        while(c != null) {
            if(i > right)  break;
            if(i >= left) {
                c.val = a[i - left];
            }
            c = c.next;
            i++;
        }
        return head;
    }
}