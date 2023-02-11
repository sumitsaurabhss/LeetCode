public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> d= new Dictionary<char, char>();
        for(int i = 0; i < s.Length; i++){
            if(d.ContainsKey(s[i])){
                if(d[s[i]] != t[i])  return false;
            }
            else if(d.ContainsValue(t[i]))  return false;
            else  d.Add(s[i], t[i]);
        }
        return true;
    }
}