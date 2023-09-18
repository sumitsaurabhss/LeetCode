public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var rowsCount = mat
            .Select((row, index) => new { Index = index, Count = row.Count(soldier => soldier == 1) })
            .OrderBy(row => row.Count)
            .ThenBy(row => row.Index)
            .Take(k)
            .Select(row => row.Index)
            .ToArray();

        return rowsCount;
    }
}