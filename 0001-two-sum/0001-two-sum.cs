public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            //if we've seen the matching number to our number
            if(seen.ContainsKey(target-nums[i])){
                //then return the matching numbers index and our own
                return new int[]{seen[target-nums[i]], i};
            }
            //otherwise add our value to the dictionary and continue
            //if we've already seen this value we can ignore it since both indexes would be valid.
            if(!seen.ContainsKey(nums[i])){
                seen.Add(nums[i], i);
            }
            
        }
        return null;
        
        
        
        /*int[] r = new int[2]{0,0};
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    r[0] = i;
                    r[1]= j;
                }
            }
        }
        return r;*/
    }
}