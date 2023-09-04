public class Solution {
    public int CountDigits(int num) {
        int r = 0, n = num, c = 0;
        while(n > 0) {
            r = n % 10;
            if(num % r == 0)  c++;
            n /= 10;
        }
        return c;
    }
}