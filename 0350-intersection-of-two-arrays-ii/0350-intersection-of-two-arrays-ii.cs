public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> l = new List<int>();
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++){
            if(d.ContainsKey(nums1[i]))  d[nums1[i]]++;
            else  d.Add(nums1[i], 1);
        }
        for(int i = 0; i < nums2.Length; i++){
            if(d.ContainsKey(nums2[i])){
                l.Add(nums2[i]);
                d[nums2[i]]--;
                if(d[nums2[i]] == 0)  d.Remove(nums2[i]);
            }
        }
        // Array.Sort(nums1);
        // Array.Sort(nums2);
        // int i=0, j=0;
        // while(i<nums1.Length && j<nums2.Length){
        //     if(nums1[i] < nums2[j])  i++;
        //     else if(nums1[i] > nums2[j])  j++;
        //     else  {
        //         l.Add(nums1[i]);
        //         i++;
        //         j++;
        //     }
        // }
        return l.ToArray();
    }
}