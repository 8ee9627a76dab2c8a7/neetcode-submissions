public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        int left = 0;
        int right = nums.Length-1;
        int pos = nums.Length-1;

        while(left <= right){
            if(Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[pos] = nums[left] * nums[left];
                left++;
            } else
            {
                result[pos] = nums[right] * nums[right];
                right--;
            }

            pos--;
        }

        return result;
    }
}