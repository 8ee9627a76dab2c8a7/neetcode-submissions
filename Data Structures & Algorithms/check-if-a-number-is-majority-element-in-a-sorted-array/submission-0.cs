public class Solution {
    public bool IsMajorityElement(int[] nums, int target) {
        int middle = nums.Length / 2;
        int count = 0;
        for(int i=0; i < nums.Length; i++){
            if(nums[i] == target){
                count++;
            }
        }

        if(count > middle){
            return true;
        }

        return false;
    }
}
