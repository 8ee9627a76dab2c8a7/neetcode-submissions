public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int n = nums.Length;
        int res = nums[0];

        for (int i = 0; i < n; i++) {
            int curSum = 0;
            for (int j = i; j < i + n; j++) {
                curSum += nums[j % n];
                res = Math.Max(res, curSum);
            }
        }

        return res;
    }
}