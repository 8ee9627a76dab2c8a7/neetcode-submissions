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
    public static int NodeDepthsHelper(TreeNode tree,
                                            ref int maxDiameter)
    {
        if(tree == null) return 0;

        int leftDepth = NodeDepthsHelper(tree.left, ref maxDiameter);
        int rightDepth = NodeDepthsHelper(tree.right, ref maxDiameter);

        int localDiameter = leftDepth + rightDepth;

        maxDiameter = Math.Max(maxDiameter, localDiameter);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxDiameter = 0;
        NodeDepthsHelper(root, ref maxDiameter);
        return maxDiameter;
    }
}
