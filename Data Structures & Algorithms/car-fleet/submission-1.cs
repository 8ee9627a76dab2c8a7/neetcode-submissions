public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<double> _outStack = new Stack<double>();
        int n = position.Length;
        var cars = new (int position, double time)[n];
        for(int i=0; i<n; i++)
        {
            double time = (double)(target - position[i]) / speed[i];
            cars[i] = (position[i], time);
        }

        Array.Sort(cars, (a, b) => b.position.CompareTo(a.position));
        foreach(var car in cars){
            if (_outStack.Count == 0 || car.time > _outStack.Peek()) {
                _outStack.Push(car.time);
            }
        }

        return _outStack.Count;
    }
}
