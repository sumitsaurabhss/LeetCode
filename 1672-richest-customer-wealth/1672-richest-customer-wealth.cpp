class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int n=accounts.size(), mx=0;
        for(int i=0; i<n; i++){
            int t=0, ni=accounts[i].size();
            for(int j=0; j<ni; j++){
                t+=accounts[i][j];
            }
            if(t>mx)  mx=t;
        }
        return mx;
    }
};