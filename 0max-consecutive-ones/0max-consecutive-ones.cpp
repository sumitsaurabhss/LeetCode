class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int max = 0, t=0;
        for(int i=0; i<nums.size(); i++){
            if(nums[i]==1)  t++;
            else{
                if(t>max)  max=t;
                t=0;
            }
        }
        if(t>max)  max=t;
        return max;
    }
};