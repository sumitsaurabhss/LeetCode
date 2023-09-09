public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        // Array.Sort(nums);
        // int c = Find(nums, target, 0);
        // return c;
        // From solutions
        int[] dp = new int[target + 1];
        dp[0] = 1;
        
        for (int i = 1; i <= target; i++) {
            foreach (int num in nums) {
                if (i - num >= 0) {
                    dp[i] += dp[i - num];
                }
            }
        }
        return dp[target];
    }
    // public int Find(int[] a, int t, int s) {
    //     //Console.Write($"s : {s} ---");
    //     int k = 0;
    //     foreach(int i in a) {
    //         s += i;
    //         Console.Write($"i :  {i}, s : {s}, ");
    //         if(s == t)  return k + 1;
    //         if(s > t)  return k;
    //         k += Find(a, t, s);
    //         Console.WriteLine($"k : {k}");
    //     }
    //     return k;
    // }
}