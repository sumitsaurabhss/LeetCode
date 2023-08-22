public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] a = new int[n*2];
        int i = 0, j = 0;
        while(j < n) {
            a[i] = nums[j];
            i++;
            a[i] = nums[n+j];
            i++;
            j++;
        }
        return a;
    }
}