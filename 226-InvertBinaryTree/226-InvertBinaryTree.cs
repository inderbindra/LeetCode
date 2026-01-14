// Last updated: 1/14/2026, 4:33:59 PM
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
15    public TreeNode InvertTree(TreeNode root) {
16        if(root == null)    
17        {
18            return null;
19        }
20        TreeNode left = InvertTree(root.left);
21        TreeNode right = InvertTree(root.right);
22        root.left = right;
23        root.right = left;
24        return root;
25    }
26
27
28}