public class Solution {
    public int[] PlusOne(int[] digits) {
        int size = digits.Length - 1;

        for(int i = size; i >= 0; i--){
            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
