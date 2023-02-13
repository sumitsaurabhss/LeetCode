public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int t = -1;
        bool b=false;
        for(int i=0; i<s1.Length; i++){
            if(s1[i] != s2[i]){
                if(b)  return false;
                if(t >= 0) {
                    if(s1[i] != s2[t] || s1[t] != s2[i])  return false;
                    b = true;
                    t = -1;
                }
                else  t = i;
            }
        }
        if(t == -1)  return true;
        return false;
    }
}