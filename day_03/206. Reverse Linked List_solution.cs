public class Solution06c {

    public ListNode ReverseList(ListNode head) {

        ListNode prevNode = null;
        ListNode currNode = head;

        while(currNode != null)
        {
            ListNode nextNode = currNode.next; // save the current next node in a new node, 
                                                // otherwise the information of the list's next nodes is lost
            
            currNode.next = prevNode; // This is the crucial line: here the current next node of the current list 
                                        // becomes its previous one

            prevNode = currNode; // Now the current node is the previous one
            currNode = nextNode; // Go to the next node, which was correcty saved before  
        }

        return prevNode;

    }
}