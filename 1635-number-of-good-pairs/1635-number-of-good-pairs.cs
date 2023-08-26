public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> id = new();
        int ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int c= id.GetValueOrDefault(nums[i],0);
            ans += c;
            id[nums[i]] = c + 1;
        }
        return ans;
    }
}