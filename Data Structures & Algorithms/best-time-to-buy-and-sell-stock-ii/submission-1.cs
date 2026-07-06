public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n, 2];

        for (int i = 0; i < n; i++) {
            dp[i, 0] = -1;
            dp[i, 1] = -1;
        }

        return Rec(prices, 0, 0, dp);
    }

    private int Rec(int[] prices, int i, int bought, int[,] dp) {
        if (i == prices.Length) {
            return 0;
        }

        if (dp[i, bought] != -1) {
            return dp[i, bought];
        }

        int res = Rec(prices, i + 1, bought, dp);

        if (bought == 1) {
            res = Math.Max(res, prices[i] + Rec(prices, i + 1, 0, dp));
        } else {
            res = Math.Max(res, -prices[i] + Rec(prices, i + 1, 1, dp));
        }

        dp[i, bought] = res;
        return res;
    }
}