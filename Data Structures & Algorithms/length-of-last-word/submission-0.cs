public class Solution {
    public int LengthOfLastWord(string s) {
        var array = s.Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
        var lastWord = array[array.Length -1];
        return lastWord.Length;
    }
}