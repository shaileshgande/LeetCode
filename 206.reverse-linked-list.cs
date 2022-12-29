/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */

// @lc code=start
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
        if(head==null||head.next==null) {
            return head;
        }
        //iterative
        ListNode Prev=null;
        ListNode nextNode=head.next;
        while(head!=null){
            nextNode=head.next;
            head.next=Prev;
            Prev=head;
            head=nextNode;
        }
        return Prev;
        
        /*recusive
        ListNode nextNode=ReverseList(head.next);
        head.next.next=head;
        head.next=null;
        return nextNode;
        */



    }
}
// @lc code=end

