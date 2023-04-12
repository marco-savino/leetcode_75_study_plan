/*
Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

 

Example 1:

Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.

Example 2:

Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
Output: 2
Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.

Example 3:

Input: root = [2,1], p = 2, q = 1
Output: 2

 

Constraints:

    The number of nodes in the tree is in the range [2, 105].
    -109 <= Node.val <= 109
    All Node.val are unique.
    p != q
    p and q will exist in the BST.


*/

class Solution16 {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        List<TreeNode> treePathP = new List<TreeNode>();
        List<TreeNode> treePathQ = new List<TreeNode>();
        TreeNode commonAncestor = null;

        treePathP = findTreePath(root, p);
        treePathQ = findTreePath(root, q);

        treePathP.Reverse();
        treePathQ.Reverse();

        treePathP.ForEach(x => Console.WriteLine("P: {0}", x.val));
        treePathQ.ForEach(x => Console.WriteLine("Q: {0}", x.val));

        for(int i=0; i<treePathP.Count && i<treePathQ.Count; i++)
        {
            if(treePathP[i].val == treePathQ[i].val)
                commonAncestor = treePathP[i];
            else
                return commonAncestor;
        }

        return commonAncestor;
    }

    private List<TreeNode> findTreePath(TreeNode root, TreeNode t)
    {
        List<TreeNode> treePath = new List<TreeNode>();
        List<TreeNode> tempTreePath = new List<TreeNode>();

        if(root.val == t.val)
        {
            treePath.Add(root);
            return treePath;
        }
        else
        {
            if(root.left != null)
            {
                tempTreePath = findTreePath(root.left, t);
                if(tempTreePath.Contains(t))
                    treePath = treePath.Concat(tempTreePath).ToList();
            }

            if(root.right != null)
            {
                tempTreePath = findTreePath(root.right, t);
                if(tempTreePath.Contains(t))
                    treePath = treePath.Concat(tempTreePath).ToList();
            }
                
        }

        treePath.Add(root);

        return treePath;
    }
}