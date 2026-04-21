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
    public int GetHeight(TreeNode node){
        if (node == null)
        {
            return 0;
        }
        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);
        return 1 + Math.Max(leftHeight, rightHeight);
    }
    public bool IsBalanced(TreeNode root) {
        bool isBalanced = false;
        if(root == null){
            return true;
        }

        int diff = Math.Abs(GetHeight(root.left) - GetHeight(root.right));
        bool thisNodeBalanced = diff <= 1;

        return thisNodeBalanced && IsBalanced(root.left) && IsBalanced(root.right); 
    }
}
