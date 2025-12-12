// Last updated: 12/11/2025, 8:02:26 PM
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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> result = new List<int>();
        if(root != null)
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            int queueLength=0;
            TreeNode node;
            bool flag = true;
            while(queue.Count > 0)
            {
                queueLength = queue.Count;
                flag = true;
                for(int i=0; i<queueLength; i++)
                {
                    node = queue.Dequeue();
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(flag)
                    {
                        result.Add(node.val);
                        flag = false;
                    }
                }
            }
        }
        return result;
    }
}