public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i=0, j=0;
         if(string.IsNullOrEmpty(s))  return true;
         else if(string.IsNullOrEmpty(t))  return false;
        while(j<t.Length){
            //Console.WriteLine($"{i} {j} {s[i]} {t[j]}");
            if(s[i] == t[j])  i++;
            if(i == s.Length)  return true;
            j++;
        }
        return i == s.Length;
    }
}