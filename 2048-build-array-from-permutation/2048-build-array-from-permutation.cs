public class Solution {
    public int[] BuildArray(int[] nums) {
      int size = nums.Length;
      int[] a = new int[size];
      for(int i = 0, j = 0; i < size; i++) {
        j = nums[i];
        a[i] = nums[j];
      }
      return a;
    }
}