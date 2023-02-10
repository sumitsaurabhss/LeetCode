public class Solution {
    public int PivotIndex(int[] nums) {
        int size = nums.Length;
        if(size == 1)  return 0;
        
        int [] leftRunningSum = new int[size];
        leftRunningSum[0] = nums[0];
        for(int i = 1; i < size; i++)  leftRunningSum[i] = nums[i] + leftRunningSum[i-1];
            
        int [] rightRunningSum = new int[size];
        rightRunningSum[size-1] = nums[size-1];
        for(int i = size-2; i >= 0; i--)  rightRunningSum[i] = nums[i] + rightRunningSum[i+1];
        
        if(rightRunningSum[1] == 0)  return 0;
        int pivotIndex = 0;
        for(int i = 1; i < size-1; i++)  if(leftRunningSum[i-1] == rightRunningSum[i+1])  return i;
        if(leftRunningSum[size-2]  == 0)  return size-1;
        
        return -1;
    }
}