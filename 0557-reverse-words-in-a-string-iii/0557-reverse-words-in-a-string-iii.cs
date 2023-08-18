public class Solution {
    public string ReverseWords(string s) {
        StringBuilder sb = new StringBuilder(s);
        int l = 0, r = 0, size = s.Length;
        while(r < size) {
            if(sb[r] == ' ') {
                ReverseWord(sb, l, r-1);
                l = r+1;
            }
            r++;
        }
        ReverseWord(sb, l, r-1);
        return sb.ToString();
    }

    public void ReverseWord(StringBuilder sb, int l, int r) {
        char t;
        while(l < r) {
            t = sb[l];
            sb[l] = sb[r];
            sb[r] = t;
            l++;
            r--;
        }
    }
}