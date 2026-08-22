public class KthLargest {
    PriorityQueue<int, int> minHeap;
    private int k;
    public KthLargest(int k, int[] nums) {
        minHeap = new PriorityQueue<int,int>();
        this.k = k;
        foreach(var num in nums){
            Add(num);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val,val);
        if(minHeap.Count > k){
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}
