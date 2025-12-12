// Last updated: 12/11/2025, 8:02:10 PM
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
    public int CountNodes(TreeNode root) {
        
        if(root == null)
        {
            return 0;
        }

        int lh = GetLeftHeight(root);
        int rh = GetRightHeight(root);

        if(lh == rh)
        {
            return (int)Math.Pow(2, lh) - 1;
        }

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }

    private int GetLeftHeight(TreeNode node)
    {
        if(node == null)
        {
            return 0;
        }
        return GetLeftHeight(node.left) + 1;
    }

    private int GetRightHeight(TreeNode node)
    {
        if(node == null)
        {
            return 0;
        }
        return GetRightHeight(node.right) + 1;
    }
}