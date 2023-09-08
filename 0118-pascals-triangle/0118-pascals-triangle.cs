public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // IList<IList<int>> p = new List<IList<int>>();
        // p[0][0] = 1;
        // for(int i = 1; i < numRows; i++) {
        //     for(int j = 0; j < i; j++) {
        //         if(j == 0 || j == i)  p[i][j] = p[i-1][j];
        //         else  p[i][j] = p[i-1][j] + p[i-1][j-1];
        //     }
        // }
        // return p;
        List<IList<int>> triangle = new List<IList<int>>();
        if (numRows == 0) return triangle;
        triangle.Add(new List<int>() { 1 });
        for (int i = 1; i < numRows; i++) {
            List<int> prevRow = (List<int>)triangle[i - 1];
            List<int> newRow = new List<int> { 1 };
            for (int j = 1; j < prevRow.Count; j++) {
                newRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            newRow.Add(1);
            triangle.Add(newRow);
        }
        return triangle;
    }
}