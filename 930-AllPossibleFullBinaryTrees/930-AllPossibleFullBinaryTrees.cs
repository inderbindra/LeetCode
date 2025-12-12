// Last updated: 12/11/2025, 8:00:30 PM
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
    Dictionary<int, IList<TreeNode>> dp;
    public IList<TreeNode> AllPossibleFBT(int n) {
        dp = new();
        return Solve(n);
    }
    private IList<TreeNode> Solve(int n)
    {
        IList<TreeNode> result = new List<TreeNode>();
        if(n%2 == 0)
        {
            return new List<TreeNode>();
        }
        if(n == 1)
        {
            return new List<TreeNode>{new TreeNode()};
        }
        // This condition is added to avoid cycle in tree for the case same number of nodes are present in both sides
        if(dp.ContainsKey(n) && n!= (n-1/2))
        {
            return dp[n];
        }
        for(int l=1; l<n; l+=2)
        {
            var left = Solve(l);
            var right = Solve(n-l-1);
            
            foreach(var lNode in left)
            {
                foreach(var rNode in right)
                {
                    var root = new TreeNode(0);
                    root.left = lNode;
                    root.right = rNode;
                    result.Add(root);
                }
            }
        }
        dp[n] = result;
        return result;
    }
}