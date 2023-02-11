public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] r = new int[2]{0,0};
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    r[0] = i;
                    r[1]= j;
                }
            }
        }
        return r;
    }
}