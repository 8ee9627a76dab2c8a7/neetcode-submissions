/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {

    public static void PostOrderTraversal(Node current, List<int> result){
        if(current.children != null){
            foreach(var child in current.children){
            PostOrderTraversal(child, result);
        }
        }
        

        result.Add(current.val);

    }

    public List<int> Postorder(Node root) {
        List<int> result = new List<int>();
        if(root == null){
            return new List<int>();
        }

        PostOrderTraversal(root, result);
        return result;
    }
}