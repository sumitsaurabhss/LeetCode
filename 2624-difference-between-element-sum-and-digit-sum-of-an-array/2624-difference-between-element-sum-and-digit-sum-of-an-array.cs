public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int esum = 0, dsum = 0;
        foreach(int n in nums) {
            esum += n;
            int t = n;
            while(t > 0) {
                dsum += t % 10;
                t /= 10;
            }
        }
        return Math.Abs(esum - dsum);
    }
}