public class Solution06d {

    // This is a bit too complicated, first study recursion a little bit...

    public ListNode ReverseList(ListNode head) {

        if(head == null || head.next == null)
            return head;

        ListNode prevNode = null;
        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = prevNode;

        return newHead;
    }
}