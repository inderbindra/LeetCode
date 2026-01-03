// Last updated: 1/3/2026, 3:55:00 PM
1public class MedianFinder {
2    PriorityQueue<int, int> leftMaxHeap;
3    PriorityQueue<int, int> rightMinHeap;
4    public MedianFinder() {
5        leftMaxHeap = new();
6        rightMinHeap = new();
7    }
8    
9    public void AddNum(int num) {
10        rightMinHeap.Enqueue(num, num);
11         //This will remove the minimum num from rightQueue.
12        int val = rightMinHeap.Dequeue();
13        leftMaxHeap.Enqueue(val, -val);
14
15        if(leftMaxHeap.Count - rightMinHeap.Count > 1)
16        {
17            val = leftMaxHeap.Dequeue();
18            rightMinHeap.Enqueue(val, val);
19        }
20    }
21    
22    public double FindMedian() {
23        double median = 0.0;
24        if(leftMaxHeap.Count == rightMinHeap.Count)
25        {
26            median = (leftMaxHeap.Peek() + rightMinHeap.Peek())/2.0;
27        }
28        else
29        {
30            median = leftMaxHeap.Peek();
31        }
32        return median;
33    }
34}
35
36/**
37 * Your MedianFinder object will be instantiated and called as such:
38 * MedianFinder obj = new MedianFinder();
39 * obj.AddNum(num);
40 * double param_2 = obj.FindMedian();
41 */