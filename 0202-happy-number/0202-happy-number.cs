public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> h = new HashSet<int>();
        h.Add(n);
        while(n > 0){
            int t = 0;
            while(n>0){
                t += (int)Math.Pow(n%10, 2);
                n /= 10;
            }
            if(t == 1)  return true;
            if(h.Contains(t))  return false;
            h.Add(t);
            n = t;
        }
        return false;
    }
}