public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int j = 0;
        foreach (char c in stones)
        {
            if (jewels.Contains(c))
            j++;
        }
        return j;
    }
}