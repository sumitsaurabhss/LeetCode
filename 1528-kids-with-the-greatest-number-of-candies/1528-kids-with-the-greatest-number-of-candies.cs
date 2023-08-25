public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = candies.Max();
        IList<bool> canBeMax = new List<bool>();
        foreach(int candy in candies) {
            if(candy + extraCandies >= max)
                canBeMax.Add(true);
            else 
                canBeMax.Add(false);
        }
        return canBeMax;
    }
}