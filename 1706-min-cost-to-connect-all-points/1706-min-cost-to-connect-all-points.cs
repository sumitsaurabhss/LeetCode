// public class Solution {
//     public int MinCostConnectPoints(int[][] points) {
//         int n = points.Length;
//         int[] d = new int[n], c = new int[n];
//         for(int i = 0; i < n; i++) {
//             for(int j = 0; j < n; j++) {
//                 int t = 0;
//                 if(i == j)  continue;
//                 t = Math.Abs(points[j][0] - points[i][0]) + Math.Abs(points[j][1] - points[i][1]);
//                 if(d[j] == 0) {
//                     c[j] = i;
//                     d[j] = t;
//                 } 
//                 else if(t < d[j]) {
//                     c[j] = i;
//                     d[j] = t;
//                 }
//                 Console.WriteLine($"{i} {c[i]} {j} {c[j]} {d[j]}");
//             }
//         }
//         Console.WriteLine(String.Join(", ", c));
//         Console.WriteLine(String.Join(", ", d));
//         int s = 0;
//         for(int i = 0; i < n; i++) {
//             Console.Write($"{i} {c[i]} {c[c[i]]} {s} -- ");
//             if(i < c[i] || c[c[i]] != i)  s += d[i];
//             Console.WriteLine(s);
//         }
//         return s;
//     }
// }

public class Solution {
    public static int ManhattanDistance(int[] p1, int[] p2) {
        return Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
    }

    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        bool[] visited = new bool[n];
        Dictionary<int, int> heapDict = new Dictionary<int, int>() { {0, 0} };
        var minHeap = new SortedSet<(int w, int u)>() { (0, 0) };

        int mstWeight = 0;

        while (minHeap.Count > 0) {
            var (w, u) = minHeap.Min;
            minHeap.Remove(minHeap.Min);
            
            if (visited[u] || heapDict[u] < w) continue;

            visited[u] = true;
            mstWeight += w;

            for (int v = 0; v < n; v++) {
                if (!visited[v]) {
                    int newDistance = ManhattanDistance(points[u], points[v]);
                    if (newDistance < heapDict.GetValueOrDefault(v, int.MaxValue)) {
                        heapDict[v] = newDistance;
                        minHeap.Add((newDistance, v));
                    }
                }
            }
        }

        return mstWeight;
    }
}