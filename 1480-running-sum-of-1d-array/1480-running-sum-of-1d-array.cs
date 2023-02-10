public class Solution {
    public int[] RunningSum(int[] nums) {
        int n = nums.Length-1;
        //for(int i = 1; i < n; i++)  nums[i] += nums[i-1];  //Iterative Solution
        nums[n] = nums[n] + sum(ref nums, n-1);   // Recursive Solution
        return nums;
    }
    
    public int sum(ref int[] nums, int n) {
        if(n == 0)  return nums[0];
        nums[n] = nums[n] + sum(ref nums, n-1);
        return nums[n];
    }
}