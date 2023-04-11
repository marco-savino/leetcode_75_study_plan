/*
Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]

Example 2:

Input: root = [1]
Output: [[1]]

Example 3:

Input: root = []
Output: []

 

Constraints:

    The number of nodes in the tree is in the range [0, 2000].
    -1000 <= Node.val <= 1000

*/

public class Solution12 {
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        IList<IList<int>> res = new List<IList<int>>();
        int nodesInCurrentLevel;

        if(root == null)
            return res;

        q.Enqueue(root);

        while(q.Count != 0)
        {
            nodesInCurrentLevel = q.Count;
            List<int> currLevel = new List<int>();

            for(int i=0; i<nodesInCurrentLevel; i++)
            {
                if(q.Peek().left != null)
                    q.Enqueue(q.Peek().left);

                if(q.Peek().right != null)
                    q.Enqueue(q.Peek().right);

                currLevel.Add(q.Dequeue().val);
            }

            res.Add(currLevel);
        }

        return res;
    }
}

