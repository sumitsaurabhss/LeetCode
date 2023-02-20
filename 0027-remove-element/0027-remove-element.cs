public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int n = nums.Length;
        int i = 0, k = n-1;
        while(i <= k){
            if(nums[i] == val){
                (nums[i], nums[k]) = (nums[k], nums[i]);
                k--;
            }
            else  i++;
        }
        if(i-k >= 2)  return --i;
        return i;
    }
}