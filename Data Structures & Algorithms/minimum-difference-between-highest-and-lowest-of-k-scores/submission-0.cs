public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int diff = int.MaxValue;
        for(int i=0; i + k -1 < nums.Length; i++){
            int minimum = nums[i];
            int maximum = nums[i + k -1];

            diff = Math.Min(diff, maximum - minimum);;
        }

        return diff;
    }
}