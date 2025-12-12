// Last updated: 12/11/2025, 8:00:03 PM
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
    public int GoodNodes(TreeNode root) {
        return DFS(root, root.val);
    }
    private int DFS(TreeNode root, int prevMaxVal)
    {
        if(root == null)
        {
            return 0;
        }
        int goodNodes = 0;
        if(root.val >= prevMaxVal)
        {
            prevMaxVal = root.val;
            goodNodes++;
        }
        int left = DFS(root.left, prevMaxVal);
        int right = DFS(root.right, prevMaxVal);
        goodNodes += left + right;
        return goodNodes;
    }
}