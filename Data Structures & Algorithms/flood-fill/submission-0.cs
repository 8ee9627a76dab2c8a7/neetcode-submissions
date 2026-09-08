public class Solution {
    public static void dfs(int[][] image, int r, int c, int origColor, int newColor){
        if(r < 0 || r >= image.Length || c < 0 || c >= image[0].Length || image[r][c] != origColor){
            return ;
        }

         image[r][c] = newColor;
        dfs(image, (r-1), c, origColor, newColor);
        dfs(image, (r+1), c, origColor, newColor);
        dfs(image, r, (c - 1), origColor, newColor);
        dfs(image, r, (c + 1), origColor, newColor);

        return;

    }

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)  {
        // edge case 
        if(image[sr][sc] == color){
            return image;
        }

        dfs(image, sr, sc, image[sr][sc], color);

        return image;
        
    }
}