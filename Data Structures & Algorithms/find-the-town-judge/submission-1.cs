public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int[] score = new int[n + 1];
        for(int i=0; i < trust.Length; i++){
            int a = trust[i][0]; // 1
            int b = trust[i][1]; // 3

            score[a]--;
            score[b]++;
        }

        for(int i=1; i < score.Length; i++){
            if(score[i] == n-1) return i;
        }

        return -1;
    }
}