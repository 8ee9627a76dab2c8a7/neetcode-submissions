public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        int n = s.Length;
        int[] dp = new int[n+1];
        dp[n] = 0;
        for(int i = n -1; i >= 0; i--){
            dp[i] = 1 + dp[i+1];
            foreach(string word in dictionary) {
                // si word matche s[i..j]
                if(i + word.Length <= n){
                    string sub = s.Substring(i, word.Length);
                    if(sub == word) {
                        // que vaut j+1 en fonction de word.Length ?
                        dp[i] = Math.Min(dp[i], dp[i + word.Length]);
                    }
                } 
            }
        }

        return dp[0];
    }
}