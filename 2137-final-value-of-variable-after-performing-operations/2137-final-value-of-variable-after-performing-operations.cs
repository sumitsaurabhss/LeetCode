public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach(string op in operations) {
            if(op == "++X" || op == "X++")
                x++;
            else 
                x--;
        }
        return x;
    }
}