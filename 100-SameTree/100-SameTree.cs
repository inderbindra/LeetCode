// Last updated: 1/14/2026, 8:00:58 PM
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
15    public bool IsSameTree(TreeNode p, TreeNode q) {
16        if(p == null && q == null)
17        {
18            return true;
19        }
20        if(p != null && q != null && p.val == q.val)
21        {
22            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
23        }
24        return false;
25    }
26}