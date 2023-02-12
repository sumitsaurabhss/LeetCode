public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int mx = int.MaxValue, t = -1, d = 0;
        for(int i =0; i<points.GetLength(0); i++){
            if(points[i][0] == x || points[i][1] == y){
                d = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                if(d < mx){
                    mx = d;
                    t = i;
                }
            }
        }
        return t;
    }
}