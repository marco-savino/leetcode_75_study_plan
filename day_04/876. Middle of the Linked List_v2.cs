public class Solution07b {
    public ListNode MiddleNode(ListNode head) {

        ListNode currNode = head, slowPointer = head;
        int i = 1;

        while(currNode != null)
        {
            if(i % 2 == 0) // In this way, this pointer will point to half of the list when the other pointer is at the end of it
                slowPointer = slowPointer.next;

            i++;
            currNode = currNode.next;
        }

        return slowPointer;
    }
}