// Last updated: 12/11/2025, 7:59:57 PM
public class OrderedStream {
    int index =1;
    PriorityQueue<string, int> pq;
    public OrderedStream(int n) {
        pq = new PriorityQueue<string, int>();
    }
    
    public IList<string> Insert(int idKey, string value) {
        pq.Enqueue(value, idKey);
        pq.TryPeek(out string currValue, out int currPointer);
        IList<string> list = new List<string>();
        while(currPointer == index)
        {
            list.Add(pq.Dequeue());
            index++;
            pq.TryPeek(out currValue, out currPointer);
        }
        return list;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */