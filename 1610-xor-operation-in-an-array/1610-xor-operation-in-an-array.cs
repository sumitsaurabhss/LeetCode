public class Solution {
    public int XorOperation(int n, int start) {
        int a = 0;
        for(int i = 0; i < n; i++) {
            a ^= start;
            start += 2;
        }
        return a;
    }
}