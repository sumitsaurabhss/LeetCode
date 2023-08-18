public class Solution {
    public string MakeSmallestPalindrome(string s) {
        StringBuilder str = new StringBuilder(s);
        int l = 0, r = s.Length-1;
        while (l < r) {
            if(str[l] < str[r])
                str[r] = str[l];
            else if(str[l] > str[r])
                str[l] = str[r];
            l++;
            r--;
        }
        s = str.ToString();
        return s;
    }
}