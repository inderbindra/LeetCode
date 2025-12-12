// Last updated: 12/11/2025, 8:00:57 PM
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot == null)
        {
            return true;
        }
        if(root == null)
        {
            return false;
        }
        if(root.val == subRoot.val && IsSameTree(root, subRoot))
        {
            return true;
        }
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    private bool IsSameTree(TreeNode root, TreeNode subRoot)
    {
        if(root == null && subRoot == null)
        {
            return true;
        }
        if(root == null || subRoot == null)
        {
            return false;
        }
        if(root.val == subRoot.val)
        {
            return IsSameTree(root.left, subRoot.left) && IsSameTree(root.right, subRoot.right);
        }
        return false;
    }
}