public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int t = n / 3, c = 1;
        Array.Sort(nums);
        IList<int> l = new List<int>();
        for(int i = 1; i < n; i++) {
            if(nums[i] == nums[i-1])  c++;
            else {
                if(c > t)  l.Add(nums[i-1]);
                c = 1;
            }
        }
        if(c > t)  l.Add(nums[n-1]);
        return l;
    }
}