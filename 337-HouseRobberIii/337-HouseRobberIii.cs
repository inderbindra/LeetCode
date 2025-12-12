// Last updated: 12/11/2025, 8:01:49 PM
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
    public int Rob(TreeNode root) {
        var pair = DFS(root);
        return Math.Max(pair.valWithRoot, pair.valWithoutRoot);
    }
    private (int valWithRoot, int valWithoutRoot) DFS(TreeNode root)
    {
        if(root == null)
        {
            return (0, 0);
        }
        // Pair(WithRoot, WithoutRoot)
        var leftPair = DFS(root.left);
        var rightPair = DFS(root.right);

        int withRoot = root.val + leftPair.valWithoutRoot + rightPair.valWithoutRoot;
        // In this case since we are not including the root, we don't have any other restriction, that's why we taking the max of both pairs and adding them.
        int withoutRoot = Math.Max(leftPair.valWithRoot, leftPair.valWithoutRoot) + Math.Max(rightPair.valWithRoot, rightPair.valWithoutRoot);
        return (withRoot, withoutRoot);
    }
}