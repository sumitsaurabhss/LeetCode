public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int n = encoded.Length;
        int[] d = new int[n+1];
        d[0] = first;
        for(int i = 0; i < n; i++) {
            d[i+1] = d[i] ^ encoded[i];
        }
        return d;
    }
}