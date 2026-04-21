public class MyCircularQueue {
    private int[] arr;
    private int front;
    private int size;
    private int capacity;
    public MyCircularQueue(int k) {
        capacity = k;
        arr = new int[capacity];
        front = 0;
        size = 0;
    }
    
    public bool EnQueue(int value) {
        if(capacity == size) return false;
        int rear = (front + size) % capacity;
        arr[rear] = value;
        size++;
        return true;
    }
    
    public bool DeQueue() {
        if( size == 0 ) return false;
        int val = arr[front];
        front = (front + 1) % capacity;
        size--;
        return true;
    }
    
    public int Front() {
        if(IsEmpty()) return -1;
        return arr[front];
    }
    
    public int Rear() {
        if(IsEmpty()) return -1;
        int rear = (front + size - 1) % capacity;
        return arr[rear];
    }
    
    public bool IsEmpty() {
        return size == 0 ? true : false;
    }
    
    public bool IsFull() {
        return size == capacity;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */