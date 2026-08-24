public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int n = word.Length, m = abbr.Length;
        int i = 0, j = 0;

        while (i < n && j < m) {
            if (abbr[j] == '0') return false;

            if (char.IsLetter(abbr[j])) {
                if (i < n && word[i] == abbr[j]) {
                    i++; j++;
                } else {
                    return false;
                }
            } else {
                int subLen = 0;
                while (j < m && char.IsDigit(abbr[j])) {
                    subLen = subLen * 10 + (abbr[j] - '0');
                    j++;
                }
                i += subLen;
            }
        }

        return i == n && j == m;
    }
}