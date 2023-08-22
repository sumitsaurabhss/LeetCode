public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        // int[] a = nums.ToArray();
        // Array.Sort(a);
        // //Console.Write(String.Join(", ", a));
        // int counter = 0;
        // int l = 0, r = a.Length - 1;
        // while(l < r) {
        //     if(a[l] + a[r] < target) {
        //         counter += r - l;
        //         l++;
        //     }
        //     else {
        //         r--;
        //     }
        // }
        // return counter;
        int ans = 0;
        for (int i = 0; i < nums.Count - 1; i++)
            for (int j = i + 1; j < nums.Count; j++)
                if (nums[i] + nums[j] < target)
                    ans++;
        return ans;
    }
}