// Last updated: 12/11/2025, 8:00:25 PM
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
    SortedDictionary<int, SortedDictionary<int, IList<int>>> map;
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        map = new SortedDictionary<int, SortedDictionary<int, IList<int>>>();
        IList<IList<int>> result = new List<IList<int>>();
        DFS(root, 0, 0);
        foreach(var item in map)
        {
            //SelectMany is used to flatten the multiple values for the same column into single list and also order that each row list individually.
            result.Add(item.Value.Values.SelectMany(x=>x.OrderBy(v=>v)).ToList());
        }
        return result;
    }
    private void DFS(TreeNode node, int row, int col)
    {
        if(node == null)
        {
            return;
        }
        map.TryAdd(col, new SortedDictionary<int, IList<int>>());
        map[col].TryAdd(row, new List<int>());
        map[col][row].Add(node.val);
        DFS(node.left, row + 1, col - 1);
        DFS(node.right, row + 1, col + 1);
    }
}