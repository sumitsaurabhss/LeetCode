public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int h = mat.Length, w = mat[0].Length;
        if(h*w != r*c)  return mat;
        int[][] m = new int[r][];
        for(int i=0; i<r; i++)  m[i] = new int[c];
        int x=0, y=0;
        for(int i=0; i<h; i++){
            for(int j=0; j<w; j++){
                m[x][y] = mat[i][j];
                y++;
                if(y >= c){
                    y = 0;
                    x++;
                }
            }
        }
        return m;
    }
}