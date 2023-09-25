public class Solution {
    public char FindTheDifference(string s, string t) {
        char result = (char)0;
        foreach (char c in s + t) {
            result ^= c;
        }
        return result;
    }
}