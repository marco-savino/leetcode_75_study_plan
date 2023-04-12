/*
Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

    The left
    subtree
    of a node contains only nodes with keys less than the node's key.
    The right subtree of a node contains only nodes with keys greater than the node's key.
    Both the left and right subtrees must also be binary search trees.

 

Example 1:

Input: root = [2,1,3]
Output: true

Example 2:

Input: root = [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.

 

Constraints:

    The number of nodes in the tree is in the range [1, 104].
    -231 <= Node.val <= 231 - 1


*/

public class Solution15 {
    public bool IsValidBST(TreeNode root) 
    {
        return IsValidBSTRecursive(root, int.MinValue, int.MaxValue);
    }

    private bool IsValidBSTRecursive(TreeNode root, int lowerLimit, int upperLimit)  // this does not work in limit cases
    {
        if(root == null)
            return true;

        if(root.val <= lowerLimit || root.val >= upperLimit)
            return false;

        /*
        If I go right, then the lower limit is now the last node value,
        while if I go left, the upper limit is the last node value
        */
        return IsValidBSTRecursive(root.right, root.val, upperLimit) && IsValidBSTRecursive(root.left, lowerLimit, root.val);
        
    }
}