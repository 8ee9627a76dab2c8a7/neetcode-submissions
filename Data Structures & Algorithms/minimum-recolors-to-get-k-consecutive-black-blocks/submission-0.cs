public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int res = blocks.Length;
        for (int i = 0; i <= blocks.Length - k; i++) {
            int count_w = 0;
            for (int j = i; j < i + k; j++) {
                if (blocks[j] == 'W') {
                    count_w++;
                }
            }
            res = Math.Min(res, count_w);
        }
        return res;
    }
}