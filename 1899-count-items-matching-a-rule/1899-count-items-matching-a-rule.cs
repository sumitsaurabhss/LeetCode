public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int n = 0, t = 0;
        if(ruleKey == "type")  t = 0;
        else if(ruleKey == "color")  t = 1;
        else  t = 2;
        foreach(IList<string> s in items) {
            if(s[t] == ruleValue)
                n++;
        }
        return n;
    }
}