public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int, List<int>> temp_group = new Dictionary<int, List<int>>();
        IList<IList<int>> result = new List<IList<int>>();
        
        for(int i = 0; i < groupSizes.Length; i++) {
            int size = groupSizes[i];
            if (!temp_group.ContainsKey(size)) {
                temp_group[size] = new List<int>();
            }
            temp_group[size].Add(i);
            
            if(temp_group[size].Count == size) {
                result.Add(new List<int>(temp_group[size]));
                temp_group[size].Clear();
            }
        }
        return result;
    }
}