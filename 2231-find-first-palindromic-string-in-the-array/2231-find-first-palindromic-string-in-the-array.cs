public class Solution {
    public string FirstPalindrome(string[] words) {
        int size = words.Length;
        string s = "";
        for(int i = 0; i < size; i++) {
            int l = 0, r = words[i].Length - 1;
            while(l < r) {
                if(words[i][l] != words[i][r]) break;
                l++;
                r--;
            }
            if(l >= r) {
                s = words[i];
                break;
            }
        }
        return s;
    }
}