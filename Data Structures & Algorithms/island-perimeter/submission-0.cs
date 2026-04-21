public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int[] dr = {-1, 0, 1, 0};
        int[] dc = {0, 1, 0, -1};

        int count = 0;

        for(int i=0; i < grid.Length; i++){
            for(int j=0; j < grid[0].Length; j++){
                if(grid[i][j] == 1){
                    for (int d = 0; d < 4; d++) {
                        int newRow = i + dr[d];
                        int newCol = j + dc[d];
                        
                        // Vérifier si hors limites OU eau → périmètre++
                        if (newRow < 0 || newCol < 0 || 
                            newRow >= grid.Length || newCol >= grid[0].Length || grid[newRow][newCol] == 0)
                        count++;
                    }
                }
            }
        }

        return count;
    }
}