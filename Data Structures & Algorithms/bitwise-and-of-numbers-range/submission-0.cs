public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int shiftCount = 0;

        while(left != right){
            left = left >> 1;
            right = right >> 1;
            shiftCount++;
        }

        return (left << shiftCount);
    }
}