public class Solution {
    public int LargestUniqueNumber(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = -1;
        foreach(var num in nums){
            if(dict.TryGetValue(num, out int n)){
                dict[num] += 1; 
            } else {
                dict[num] = 1;
            }
        }

        foreach(var (num, count)  in dict){
            if(count == 1){
                result = Math.Max(num, result);
            }
        }

        return result;
    }
}
