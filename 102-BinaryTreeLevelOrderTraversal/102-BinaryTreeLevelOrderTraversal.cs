// Last updated: 1/15/2026, 3:32:41 PM
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
15    public IList<IList<int>> LevelOrder(TreeNode root) {
16        IList<IList<int>> result = new List<IList<int>>();
17        if(root != null)
18        {
19            Queue<TreeNode> queue = new();
20            int queueLength =0;
21            queue.Enqueue(root);
22
23            TreeNode node;
24            while(queue.Count > 0)
25            {
26                queueLength = queue.Count;
27                List<int> list = new();
28                for(int i=0; i<queueLength; i++)
29                {
30                    node = queue.Dequeue();
31                    list.Add(node.val);
32
33                    if(node.left != null)
34                    {
35                        queue.Enqueue(node.left);
36                    }
37                    if(node.right != null)
38                    {
39                        queue.Enqueue(node.right);
40                    }
41                }
42                result.Add(list);
43            }
44        }
45        return result;
46    }
47}