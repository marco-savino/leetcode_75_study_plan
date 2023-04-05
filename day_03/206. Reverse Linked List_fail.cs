/*
Given the head of a singly linked list, reverse the list, and return the reversed list.

Example 1:

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]

Input: head = [1,2]
Output: [2,1]

Example 3:

Input: head = []
Output: []

 

Constraints:

    The number of nodes in the list is the range [0, 5000].
    -5000 <= Node.val <= 5000

 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?
*/
/*
public class Solution06 {
    public ListNode ReverseList(ListNode head) {
        
        ListNode reverseHead, prevNode, currNode, reverseCurrNode, reversePrevNode;

        if(head == null)
            return null;

        currNode = head;
        do
        {
            prevNode = currNode;
            currNode = currNode.next;
        }
        while(currNode != null);
        reverseHead = new ListNode(prevNode.val, prevNode.next);

        reversePrevNode = new ListNode(reverseHead.val, reverseHead.next);

        // First of all, find the head of the new list
        nextNode = head;
        while(currNode != null)
        {
            if(areTwoNodesEquivalent(currNode.next, reverseCurrNode))
            {
                reverseCurrNode.next = new ListNode(currNode.val, currNode);
                reversePrevNode.next = reverseCurrNode;
                reverseCurrNode = reverseCurrNode.next;
            }

            prevNode.next = currNode;
            prevNode = currNode;
        }

        //while(reverseCurrNode != head)
        while(!areTwoNodesEquivalent(reverseCurrNode, head))
        {
            currNode = head;
            //while(currNode.val != reverseCurrNode.val && currNode.next != reverseCurrNode.next)
            while(!areTwoNodesEquivalent(currNode, reverseCurrNode))
            {
                Console.WriteLine("...");
                //if(currNode.next.Equals(reverseCurrNode)) // this If does not work...
                //if(currNode.next.val == reverseCurrNode.val && currNode.next.next == reverseCurrNode.next)
                if(areTwoNodesEquivalent(currNode.next, reverseCurrNode))
                {
                    reverseCurrNode.next = new ListNode(currNode.val, currNode);
                    reversePrevNode.next = reverseCurrNode;
                    reverseCurrNode = reverseCurrNode.next;
                }

                prevNode.next = currNode;
                prevNode = currNode;
            }
        }
        

        return reverseHead;
    }

    public bool areTwoNodesEquivalent(ListNode a, ListNode b)
    {
        return (a.val == b.val && a.next == b.next);
    }  
}
*/