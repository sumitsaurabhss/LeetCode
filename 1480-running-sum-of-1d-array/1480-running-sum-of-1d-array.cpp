class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        vector<int> r;
        r.push_back(nums[0]);
        for(int i=1; i<nums.size(); i++){
            r.push_back(nums[i]+r[i-1]);
        }
        return r;
    }
};