public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] a = new int[n * 2];
        Array.Copy(nums, a, n);
        Array.Copy(nums, 0, a, n, n);
        return a;
    }
}