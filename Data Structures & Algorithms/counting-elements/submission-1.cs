public class Solution {
    public int CountElements(int[] arr) {
        int count = 0;
        HashSet<int> seen = new HashSet<int>();
        for(int i=0; i <= arr.Length-1; i++){
            if(! seen.Contains(arr[i])){
                seen.Add(arr[i]);
            }

        }

        for(int j = 0; j < arr.Length; j++){
            if(seen.Contains(arr[j] + 1)){
                count++;
            }
        }

        return count;
    }
}
