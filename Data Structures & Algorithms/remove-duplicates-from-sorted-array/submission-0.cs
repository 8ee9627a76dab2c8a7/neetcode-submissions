public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int L = 1;
        int R = nums.Length -1;
        for(int i=1; i <= R; i++){
            if(nums[i] != nums[i - 1]){
                nums[L] = nums[i];
                L++;
            }
        }

        return L;
    }
}