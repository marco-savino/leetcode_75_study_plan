/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]

Example 2:

Input: list1 = [], list2 = []
Output: []

Example 3:

Input: list1 = [], list2 = [0]
Output: [0]

*/

public class Solution05 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode newHead = null, newNode = new ListNode(0, newHead), prevNode = new ListNode(0, newHead);

        if(list1 == null && list2 == null)
            return null;
        else if(list1 == null)
            return list2;
        else if(list2 == null)
            return list1;

        if(list1.val < list2.val)
        {
            newNode = list1; // Decide who is the new node (create it, if necessary)
            list1 = list1.next; // Go ahead with the list where new node has been red
        }
        else
        {
            newNode = list2;
            list2 = list2.next;
        }
        
        newHead = newNode; // Outside the While, the first established new node is saved as head of the list 
        prevNode = newNode; // The new node becomes the previous node

        
        while(list1 != null || list2 != null) // Now let's continue until the end of BOTH lists, when there is nothing more to read
        {
            if(list1 != null && list2 != null) // Both nodes must contain something in order to confront it
            {
                if(list1.val < list2.val)
                {
                    newNode = list1; // Decide who is the new node (create it, if necessary)
                    list1 = list1.next; // Go ahead with the list where new node has been red
                }
                else
                {
                    newNode = list2;
                    list2 = list2.next;
                }
            }
            else if(list2 == null)  // If one of the lists is empty, then just go ahead with the other list
            {
                newNode = list1;
                list1 = list1.next;
            }
            else
            {
                newNode = list2;
                list2 = list2.next;
            }

            prevNode.next = newNode; // Now link the new node to the previous one by using .next 
            prevNode = newNode; // Finally, the new node becomes the previous node
        }

        return newHead;
    }
}
