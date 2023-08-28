public class Solution {
    public int MinimumSum(int num) {
        int[] arr = new int[4];
        for(int i = 0; i < 4; i++) {
            arr[i] = num % 10;
            num /= 10; 
        }
        Array.Sort(arr);
        return (arr[0] + arr[1]) * 10 + (arr[2] + arr[3]);
    }
}