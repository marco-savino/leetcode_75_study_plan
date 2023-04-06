public class Solution06b {
    public ListNode ReverseList(ListNode head) {
        
        ListNode currNode, reverseCurrNode, reverseHead = null;
        bool match;

        if(head == null)
            return null;

        
        currNode = head;

        while(currNode != null)
        {
            reverseHead = new ListNode(currNode.val, null); // reverseHead can be obtained running through the list and assign currNode if it is not null

            //currNode.next = nextNode; // Binding the current node with the next node
            //currNode = nextNode; // The next iteration, next node becomes the current node
            currNode = currNode.next;
        }
        
        reverseCurrNode = reverseHead;
        while(reverseCurrNode != head)
        {
            currNode = new ListNode(head.val, head.next);
            match = false;
            while(!match && !areTwoNodesEquivalent(currNode, reverseCurrNode))
            {
                if(areTwoNodesEquivalent(currNode.next, reverseCurrNode))
                {
                    reverseCurrNode.next = new ListNode(currNode.val, null);
                    reverseCurrNode = reverseCurrNode.next;
                    match = true;
                }

                //currNode.next = nextNode;
                //currNode = nextNode;
                currNode = currNode.next;
            }
        }

        return reverseHead;
    }

    public bool areTwoNodesEquivalent(ListNode a, ListNode b)
    {
        return (a.val == b.val && a.next == b.next);
    }  
}