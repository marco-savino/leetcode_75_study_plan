public class Solution15b {
    public bool IsValidBST(TreeNode root) 
    {
        return IsValidBSTRecursive(root, int.MaxValue, true) && IsValidBSTRecursive(root, int.MinValue, false);
    }

    private bool IsValidBSTRecursive(TreeNode root, int val, bool fromLeft)    
    {
        bool isValidLeft = true, isValidRight = true;

        if(root == null)
            return true;
        else
        {
            if(fromLeft)
            {
                if(root.left != null)
                {
                    if(root.left.val < root.val && root.left.val < val)
                    {
                        isValidLeft = IsValidBSTRecursive(root.left, root.val, true);
                    }    
                    else
                        isValidLeft = false;
                }
                
                if(root.right != null)
                {
                    if(root.right.val > root.val && root.right.val < val)
                    {
                        isValidRight = IsValidBSTRecursive(root.right, root.val, false);
                    }   
                    else
                        isValidRight = false;
                }
            }
            else
            {
                if(root.left != null)
                {
                    if(root.left.val < root.val && root.left.val > val)
                    {
                        isValidLeft = IsValidBSTRecursive(root.left, root.val, true);
                    }    
                    else
                        isValidLeft = false;
                }
                
                if(root.right != null)
                {
                    if(root.right.val > root.val && root.right.val > val)
                    {
                        isValidRight = IsValidBSTRecursive(root.right, root.val, false);
                    }   
                    else
                        isValidRight = false;
                }
            }
            
        }

        return isValidLeft && isValidRight;
    }
}