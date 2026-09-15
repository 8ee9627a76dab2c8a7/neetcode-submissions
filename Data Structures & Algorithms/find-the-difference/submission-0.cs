public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] countS = new int[26];
        int[] countT = new int[26];

        foreach (char c in s) countS[c - 'a']++;
        foreach (char c in t) countT[c - 'a']++;

        for (int i = 0; i < 26; i++) {
            if (countT[i] > countS[i]) {
                return (char)(i + 'a');
            }
        }
        return ' ';
    }
}