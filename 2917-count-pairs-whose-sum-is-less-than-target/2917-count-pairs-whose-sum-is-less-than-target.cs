public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int[] a = nums.ToArray();
        Array.Sort(a);
        //Console.Write(String.Join(", ", a));
        int counter = 0;
        int l = 0, r = a.Length - 1;
        while(l < r) {
            if(a[l] + a[r] < target) {
                counter += r - l;
                l++;
            }
            else {
                r--;
            }
        }
        return counter;
    }
}