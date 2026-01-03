// Last updated: 1/3/2026, 4:03:32 PM
1public class MedianFinder {
2    PriorityQueue<int, int> minHeap;
3    PriorityQueue<int, int> maxHeap;
4
5    public MedianFinder() {
6        minHeap = new();
7        maxHeap = new();
8    }
9    
10    public void AddNum(int num) {
11        minHeap.Enqueue(num, num);
12        
13        // This logic is added to handle negative values
14        // Removing minimum values from minHeap and assigning to maxHeap.
15        int val = minHeap.Dequeue();
16        maxHeap.Enqueue(val, -val);
17
18        if(maxHeap.Count - minHeap.Count > 1)
19        {
20            val = maxHeap.Dequeue();
21            minHeap.Enqueue(val, val);
22        }
23    }
24    
25    public double FindMedian() {
26        double median = 0.0;
27        
28        if(minHeap.Count == maxHeap.Count)        
29        {
30            median = (minHeap.Peek() + maxHeap.Peek()) / 2.0;
31        }
32        else
33        {
34            median = maxHeap.Peek();
35        }
36        return median;
37    }
38}
39
40/**
41 * Your MedianFinder object will be instantiated and called as such:
42 * MedianFinder obj = new MedianFinder();
43 * obj.AddNum(num);
44 * double param_2 = obj.FindMedian();
45 */