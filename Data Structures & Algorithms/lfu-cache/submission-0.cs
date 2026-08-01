public class LFUCache {
    private readonly Dictionary<int, Node> cache;
    private readonly int capacity;
    private int minFreq;
    private readonly Dictionary<int, FreqBucket> buckets;
    public LFUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>(capacity);
        buckets = new Dictionary<int, FreqBucket>();
    }
    
    public int Get(int key) {
        if(! cache.TryGetValue(key, out Node node)){
            return -1;
        }

        IncrementFreq(node);

        return node.Val;
    }
    
    public void Put(int key, int value) {

        if(capacity == 0){
            return;
        }

        if (cache.TryGetValue(key, out Node existing)) {
            existing.Val = value;
            IncrementFreq(existing);
            return;
        }

        if(cache.Count == capacity){
            var evicted = buckets[minFreq].PopOldest();
            cache.Remove(evicted.Key);
        }

        Node newNode = new Node(key, value);
        cache[key] = newNode;

        if(! buckets.TryGetValue(newNode.Freq, out FreqBucket next)){
          next = new FreqBucket();
          buckets[newNode.Freq] = next;             
        } 
        next.Insert(newNode);
        minFreq = newNode.Freq;
    }

    private void IncrementFreq(Node node){
        var current = buckets[node.Freq];
        current.Remove(node);
        if(current.IsEmpty && node.Freq == minFreq){
            minFreq = minFreq + 1;
        }
        node.Freq++; 
        if(! buckets.TryGetValue(node.Freq, out FreqBucket next)){
          next = new FreqBucket();
          buckets[node.Freq] = next;             
        } 
        next.Insert(node);
    }
}

public class Node {
    public int Key { get;  }
    public int Val { get; set; }
    public Node Next { get; set; }
    public Node Prev { get; set; }
    public int Freq { get; set; }
    public Node(int key, int val) { Key = key; Val = val; Freq = 1; }   
}


public class FreqBucket {
    private Node left;
    private Node right;

    public FreqBucket(){
        left = new Node(0,0);
        right = new Node(0,0);
        left.Next = right;
        right.Prev = left;
    }

     public void Remove(Node node) {
        Node prev = node.Prev;
        Node nxt = node.Next;
        prev.Next = nxt;
        nxt.Prev = prev;
    }

    public void Insert(Node node) {
        Node prev = right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = right;
        right.Prev = node;
    }

    public bool IsEmpty => left.Next == right;

    public Node PopOldest(){
        Node evict = left.Next;
        Remove(evict);
        return evict;
    }

}
/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */