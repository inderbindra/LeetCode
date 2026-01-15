// Last updated: 1/15/2026, 5:23:19 PM
1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
8 *         this.val = val;
9 *         this.left = left;
10 *         this.right = right;
11 *     }
12 * }
13 */
14public class Solution {
15    public bool IsValidBST(TreeNode root) {
16        return IsValidBST(root, long.MinValue, long.MaxValue);
17    }
18    private bool IsValidBST(TreeNode node, long minVal, long maxVal)
19    {
20        if(node == null)
21        {
22            return true;
23        }
24        if(node.val > minVal && node.val < maxVal)
25        {
26            return IsValidBST(node.left, minVal, node.val) && IsValidBST(node.right, node.val, maxVal);
27        }
28        return false;
29    }
30}