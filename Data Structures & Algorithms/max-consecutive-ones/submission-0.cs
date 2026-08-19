public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count=0;
        int maxCount = 0;
        for(int i=0; i < nums.Length; i++){
            if(nums[i] == 0){
                count = 0;                
            } else{
                count++;
                        if(count > maxCount){
            maxCount = count;
        }
            }
        }

        return maxCount;
    }
}