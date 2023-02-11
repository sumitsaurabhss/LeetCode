public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length-1;
        char c;
        for(int i = 0; i <= n/2; i++){
            c = s[n-i];
            s[n-i] = s[i];
            s[i] = c;
        }
    }
}