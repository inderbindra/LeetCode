// Last updated: 12/11/2025, 8:02:53 PM
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
    int maxPathSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        FindPathSum(root);
        return maxPathSum;
    }

    private int FindPathSum(TreeNode node)
    {
        if(node == null)
        {
            return 0;
        }
        int leftSum = Math.Max(0, FindPathSum(node.left));
        int rightSum = Math.Max(0, FindPathSum(node.right));
        int pathSum = node.val + leftSum + rightSum;
        maxPathSum = Math.Max(maxPathSum, pathSum);
        return node.val + Math.Max(leftSum, rightSum);
    }
}