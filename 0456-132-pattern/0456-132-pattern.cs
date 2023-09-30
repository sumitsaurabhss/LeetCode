// public class Solution {
//     public bool Find132pattern(int[] nums) {
//         int min = Int32.MaxValue, max = Int32.MinValue, t_min = Int32.MaxValue;
//         foreach(int num in nums) {
//             Console.WriteLine($"{t_min}  {min}  {max}  {num}");
//             if(num > max) {
//                 max = num;
//                 min = t_min;
//             }
//             if(num < t_min) {
//                 t_min = num;
//             }
//             if(num > min && num < max)  return true;
//         }
//         return false;
//     }
// }

public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> stack = new Stack<int>();
        int third = int.MinValue;

        for (int i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] < third) return true;
            while (stack.Count > 0 && stack.Peek() < nums[i]) {
                third = stack.Pop();
            }
            stack.Push(nums[i]);
        }
        return false;
    }
}