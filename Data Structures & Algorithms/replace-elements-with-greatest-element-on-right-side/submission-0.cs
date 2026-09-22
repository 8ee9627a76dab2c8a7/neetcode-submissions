public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++) {
            int rightMax = -1;
            for (int j = i + 1; j < n; j++) {
                rightMax = Math.Max(rightMax, arr[j]);
            }
            ans[i] = rightMax;
        }
        return ans;
    }
}