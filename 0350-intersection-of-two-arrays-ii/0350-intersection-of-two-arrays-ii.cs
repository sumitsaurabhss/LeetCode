public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> l = new List<int>();
        int i=0, j=0;
        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i] < nums2[j])  i++;
            else if(nums1[i] > nums2[j])  j++;
            else  {
                l.Add(nums1[i]);
                i++;
                j++;
            }
        }
        return l.ToArray();
    }
}