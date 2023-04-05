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
            newNode = new ListNode(list1.val, null);
            list1 = list1.next;
        }
        else
        {
            newNode = new ListNode(list2.val, null);
            list2 = list2.next;
        }
        
        newHead = newNode;
        prevNode = newNode;

        while(list1 != null || list2 != null)
        {
            if(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    newNode = new ListNode(list1.val, null);
                    list1 = list1.next;
                }
                else
                {
                    newNode = new ListNode(list2.val, null);
                    list2 = list2.next;
                }
            }
            else if(list2 == null)
            {
                newNode = new ListNode(list1.val, null);
                list1 = list1.next;
            }
            else
            {
                newNode = new ListNode(list2.val, null);
                list2 = list2.next;
            }

            prevNode.next = newNode;
            prevNode = newNode;
        }

        return newHead;
    }
}

/*

1. create new node
2. decide what other node must be linked to it
3. Assign to .next the reference of the other node
4. Link the new node to the previous node
5. Repeat until the end

1. Create the first node
2. 

*/
