public class MinHeap {
    private List<int> heap;

    public MinHeap() {
        heap = new List<int>();
    }

    public void Push(int val) {
        heap.Add(val);
        HeapifyUp(heap.Count - 1);
    }

    public int? Pop() {
        if (heap.Count == 0) return -1;
        int min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);
        return min;
    }

    public int? Top() {
        if (heap.Count == 0) return -1;
        return heap[0];
    }

    public void Heapify(List<int> nums) {
        heap = new List<int>(nums);
        int cur = (heap.Count - 1) / 2;
        while (cur >= 0) {
            HeapifyDown(cur);
            cur--;
        }
    }

    private void HeapifyUp(int index) {
        while (index > 0) {
            int parent = (index - 1) / 2;
            if (heap[index] >= heap[parent]) break;
            int temp = heap[index];
            heap[index] = heap[parent];
            heap[parent] = temp;
            index = parent;
        }
    }

    private void HeapifyDown(int index) {
        int smallest = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left < heap.Count && heap[left] < heap[smallest]) {
            smallest = left;
        }

        if (right < heap.Count && heap[right] < heap[smallest]) {
            smallest = right;
        }

        if (smallest != index) {
            int temp = heap[index];
            heap[index] = heap[smallest];
            heap[smallest] = temp;
            HeapifyDown(smallest);
        }
    }
}
