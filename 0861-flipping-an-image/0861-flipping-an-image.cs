public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int size = image.Length;
        for(int i = 0; i < size; i++) {
            int l = 0, r = image[i].Length-1, t = 0;
            while(l < r) {
                t = image[i][l];
                image[i][l] = 1 - image[i][r];
                image[i][r] = 1 - t;
                l++;
                r--;
            }
            if(l == r)
                image[i][l] = 1 - image[i][l];
        }
        return image;
    }
}