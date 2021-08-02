using System;
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
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public ListNode DeleteDuplicates(ListNode head) {
        ListNode current=head;
        while(current!=null && current.next!=null){
            if(current.val==current.next.val){
                current.next=current.next.next;
            }else{
                current =current.next;
            }
        }
        return head;
    }

}
