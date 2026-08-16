public class MovingAverage {
    double result = 0.0;
    int size = 0;
    Queue<int> queue = new Queue<int>();
    public MovingAverage(int size) {
        this.size = size;
    }

    public double Next(int val) {
        queue.Enqueue(val);
        result += val;
        if(queue.Count > size){
            var popped = queue.Dequeue();
            result -= popped;
        }

        return (double)result / queue.Count;
    }
}
