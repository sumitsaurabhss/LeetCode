public class Solution {
    public void ReverseString(char[] s) {
        Helper(s, 0, s.Length-1);
    }
    public static void Helper(char[] s, int i, int j){
        if(i >= j)  return;
        (s[i], s[j]) = (s[j], s[i]);
        Helper(s, i+1, j-1);
    }
}