public class Solution {
    public IList<string> CellsInRange(string s) {
        IList<string> a = new List<string>();
        // char c1 = s[0], c2 = s[3];
        // int i1 = s[1], i2 = s[4];
        for(char c = s[0]; c <= s[3]; c++) {
            for(char i = s[1]; i <= s[4]; i++) {
                a.Add($"{c}{i}");
            }
        }
        return a;
    }
}