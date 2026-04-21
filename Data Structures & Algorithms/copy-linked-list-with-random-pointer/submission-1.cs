/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        
        if(head == null) return null;
        Node original = head;
        while(original != null){
            Node copie = new Node(original.val);
            map[original] = copie;

            original = original.next;
        }

        Node current = head;
        while(current != null){
            Node copie = map[current];
            copie.next = current.next != null ? map[current.next] : null;
            copie.random = current.random != null ? map[current.random] : null;

            current = current.next;
        }

        return map[head];
    }
}
