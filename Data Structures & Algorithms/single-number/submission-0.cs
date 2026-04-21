public class Solution {
    public int SingleNumber(int[] nums) {
        int bitwise = 0;
        for(int i=0; i < nums.Length; i++){
            bitwise ^= nums[i];            
        }
        return bitwise;
    }
}
