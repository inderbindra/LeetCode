// Last updated: 1/14/2026, 7:50:14 PM
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
15    public int MaxDepth(TreeNode root) {
16        if(root == null)
17        {
18            return 0;
19        }
20
21        int left = MaxDepth(root.left);
22        int right = MaxDepth(root.right);
23        int depth = 1 + Math.Max(left, right);
24        return depth;
25    }
26}