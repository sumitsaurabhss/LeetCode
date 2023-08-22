public class Solution {
    public int RemovePalindromeSub(string s) {
        if(s.Length == 0)
            return 0;
        if(IsPalindrome(s))
            return 1;
        return 2;
    }

    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length-1;
        while(l < r) {
            if(s[l] != s[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}