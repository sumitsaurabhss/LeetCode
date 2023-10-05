// Using sort method
// public class Solution {
//     public IList<int> MajorityElement(int[] nums) {
//         int n = nums.Length;
//         int t = n / 3, c = 1;
//         Array.Sort(nums);
//         IList<int> list = new List<int>();
//         for(int i = 1; i < n; i++) {
//             if(nums[i] == nums[i-1])  c++;
//             else {
//                 if(c > t)  list.Add(nums[i-1]);
//                 c = 1;
//             }
//         }
//         if(c > t)  list.Add(nums[n-1]);
//         return list;
//     }
// }

// Using HashSet method
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        int t = n / 3;
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        IList<int> list = new List<int>();
        foreach(int num in nums) {
            if(dictionary.ContainsKey(num))  dictionary[num]++;
            else  dictionary.Add(num, 1);
        }
        foreach(var kvp in dictionary) {
            if(kvp.Value > t)  list.Add(kvp.Key);
        }
        return list;
    }
}