public class Solution {
    public int CountOdds(int low, int high) {
        if(low % 2 == 0)  return  (int)Math.Ceiling((decimal)(high - low) / 2);
        else  return ((high - low) / 2 +1);
    }
}