public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var graph = new Dictionary<string, List<string>>();
        
        foreach (var ticket in tickets) {
            if (!graph.ContainsKey(ticket[0])) {
                graph[ticket[0]] = new List<string>();
            }
            graph[ticket[0]].Add(ticket[1]);
        }
        
        foreach (var destinations in graph.Values) {
            destinations.Sort((a, b) => b.CompareTo(a));
        }
        
        var itinerary = new List<string>();
        
        void DFS(string airport) {
            while (graph.ContainsKey(airport) && graph[airport].Count > 0) {
                var next = graph[airport][^1];
                graph[airport].RemoveAt(graph[airport].Count - 1);
                DFS(next);
            }
            itinerary.Add(airport);
        }
        
        DFS("JFK");
        itinerary.Reverse();
        
        return itinerary;
    }
}