public class DynamicArray {

    private int[] _array;
    private int _capacity;
    private int _size;
    
    public DynamicArray(int capacity) {
        _capacity = capacity;
        _size = 0;
        _array = new int[_capacity];
    }

    public int Get(int i) {
        return _array[i];
    }

    public void Set(int i, int n) {
        _array[i] = n;
    }

    public void PushBack(int n) {
        if(_size == _capacity){
            Resize();
        }

        _array[_size] = n;
        _size++;
    }

    public int PopBack() {
        _size--;        
        return _array[_size];
    }

    private void Resize() {
        _capacity = 2 * _capacity;
        var newArray = new int[_capacity];
        _array.CopyTo(newArray, 0);
        _array = newArray;

    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
