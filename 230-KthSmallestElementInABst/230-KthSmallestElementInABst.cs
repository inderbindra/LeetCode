// Last updated: 12/11/2025, 8:02:07 PM
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
    int count=0, val=0;
    public int KthSmallest(TreeNode root, int k) {
        InOrderTraversal(root, k);
        return val;
    }
    private void InOrderTraversal(TreeNode root, int k)
    {
        if(root == null)
        {
            return;
        }
        InOrderTraversal(root.left, k);
        count++;
        if(count == k)
        {
            val = root.val;
            return;
        }
        InOrderTraversal(root.right, k);
    }
}