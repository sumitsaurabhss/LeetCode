class Solution {
public:
    int totalDig(int n){
        int counter = 0;
        while(n){
            counter++;
            n /= 10;
        }
        return counter;
    }
    int findNumbers(vector<int>& nums) {
        int counter=0;
        for(int i = 0; i < nums.size(); i++){
            if(totalDig(nums[i]) % 2 == 0)  counter++;
        }
        return counter;
    }
};