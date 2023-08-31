public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        ArrayList ans = new ArrayList();  // Create an ArrayList to store the decompressed list
        for (int i = 0; i < nums.Length; i++) {
            int fre = nums[i++];  // Get the frequency value at index i and increment i
            int val = nums[i];    // Get the value at the next index (i+1)
            for (int j = 0; j < fre; j++) {
                ans.Add(val);  // Add the value 'val' to the ans ArrayList 'fre' times
            }
        }
        return (int[])ans.ToArray(typeof(int));  // Convert the ArrayList to an array and return it as the decompressed list
    }
}