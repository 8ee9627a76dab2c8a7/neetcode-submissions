public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;
        int[][] res = new int[COLS][];

        for (int i = 0; i < COLS; i++) {
            res[i] = new int[ROWS];
        }

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                res[c][r] = matrix[r][c];
            }
        }

        return res;
    }
}