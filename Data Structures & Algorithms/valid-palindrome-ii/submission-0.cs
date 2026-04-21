public class Solution {
    public static bool IsPalindrome(string s, int left, int right)
    {

        while(left <= right){
            if(s[left] == s[right]){
                left++;
                right--;
            } else {
                return false;
            }
        }

        return true;
    }

    public bool ValidPalindrome(string s) {
        bool isPalindrome = false;

        int left = 0;
        int right = s.Length -1;

        while(left < right)
        {
            if(s[left] == s[right]){
                left++;
                right--;
            } else {
                if(IsPalindrome(s, left + 1, right)){
                    return true;
                }

                if(IsPalindrome(s, left , right - 1)){
                    return true;
                }

                return isPalindrome;
            }
        }        

        return true;
    }
}