public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        // Dictionary<int, int> d = new();
        // foreach(int num in nums) {
        //     if(d.ContainsKey(num))
        //         d[num]++;
        //     else
        //         d.Add(num, 1);
        // }
        // int[] a = new int[nums.Length];
        // for(int i = 0; i < nums.Length; i++) {
        //     Console.WriteLine($"{nums[i]} {d[nums[i]]}");
        // }
        //     //a[i] = d[nums[i]];
        var list = nums.ToList();

        list.Sort();

        var res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            res[i] = list.IndexOf(nums[i]);
        }

        return res;
        //return a;
    }
}