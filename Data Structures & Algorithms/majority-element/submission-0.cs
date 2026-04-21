public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new();
        for(int i=0; i < nums.Length; i++){
            dict.TryGetValue(nums[i], out int count);
            dict[nums[i]] = count + 1;
            if(dict[nums[i]] > nums.Length / 2){
                return nums[i];
            }
        }

        return -1;
    }
}