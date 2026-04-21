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

    public bool isSubTreeHelper(TreeNode root, TreeNode subroot){
        if(root == null) return false;
        if(isSameTreeHelper(root, subroot)) return true;
        else {
            return isSubTreeHelper(root.left, subroot) || isSubTreeHelper(root.right, subroot);
        }
    }

    public bool isSameTreeHelper(TreeNode root, TreeNode subroot){
        if(root == null && subroot == null) return true;
        if(root == null || subroot == null) return false;

        if(root.val != subroot.val) return false;
        
        return isSameTreeHelper(root.left, subroot.left) && isSameTreeHelper(root.right, subroot.right);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return isSubTreeHelper(root, subRoot);
    }
}
