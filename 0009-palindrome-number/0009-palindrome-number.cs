public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        // Console.WriteLine(s);
        // return true;
        int i = 0, j = s.Length - 1;
        while(i < j) {
            if(s[i] != s[j])  return false;
            i++;
            j--;
        }
        return true;
    }
}