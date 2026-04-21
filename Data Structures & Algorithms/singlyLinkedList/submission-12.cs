public class Node
{
    public int val;
    public int size;
    public Node next;
    public Node(int val)
    {
        this.val = val;
        this.next = null;
    }
}

public class LinkedList {

    public Node head;
    
    public int size;
    
    public LinkedList() {
        this.head = null;
        this.size = 0;
    }

    public Node getNode(int index)
    {
        int count = 0;
        Node current = head;
        while(current != null)
        {
            if(count == index)
            {
                return current;
            }
            current = current.next;
            count++;
        }

        return current;
    }

    public int Get(int index) 
    {
        int count = 0;
        Node current = head;
        while( current != null)
        {
            if(count == index)
            {
                return current.val;
            }
            current = current.next;
            count++;
        }

        return -1;
    }

    public void InsertHead(int val) 
    {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);
        if(head == null){
            this.head = newNode;
        }else{            
            var current = head;
            while(current.next != null){
                current = current.next;
            }

            current.next = newNode;
        }
    }

    public bool Remove(int index) {
        var currentNode = getNode(index);
        if (currentNode == null)
        {
            return false;
        }

        var prevNode = getNode(index - 1);

        if(prevNode != null)
        {
            prevNode.next = currentNode.next;
        }
        else
        {
            head = currentNode.next;
        }

        return true;
    }

    public List<int> GetValues() {
        List<int> res = new List<int>();
        Node curr = this.head;
        while(curr != null)
        {
            res.Add(curr.val);
            curr = curr.next;
        }
        return res;
    }
}