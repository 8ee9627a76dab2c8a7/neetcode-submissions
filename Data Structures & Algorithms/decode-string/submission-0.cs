public class Solution {
    private int i;

    public string DecodeString(string s) {
        i = 0;
        return Helper(s);
    }

    private string Helper(string s) {
        string res = "";
        int k = 0;

        while (i < s.Length) {
            char c = s[i];

            if (char.IsDigit(c)) {
                k = k * 10 + (c - '0');
            } else if (c == '[') {
                i++;
                string inner = Helper(s);
                res += new string(' ', 0).PadLeft(0);
                for (int j = 0; j < k; j++) {
                    res += inner;
                }
                k = 0;
            } else if (c == ']') {
                return res;
            } else {
                res += c;
            }

            i++;
        }

        return res;
    }
}