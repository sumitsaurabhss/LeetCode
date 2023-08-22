public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int n = nums.Length;
        int i=0, j=1;
        while(j < n) {
            if(nums[j] % 2 == 0) {
                if(nums[i] % 2 == 1) {
                    int t = nums[j];
                    nums[j] = nums[i];
                    nums[i] = t;
                    i++;
                    j++;
                }
                else if(i < j)
                    i++;
                else
                    j++;
            }
            else {
                j++;
            }
        }
        return nums;
    }
}