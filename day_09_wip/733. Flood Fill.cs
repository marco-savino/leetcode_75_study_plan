/*
An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.

You are also given three integers sr, sc, and color. You should perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with color.

Return the modified image after performing the flood fill.

 

Example 1:

Input: image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
Output: [[2,2,2],[2,2,0],[2,0,1]]
Explanation: From the center of the image with position (sr, sc) = (1, 1) (i.e., the red pixel), all pixels connected by a path of the same color as the starting pixel (i.e., the blue pixels) are colored with the new color.
Note the bottom corner is not colored 2, because it is not 4-directionally connected to the starting pixel.

Example 2:

Input: image = [[0,0,0],[0,0,0]], sr = 0, sc = 0, color = 0
Output: [[0,0,0],[0,0,0]]
Explanation: The starting pixel is already colored 0, so no changes are made to the image.

 

Constraints:

    m == image.length
    n == image[i].length
    1 <= m, n <= 50
    0 <= image[i][j], color < 216
    0 <= sr < m
    0 <= sc < n


*/


public class Solution17 {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        Console.WriteLine("Target color {0} becomes color {1}", image[sr][sc], color);
        recursiveFill(image, sr, sc, color, image[sr][sc]);

        return image;
    }

    private void recursiveFill(int[][] image, int sr, int sc, int newColor, int targetColor)
    {
        Console.WriteLine("Row {0}, Col {1}, Color {2}", sr, sc, image[sr][sc]);

        if(image[sr][sc] == targetColor && image[sr][sc] != newColor)
        {
            Console.WriteLine("Transform Row {0}, Col {1}, Color {2} in Color {3}", sr, sc, image[sr][sc], newColor);
            image[sr][sc] = newColor;

            if(sr > 0)
                recursiveFill(image, sr-1, sc, newColor, targetColor);

            if(sc > 0)
                recursiveFill(image, sr, sc-1, newColor, targetColor);

            if(sr < image.Count()-1)
                recursiveFill(image, sr+1, sc, newColor, targetColor);

            if(sc < image[0].Count()-1)
                recursiveFill(image, sr, sc+1, newColor, targetColor);  
        }   
    }
}