public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        /*string s = n.ToString();
        Console.WriteLine(s);
        foreach(char c in s)  if(c == '1')  count++;*/
        
        while(n > 0){
            if(n % 2 == 1)  count++;
            n /= 2;
        }
        
        return count;
    }
}