public class Solution {
    public string DecodeMessage(string key, string message) {
        char[] a = new char[26];
        char t = 'a';
        foreach(char c in key) {
            if(c == ' ')  continue;
            int i = c - 'a';
            if(a[i] == '\0') {
                a[i] = t;
                t++;
            }
        }
        StringBuilder s = new StringBuilder();
        foreach(char c in message) {
            if(c == ' ') {
                s.Append(' ');
                continue;
            }
            int i = c - 'a';
            s.Append(a[i]);
        }
        return s.ToString();
    }
}