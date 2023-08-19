public class Solution {
    public string ReversePrefix(string word, char ch) {
        StringBuilder s = new StringBuilder(word);
        int size  = word.Length;
        for(int i = 0; i < size; i++) {
            if(s[i] == ch){
                Reverse(s, 0, i);
                break;
            }
        }
        return s.ToString();
    }

    public void Reverse(StringBuilder s, int l, int r) {
        char t;
        while(l < r) {
            t = s[l];
            s[l] = s[r];
            s[r] = t;
            l++;
            r--;
        }
    }
}