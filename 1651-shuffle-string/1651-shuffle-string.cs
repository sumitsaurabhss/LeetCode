public class Solution {
    public string RestoreString(string s, int[] indices) {
        int n = s.Length;
        StringBuilder sb = new StringBuilder(s);
        Console.WriteLine(sb.Capacity);
        for(int i = 0; i < n; i++) {
            sb[indices[i]] = s[i];
        }
        return sb.ToString();
    }
}