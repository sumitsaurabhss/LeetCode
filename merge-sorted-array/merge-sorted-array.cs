public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int [] t = new int[m+n];
        int i=0, j=0, k=0;
        while(i<m && j<n){
            if(nums1[i] < nums2[j]){
                t[k] = nums1[i];
                i++;
            }
            else{
                t[k] = nums2[j];
                j++;
            }
            k++;
        }
        while(i < m)  t[k++] = nums1[i++];
        while(j < n)  t[k++] = nums2[j++];
        for(i = 0; i < m+n; i++)  nums1[i] = t[i];
    }
}