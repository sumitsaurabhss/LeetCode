public class Solution {
    public int SumOfMultiples(int n) {
        int sum = 0;
        // for(int i = 3; i <= n; i++) {
        //     if(i % 3 == 0)  sum += i;
        //     else if(i % 5 == 0)  sum += i;
        //     else if(i % 7 == 0)  sum += i;
        // }
        while(n > 2) {
            if(n % 3 == 0)  sum += n;
            else if(n % 5 == 0)  sum += n;
            else if(n % 7 == 0)  sum += n;
            n--;
        }
        return sum;
    }
}