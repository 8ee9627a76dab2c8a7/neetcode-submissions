public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        dict[0] = 1;
        int curr = 0;
        int ans = 0;

        foreach(var num in nums){
            curr += num;
            int target = curr - k;
            ans += dict.GetValueOrDefault(target, 0);
            dict[curr] = dict.GetValueOrDefault(curr, 0) + 1;
        }

        return ans;
    }
}