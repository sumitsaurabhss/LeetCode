public class Solution {
    public int[] RunningSum(int[] nums) {
        for(int i = 1; i < nums.Length; i++)  nums[i] += nums[i-1];
        //int n = nums.Length-1;
        //nums[n] = nums[n] + sum(ref nums, n-1);
        return nums;
    }
    
   /* public int sum(ref int[] nums, int n) {
        if(n == 0)  return nums[0];
        nums[n] = nums[n] + sum(ref nums, n-1);
        return nums[n];
    }*/
}