public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> distinct = new HashSet<int>();
        foreach(int num in nums) {
            if(distinct.Contains(num)) {
                return true;
            }
            distinct.Add(num);
        }
        return false;
    }
}

// public class Solution {
//     public bool ContainsDuplicate(int[] nums) {
//         Array.Sort(nums);
//         for(int i = 1; i < nums.Length; i++)  if(nums[i] == nums[i-1])  return true;
//         return false;
//     }
// }