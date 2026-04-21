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

    public int dfs(TreeNode node, int maxActuel)
    {
        if(node == null){
            return 0;
        }

        int count = 0;

        if(node.val >= maxActuel){
            count = 1;
            maxActuel = node.val;
        }

        count += dfs(node.left, maxActuel);
        count += dfs(node.right, maxActuel);

        return count;
    }

    public int GoodNodes(TreeNode root) {
        
        return dfs(root, root.val);

    }
}
