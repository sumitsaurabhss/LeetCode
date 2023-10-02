public class Solution {
    public bool WinnerOfGame(string colors) {
        int countA = 0;
        int countB = 0;
        
        for (int i = 0; i < colors.Length; i++) {
            char x = colors[i];
            int count = 0;
            
            while (i < colors.Length && colors[i] == x) {
                i++;
                count++;
            }
            
            if (x == 'A') {
                countA += Math.Max(count - 2, 0);
            } else if (x == 'B') {
                countB += Math.Max(count - 2, 0);
            }
            
            i--;
        }

        return countA > countB;
    }
}