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
    static int getLength(ListNode head) {

        int length = 0;

        while (head != null) {
            length++;
            head = head.next;
        }

        return length;
    }

    static ListNode Reverse(ListNode head){
        ListNode current = head;
        ListNode prev = null;
        ListNode next;

        while(current != null){
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    public static void Merge(ListNode head1,
                                       ListNode head2) 
    {

        // base cases
        if (head1 == null)
            return;
        if (head2 == null)
            return;

        while(head1 != null && head2 != null){
            var next1 = head1.next;
            var next2 = head2.next;

            head1.next = head2;
            head2.next = next1;

            head1 = next1;
            head2 = next2;
        }

        return;
    }

    public void ReorderList(ListNode head) {
        if (head.next == null) return;
        List<int> result = new List<int>();
        ListNode current = head;
        ListNode secondHalf = current;
        int length = getLength(current);
        int midIndex = length / 2;

        for (int i = 0; i <= midIndex - 1; i++) 
        {
            current = current.next;
        }

        secondHalf = current.next;
        current.next = null;
        secondHalf = Reverse(secondHalf);

        Merge(head, secondHalf);

    }
}
