public class Solution {
    public int BalancedStringSplit(string s) {
        int m = 0, t = 0;
        foreach(char c in s) {
            if(c == 'L')
                t++;
            else 
                t--;
            if(t == 0)
                m++;
        }
        return m;
    }
}