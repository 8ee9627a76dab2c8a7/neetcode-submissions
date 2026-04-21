public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int row, int col)> queue = new Queue<(int, int)>();
        int R = grid.Length;
        int C = grid[0].Length;

        int[] dr = { -1, 0, 1, 0 };
        int[] dc = { 0, 1, 0, -1 };


        for (int i = 0; i < R; i++){
            for (int j = 0; j < C; j++){
                if(grid[i][j] == 0){
                    queue.Enqueue((i, j));
                }               
            }                
        }


        while(queue.Count > 0){
            var (r, c) = queue.Dequeue();

            for (int d = 0; d < 4; d++)
            {
                int row = r + dr[d];
                int col = c + dc[d];
                
                if (row >= 0 && row < R && col >= 0 && col < C)
                {
                    if(grid[row][col] == int.MaxValue)
                    {
                        grid[row][col] = grid[r][c] + 1;
                        queue.Enqueue((row, col));
                    }
                }
            }

        }
    }
}
