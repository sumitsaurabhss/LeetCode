public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length -1;
        int index = right;
        int[] result = new int [nums.Length];
        while(left<=right)
        {
            if(Math.Abs(nums[left])>Math.Abs(nums[right]))
            {
                result[index] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[index] = nums[right] * nums[right];
                right--;
            }
            index--;
        }
        return result;
    }
}