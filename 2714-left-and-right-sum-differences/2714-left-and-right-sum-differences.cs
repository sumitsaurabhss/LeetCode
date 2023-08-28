public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length;
        //int[] ans = new int[n];
        int sum = nums.Sum();
        int pre = 0;
        for(int i = 0; i < n; i++) {
            pre += nums[i] * 2;
            nums[i] = Math.Abs(sum - (pre - nums[i]));
        }
        return nums;
    }
}