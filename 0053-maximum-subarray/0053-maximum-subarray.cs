public class Solution {
    public int MaxSubArray(int[] nums) {
        int runningSum = 0;
        int largestSum = int.MinValue;
        foreach(int num in nums){
            runningSum += num;
            if(runningSum > largestSum)  largestSum = runningSum;
            if(runningSum < 0)  runningSum = 0;
            //Console.WriteLine($"{runningSum} {largestSum}");
        }
        return largestSum;
    }
}