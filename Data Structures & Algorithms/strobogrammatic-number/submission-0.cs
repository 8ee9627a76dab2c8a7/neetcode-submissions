public class Solution {
    public bool IsStrobogrammatic(string num) {
        Dictionary<char, char> rotatedDigits = new Dictionary<char, char> {
            {'0', '0'}, {'1', '1'}, {'6', '9'}, {'8', '8'}, {'9', '6'}
        };

        for (int left = 0, right = num.Length - 1; left <= right; left++, right--) {
            char leftChar = num[left];
            char rightChar = num[right];
            if (!rotatedDigits.ContainsKey(leftChar) || rotatedDigits[leftChar] != rightChar) {
                return false;
            }
        }

        return true;
    }
}
