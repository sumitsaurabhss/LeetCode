public class Solution {
    public void DuplicateZeros(int[] arr) {
        int n=arr.Length;
        for(int i=0; i<n; i++){
            if(arr[i] == 0){
                int k = n-2;
                while(k > i)  arr[k+1] = arr[k--];
                i++;
                if(i<n)  arr[i] = 0;
            }
        }
        
    }
}