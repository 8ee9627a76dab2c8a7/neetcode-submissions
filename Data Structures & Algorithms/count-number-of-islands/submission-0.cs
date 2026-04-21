public class Solution {

    public void dfs(int i, int j, char[][] grid)
    {

        int[] dx = new int[] { 1, -1, 0, 0};
        int[] dy = new int[] { 0, 0, -1, 1};

        if( i < 0  || i >= grid.Length || j < 0 || j >= grid[0].Length){
            return;
        }

        if(grid[i][j] == '0'){
            return;
        }

        grid[i][j] = '0';

        for(int k=0; k < 4; k++){
            var newX = (i + dx[k]);
            var newY = (j + dy[k]);
            dfs(newX, newY, grid);
        }
    }

    public int NumIslands(char[][] grid) {
        int count = 0;

        for(int i=0; i < grid.Length; i++){
            for(int j=0; j < grid[0].Length; j++){
                if(grid[i][j] == '1'){
                    dfs(i, j, grid);
                    count++;
                }
            }
        }

        return count;
    }
}
