public class Solution {
    public string TruncateSentence(string s, int k) {
        // int w = 0;
        // StringBuilder sb = new StringBuilder();
        // foreach(char c in s) {
        //     if(c == ' ') {
        //         w++;
        //         if(w == k)  break;
        //     }
        //     sb.Append(c);
        // }
        // return sb.ToString();
        int i = 0, w = 0, l = s.Length;
        while(i < l) {
            if(s[i] == ' ') {
                w++;
                if(w == k)  return s.Substring(0, i);
            }
            i++;
        }
        return s;
    }
}