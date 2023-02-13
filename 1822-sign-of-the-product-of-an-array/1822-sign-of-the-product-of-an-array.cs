public class Solution {
    public int ArraySign(int[] nums) {
        int p = 1;
        foreach(int i in nums) {
            if(i<0) p *= -1;
            else if(i == 0)  return 0;
            }
        return p;
    }
}