public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int count = 0;
        HashSet<int> hash_num = new HashSet<int>();
        foreach(int num in nums)
        {
            if(hash_num.Contains(num - diff) && hash_num.Contains(num - 2 * diff))
                count++;
            hash_num.Add(num);  
        }
        return count;
    }
}