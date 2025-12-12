// Last updated: 12/11/2025, 8:01:50 PM
public class Solution {
    Stack<string> stack;
    Dictionary<string, IList<string>> adjMap;
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        stack = new();
        adjMap = new();
        tickets = tickets.OrderByDescending(i=> i[1]).ToList();
        for(int i=0; i<tickets.Count; i++)
        {
            adjMap.TryAdd(tickets[i][0], new List<string>());
            adjMap[tickets[i][0]].Add(tickets[i][1]);
        }
        GetItinerary("JFK");
        return stack.ToList();
    }
    private void GetItinerary(string airport)
    {
        IList<string> dest;
        string destAirport;
        if(adjMap.ContainsKey(airport))
        {
            dest = adjMap[airport];
            while(dest != null && dest.Count > 0)
            {
                destAirport = dest[dest.Count-1];
                dest.RemoveAt(dest.Count-1);
                GetItinerary(destAirport);
            }
        }
        stack.Push(airport);
    }
}