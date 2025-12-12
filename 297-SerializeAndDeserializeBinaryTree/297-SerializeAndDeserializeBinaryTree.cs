// Last updated: 12/11/2025, 8:01:56 PM
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        StringBuilder str = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int queueLength = 0;
        TreeNode node;
        while(queue.Count > 0)
        {
            queueLength = queue.Count;
            for(int i=0; i<queueLength; i++)
            {
                node = queue.Dequeue();
                str.Append(node != null ? node.val: "");
                str.Append(",");
                if(node != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
        }
        return str.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        //Console.WriteLine("Data = " + data);
        string[] nodes = data.Split(',');
        TreeNode root = null;
        if(!string.IsNullOrWhiteSpace(nodes[0]))
        {
            root = new TreeNode(Convert.ToInt32(nodes[0]));
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            TreeNode node;
            for(int i=1; i<nodes.Length; i+=2)
            {
                if(queue.Count > 0)
                {
                    node = queue.Dequeue();
                    if(!string.IsNullOrWhiteSpace(nodes[i]))
                    {
                        node.left = new TreeNode(Convert.ToInt32(nodes[i]));
                        queue.Enqueue(node.left);
                    }
                    if(!string.IsNullOrWhiteSpace(nodes[i+1]))
                    {
                        node.right = new TreeNode(Convert.ToInt32(nodes[i+1]));
                        queue.Enqueue(node.right);
                    }
                }
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));