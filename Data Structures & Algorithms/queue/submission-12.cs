public class Node
{
    public int val;
    public Node prev;
    public Node next;
    public Node(int val)
    {
        this.val = val;
        this.next = null;
        this.prev = null;
    }
}


class Deque {

    private Node dummyHead;
    private Node dummyTail;

    public Deque() {
        this.dummyHead = new Node(0);
        this.dummyTail = new Node(0);

        this.dummyHead.next = this.dummyTail;
        this.dummyTail.prev = this.dummyHead;
    }

    public bool isEmpty() {
        return this.dummyHead.next == this.dummyTail ? true : false;
    }

    public void append(int value) {
        Node newNode = new Node(value);
        if(this.isEmpty()){
            this.dummyHead.next = newNode;
            this.dummyTail.prev = newNode;
        }
        else{
            Node lastNode = this.dummyTail.prev;
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        
        newNode.next = this.dummyTail;
        this.dummyTail.prev = newNode;

    }

    // equivalent of append at head
    public void appendleft(int value) {
        Node newNode = new Node(value);
        if(this.isEmpty()){
            this.dummyHead.next = newNode;
            this.dummyTail.prev = newNode;
        }
        else{
            Node firstNode = this.dummyHead.next;
            firstNode.prev = newNode;
            newNode.next = firstNode;
            newNode.prev = this.dummyHead;
            this.dummyHead.next = newNode;           
        }
                
        
    }

    public int pop() {
        if(isEmpty()){
            return -1;
        }else{
            Node lastNode = this.dummyTail.prev;
            if(lastNode != null){
                Node prevNode = lastNode.prev;

                if(prevNode != null){
                    prevNode.next = this.dummyTail;
                    this.dummyTail.prev = prevNode;
                }
                else{
                    this.dummyHead.next = this.dummyTail;
                    this.dummyTail.prev = this.dummyHead;
                }
            }
            
            return lastNode.val;   
        }
    }

    // equivalent of remove at head
    public int popleft() {
        if(isEmpty()){
            return -1;
        }else{
            Node firstNode = this.dummyHead.next;
            this.dummyHead.next = firstNode.next;
            if(firstNode.next != null){
                firstNode.next.prev = this.dummyHead;
                
            }else{
                this.dummyHead.next = this.dummyTail;
                this.dummyTail.prev = this.dummyHead;
            }

            return firstNode.val;             
        }
        
    }
}
